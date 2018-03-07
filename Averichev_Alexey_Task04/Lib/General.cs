using System;

namespace Lib
{
    public class General
    {
        public static string Input(string arg)
        {
            string str;
            do
            {
                Console.Write($"Input {arg}: ");
                str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    Console.Write("ERROR! Empty string! ");
                }
            }
            while (string.IsNullOrEmpty(str));
            return str;
        }

        public static void Title(string task)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($" ╔═══════════════════════════════╗");
            Console.WriteLine($" ║        [.NET 2018-1]          ║");
            Console.WriteLine($" ║   Averichev_Alexey_Task{task}   ║");
            Console.WriteLine($" ║     a.averichev@gmail.com     ║");
            Console.WriteLine($" ╚═══════════════════════════════╝\n");
            Console.ResetColor();
        }

        public static void Goodbye()
        {
            Console.Write("\nDone! Press any key...");
            Console.ReadKey();
        }

    }
}
