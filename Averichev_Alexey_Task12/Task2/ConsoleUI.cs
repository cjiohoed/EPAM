using System;
using System.IO;

namespace Task2
{
    public static class ConsoleUI
    {
        public static string path = Path.Combine(
            Directory.GetCurrentDirectory(),
            "ControlFolder");

        public static void Start()
        {
            Console.WriteLine(
                "Выберите режим работы: \n" +
                "1 - Наблюдение\n" +
                "2 - Восстановление");
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            if (Char.ToLower(key.KeyChar) == '1')
            {
                Watch();
            }
            if (Char.ToLower(key.KeyChar) == '2')
            {
                Backup();
            }

            Console.ReadKey();
        }

        public static void StopWatch()
        {
            Console.WriteLine("Для выхода из программы нажмите q");
            while (Char.ToLower(Console.ReadKey().KeyChar) != 'q') ;
        }

        public static void Watch()
        {
            ConsoleLogger logger = new ConsoleLogger();
            Watcher watch = new Watcher(path, logger);
            watch.Start();
            StopWatch();
        }

        public static void Backup()
        {
            ConsoleLogger logger = new ConsoleLogger();
            Watcher watch = new Watcher(path, logger);
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
