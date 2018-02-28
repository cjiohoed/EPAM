using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void StarLine(int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void StarLines()
        {
            int value = Input();
            for (int i = 1; i <= value; i++)
            {
                StarLine(i);
            }
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static int Input()
        {
            int result;
            string s;
            do
            {
                Console.Write("Input value of rows: ");
                s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                {
                    Console.Write("Value is null or empty! ");
                }
                else if (!int.TryParse(s, out result))
                {
                    Console.Write("Incorrect parse! ");
                }
                else if (result <= 0)
                {
                    Console.Write("Value can't be null or negative! ");
                }
            }
            while (string.IsNullOrEmpty(s) | !int.TryParse(s, out result) || result <= 0);
            return result;
        }
        static void Main(string[] args)
        {
            StarLines();
        }
    }
}
