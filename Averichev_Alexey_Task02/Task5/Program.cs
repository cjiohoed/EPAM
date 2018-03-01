using Methods;
using System;

namespace Task5
{
    class Program
    {
        static string ConstructSubLine(char symb, int value)
        {
            string s = new String(symb, value);
            return s;
        }
        static string ConstructSubLine(int value, char symb)
        {
            return new String(symb, value);
        }

        static string PrintTrigon(int value, int levels)
        {
            string str = String.Empty;
            for (int s = 1; s <= value; s++)
            {
                int stars = 2 * s - 1;
                int spaces = levels - s;
                str += ConstructSubLine(spaces, ' ');
                str += ConstructSubLine(stars, '*') + "\n";
            }
            return str;
        }
        static string ChristmasTree(int levels)
        {
            string str = String.Empty;
            for (int i = 1; i <= levels; i++)
            {
                str += PrintTrigon(i, levels);
            }
            return str;
        }
        static void Goodbye()
        {
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            // Эксперимент с библиотекой
            int levels = MyMethods.InputArg("levels of Christmas Tree");
            string str = ChristmasTree(levels);
            Console.WriteLine(str);
            Goodbye();
        }
    }
}
