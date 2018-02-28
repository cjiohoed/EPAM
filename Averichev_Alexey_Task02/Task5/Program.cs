using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
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
        static void PrintTrigon(int value, int levels)
        {
            for (int s = 1; s <= value; s++)
            {
                int stars = 2 * s - 1;
                int spaces = levels - s;
                PrintMeth(spaces, " ");
                PrintMeth(stars, "*");
                PrintMeth(spaces, " ");
                Console.WriteLine();
            }
        }
        static int Input()
        {
            int result;
            string s;

            do
            {
                do
                {
                    Console.Write("Enter the number of levels: ");
                    s = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(s));
                result = int.Parse(s);
            }
            while (result <= 0);
            return result;
        }
        static void FirTree(int levels)
        {
            for (int i = 1; i <= levels; i++)
            {
                PrintTrigon(i, levels);
            }
        }
        static void Main(string[] args)
        {

            FirTree(Input());

            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
