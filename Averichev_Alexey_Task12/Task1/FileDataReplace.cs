using System;
using System.Text;
using System.IO;
using System.Threading;

namespace Task1
{
    public class FileDataReplace
    {
        private DirectoryInfo dir;
        private FileInfo file;

        private int count;
        private int[] array;

        public delegate int Func(int x);
        private Func func;

        public delegate void Notification();
        public event Notification ReplaceDone;

        public DirectoryInfo Directory
        {
            get
            {
                return dir;
            }

            set
            {
                if (!value.Exists)
                {
                    throw new Exception("Directory not exists");
                }

                dir = value;
            }
        }

        public FileInfo FileName
        {
            get
            {
                return file;
            }

            set
            {
                if (!value.Exists)
                {
                    throw new Exception("File not exists");
                }

                file = value;
            }
        }

        public FileDataReplace(
            string dir,
            string name,
            Func modificator)
        {
            Directory = new DirectoryInfo(dir);
            var path = Path.Combine(Directory.FullName, name);
            FileName = new FileInfo(path);
            func = modificator;
        }

        private void ReadFile()
        {
            count = File.ReadAllLines(FileName.ToString()).Length;
            array = new int[count];

            using (StreamReader sr = FileName.OpenText())
            {
                string fileContent;
                int num;

                for (var i = 0; i < count; i++)
                {
                    fileContent = sr.ReadLine();

                    if (!int.TryParse(fileContent, out num))
                    {
                        array[i] = 0;
                        continue;
                    }

                    array[i] = num;
                }
            }
        }

        private void WriteFile()
        {
            using (StreamWriter sw = FileName.CreateText())
            {
                for (var i = 0; i < count; i++)
                {
                    sw.WriteLine(array[i]);
                }
            }
        }

        private void ModifyData()
        {
            for (var i = 0; i < count; i++)
            {
                array[i] = func(array[i]);
            }
        }

        public void Replace()
        {
            ThreadStart ReplaceInThread = () =>
            {
                ReadFile();
                ModifyData();
                WriteFile();

                ReplaceDone?.Invoke();
            };

            Thread thread = new Thread(ReplaceInThread);

            thread.Start();
        }

        public override string ToString()
        {
            if (array == null)
            {
                ReadFile();
            }

            var result = new StringBuilder();

            for (var i = 0; i < count; i++)
            {
                result.Append(array[i]);
                result.Append("\n");
            }

            return result.ToString();
        }
    }
}
