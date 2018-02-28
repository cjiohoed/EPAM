using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void PrintMeth(int value, string symb)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write(symb);
            }
        }
        static void PrintTrigon(int value)
        {
            for (int s = 1; s <= value; s++)
            {
                int stars = 2 * s - 1;
                int spaces = value - s;
                PrintMeth(spaces, "+");
                PrintMeth(stars, "*");
                PrintMeth(spaces, "+");
                Console.WriteLine();
            }
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int str = 20;
            PrintTrigon(str);
        }
    }
}
