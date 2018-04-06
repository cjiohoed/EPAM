using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"D:\C#\Tasks\Task12");
            var fileName = "disposable_task_file.txt";
            string filePath = Path.Combine(dir.FullName, fileName);
            FileInfo file = new FileInfo(filePath);

            if (!file.Exists)
            {
                throw new Exception("File not exists");
            }

            var list = new List<int>();

            // строк в файле
            int count = File.ReadAllLines(filePath).Length;

            // готовим массив
            var array = new int[count];

            using (StreamReader sr = file.OpenText())
            {
                string fileContent;
                int num;

                for(var i = 0; i < count; i++)
                {
                    fileContent = sr.ReadLine();

                    if (!int.TryParse(fileContent, out num))
                    {
                        array[i] = 0;
                        continue;
                    }

                    array[i] = num * num;

                    Console.WriteLine(array[i]);
                }
            }

            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }

    public class FileClass : IDisposable
    {
        private readonly StreamWriter fileStream;

        public string FileName
        {
            get
            {
                return FileName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("File is null or empty");
                }
            }
        }

        public FileClass(string filename)
        {
            FileName = filename;
        }

        public new void Dispose()
        {
            if (fileStream != null)
            {
                fileStream.Dispose();
            }
        }
    }
}
