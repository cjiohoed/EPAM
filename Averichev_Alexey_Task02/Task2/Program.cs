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
        static void StarLines(int value)
        {
            for (int i = 1; i <= value; i++)
            {
                StarLine(i);
            }
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static int Input()
        {
            Console.Write("Input value of strings: ");
            int s = int.Parse(Console.ReadLine());
            return s;
        }
        static void Main(string[] args)
        {
            StarLines(Input());
        }
    }
}
