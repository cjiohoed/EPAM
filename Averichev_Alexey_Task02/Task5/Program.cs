﻿using System;
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
                Console.Write("Enter the number of levels: ");
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
        static void ChristmasTree()
        {
            int levels = Input();
            for (int i = 1; i <= levels; i++)
            {
                PrintTrigon(i, levels);
            }
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            ChristmasTree();
        }
    }
}
