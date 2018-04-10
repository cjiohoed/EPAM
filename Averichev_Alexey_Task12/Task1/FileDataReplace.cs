using System;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace Task1
{
    public class FileDataReplace
    {
        private DirectoryInfo dir;
        private FileInfo file;   

        public delegate int Func(int x);
        public Func func;

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

        private List<int> GetNumbers()
        {
            var file = File.ReadAllLines(FileName.ToString());     
            var list = new List<int>();

            using (StreamReader sr = FileName.OpenText())
            {
                string fileContent;
                int num;

                for (var i = 0; i < file.Length; i++)
                {
                    fileContent = sr.ReadLine();

                    if (int.TryParse(fileContent, out num))
                    {
                        list.Add(num);
                    } 
                }
            }

            return list;
        }

        private void WriteFile(List<int> source)
        {
            using (StreamWriter sw = FileName.CreateText())
            {
                for (var i = 0; i < source.Count; i++)
                {
                    sw.WriteLine(source[i]);
                }
            }
        }

        private List<int> GetModifyData(List<int> source)
        {
            var list = new List<int>();

            foreach (var item in source)
            {
                list.Add(func(item));
            }

            return list;
        }

        public void Replace()
        {
            ThreadStart ReplaceInThread = () =>
            {
                var source = GetNumbers();
                source = GetModifyData(source);
                WriteFile(source);

                ReplaceDone?.Invoke();
            };

            Thread thread = new Thread(ReplaceInThread);

            thread.Start();
        }
    }
}
