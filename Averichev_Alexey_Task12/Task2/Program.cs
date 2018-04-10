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
            //var dir = @"D:\C#\Tasks\Task12\watcher\dir";
            var dir = Directory.GetCurrentDirectory();

            var prog = new DataKeeper(dir, DataKeeper.Mode.Watch);
            //var prog = new Observer(dir, SelectMode());
            prog.Start();

            //Console.WriteLine(prog.Directory.FullName);
            //Console.WriteLine(prog.BackupDir);

            Console.ReadKey();

        }

        public static DataKeeper.Mode SelectMode()
        {
            var num = default(int);
            Console.WriteLine("Выберите режим работы программы:\n(1) Наблюдение\n(2) Откат изменений");
            do
            {
                int.TryParse(Console.ReadLine(), out num);
                switch (num)
                {
                    case 1:
                        return DataKeeper.Mode.Watch;
                    case 2:
                        return DataKeeper.Mode.Recovery;
                    default:
                        Console.Write("Введите еще раз: ");
                        break;
                }
            }
            while (true);
        }
    }

    public class DataKeeper
    {
        private Mode mode;

        public delegate void Notification();
        public event Notification Changed;

        public enum Mode { Watch = 1, Recovery = 2 }

        private static DirectoryInfo dir;

        public DirectoryInfo bkpDir;

        public DirectoryInfo BackupDir
        {
            get
            {
                return bkpDir;
            }

            set
            {
                if (!value.Exists)
                {
                    value.Create();
                }

                bkpDir = value;
            }
        }

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



        static ThreadStart Recovery = () =>
        {
            //восстановление
            Console.Write("Восстановление!");
            //Console.ReadKey();
        };

        Thread thread;

        public DataKeeper(string dir, Mode mode)
        {
            Directory = new DirectoryInfo(dir);
            //BackupDir = new DirectoryInfo(Directory.Parent.ToString() + "\\bkp");
            BackupDir = new DirectoryInfo(Path.Combine(Directory.Parent.FullName) + "\\.bkp");
            SetMode(mode);
        }

        public void SetMode(Mode mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case Mode.Watch:
                    Watcher();
                    break;

                case Mode.Recovery:
                    thread = new Thread(Recovery);
                    break;
            }
        }

        public void Start()
        {
            thread.Start();
        }

        public void Stop()
        {

        }

        public void Watcher()
        {

            ThreadStart watch = () =>
            {
                Console.WriteLine("Наблюдение!");

                var watcher = new FileSystemWatcher
                {
                    Path = Directory.FullName.ToString(),
                    NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                               | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                    Filter = "*.txt",
                    IncludeSubdirectories = true
                };

                watcher.Changed += new FileSystemEventHandler(OnChanged);

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press \'q\' to quit.");
                while (Console.Read() != 'q') ;
            };

            thread = new Thread(watch);

            
        }

        public void OnChanged()
        {
            Console.WriteLine("Изменение!");
        }

    }
}
