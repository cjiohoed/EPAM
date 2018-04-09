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
            //var dir = Directory.GetCurrentDirectory();


            var prog = new Observer(dir, SelectMode());
            //prog.Start();
            Console.WriteLine(prog.bkpDir);


            Console.ReadKey();

        }

        public static Observer.Mode SelectMode()
        {
            var num = default(int);
            Console.WriteLine("Выберите режим работы программы:\n(1) Наблюдение\n(2) Откат изменений");
            do
            {
                int.TryParse(Console.ReadLine(), out num);
                switch (num)
                {
                    case 1:
                        return Observer.Mode.Watch;
                    case 2:
                        return Observer.Mode.Recovery;
                    default:
                        Console.Write("Введите еще раз: ");
                        break;
                }
            }
            while (true);
        }
    }

    public class Observer
    {
        private Mode mode;

        public enum Mode { Watch = 1, Recovery}

        private DirectoryInfo dir;

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

        static ThreadStart Watch = () =>
        {
            //наблюдение
            Console.Write("Наблюдение!");
            //Console.ReadKey();
        };

        static ThreadStart Recovery = () =>
        {
            //восстановление
            Console.Write("Восстановление!");
            //Console.ReadKey();
        };

        Thread thread;

        public Observer(string dir, Mode mode)
        {
            Directory = new DirectoryInfo(dir);
            bkpDir = new DirectoryInfo(dir + "\\bkp");
            SetMode(mode);
        }

        public void SetMode(Mode mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case Mode.Watch:
                    thread = new Thread(Watch);
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

    }
}
