﻿using System;
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
                PrintMeth(spaces, " ");
                PrintMeth(stars, "*");
                PrintMeth(spaces, " ");
                Console.WriteLine();
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
                do
                {
                    Console.Write("Input height of the pyramid in rows: ");
                    s = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(s));
                result = int.Parse(s);
            }
            while (result <= 0);
            return result;
        }

        static void Main(string[] args)
        {
            PrintTrigon(Input());
        }
    }
}
