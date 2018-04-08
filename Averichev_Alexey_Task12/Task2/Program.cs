using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = @"D:\C#\Tasks\Task12\dir";
            var fileName = "disposable_task_file.txt";

            var prog = new Observer(dir, fileName);

        }
    }

    public class Observer
    {
        private DirectoryInfo dir;
        private FileInfo file;

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


        static ThreadStart Observe = () =>
        {
            //наблюдение
        };

        Thread thread = new Thread(Observe);

        public Observer(string dir, string name)
        {
            Directory = new DirectoryInfo(dir);
            var path = Path.Combine(Directory.FullName, name);
            FileName = new FileInfo(path);
        }

        public void Start()
        {
            thread.Start();
        }
    }
}
