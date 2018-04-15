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

            var prog = new Watcher(dir, Watcher.Mode.Watch);
            prog.Init();
            prog.Start();

            //var prog = new Watcher(dir, SelectMode());

            //Console.WriteLine(prog.Directory.FullName);
            //Console.WriteLine(prog.BackupDir);

            Console.ReadKey();

        }

        public static Watcher.Mode SelectMode()
        {
            var num = default(int);
            Console.WriteLine("Выберите режим работы программы:\n(1) Наблюдение\n(2) Откат изменений");
            do
            {
                int.TryParse(Console.ReadLine(), out num);
                switch (num)
                {
                    case 1:
                        return Watcher.Mode.Watch;
                    case 2:
                        return Watcher.Mode.Recovery;
                    default:
                        Console.Write("Введите еще раз: ");
                        break;
                }
            }
            while (true);
        }


    }

    public class Watcher
    {
        private Mode mode;

        private delegate void progMode();


        FileSystemWatcher myWatcher;

        public enum Mode { Watch = 1, Recovery = 2 }

        private static DirectoryInfo dir;

        public DirectoryInfo bkpDir;

        public DirectoryInfo BkpDir
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

        public DirectoryInfo Dir
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

        public Watcher(string dir, Mode mode)
        {
            Dir = new DirectoryInfo(dir);
            //BackupDir = new DirectoryInfo(Directory.Parent.ToString() + "\\bkp");
            BkpDir = new DirectoryInfo(Path.Combine(Dir.Parent.FullName) + "\\.bkp");
            this.mode = mode;
        }

        public void Init()
        {
            myWatcher = new FileSystemWatcher
            {
                IncludeSubdirectories = true,
                Path = Dir.FullName.ToString(),
                NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Filter = "*.txt"
            };

            myWatcher.Changed += OnChanged;
            myWatcher.Created += OnChanged;
            myWatcher.Deleted += OnChanged;
            myWatcher.Renamed += OnChanged;
        }

        public void Start()
        {
            switch (mode)
            {
                case Mode.Watch:
                    myWatcher.EnableRaisingEvents = true;
                    break;
                case Mode.Recovery:
                    break;
            }
        }

        public void Stop()
        {
            myWatcher.EnableRaisingEvents = false;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string destinationPath = GetBackupPath(DateTime.Now.ToString("d_M_yyyy_hh_mm_ss"));
            CopyAllTextFiles(Dir.FullName.ToString(), destinationPath);

            Console.WriteLine("ИЗМЕНЕНИЕ");
        }

        private string GetBackupPath(string date)
        {
            return Path.Combine(BkpDir.FullName.ToString(), date);
        }

        private void CopyAllTextFiles(string source, string destination)
        {
            foreach (string dir in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dir.Replace(source, destination));
            }
            foreach (string path in Directory.GetFiles(source, "*.txt", SearchOption.AllDirectories))
            {
                File.Copy(path, path.Replace(source, destination), true);
            }
        }

    }
}
