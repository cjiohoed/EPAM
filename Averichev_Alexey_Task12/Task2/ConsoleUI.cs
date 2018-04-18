using System;
using System.IO;

namespace Task2
{
    public static class ConsoleUI
    {
        public static void StopWatch()
        {
            Console.WriteLine("Для выхода из программы нажмите q");
            while (Char.ToLower(Console.ReadKey().KeyChar) != 'q') ;
        }

        public static void Watch()
        {
            Watcher watch = new Watcher(Directory.GetCurrentDirectory());
            watch.Start();
            StopWatch();
        }
        public static void Backup()
        {
            Watcher watch = new Watcher(Directory.GetCurrentDirectory());
            Console.WriteLine("Доступные для восстановления: ");
            Display(watch.GetBackups());
            Console.Write("Введите дату отката: ");
            string selectBackup = Console.ReadLine();
            watch.Restore(selectBackup);
        }

        public static void Display(string[] dirs)
        {
            foreach (string dir in dirs)
            {
                Console.WriteLine(Path.GetFileName(dir));
            }
        }
    }
}
