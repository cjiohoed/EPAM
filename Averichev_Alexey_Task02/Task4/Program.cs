using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static string ConstructSubLine(char symb, int value)
        {
            string s = new String(symb, value);
            return s;
        }
        static string PrintTrigon(int value)
        {
            string str = String.Empty;
            for (int s = 1; s <= value; s++)
            {
                int stars = 2 * s - 1;
                int spaces = value - s;
                str += ConstructSubLine(' ', spaces);
                str += ConstructSubLine('*', stars) + "\n";
            }
            return str;
        }
        static int InputArg(string arg)
        {
            int result;
            string s;
            do
            {
                Console.Write($"Input {arg}: ");
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
            while (string.IsNullOrEmpty(s) || !int.TryParse(s, out result) || result <= 0);
            return result;
        }

        static void Goodbye()
        {
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int value = InputArg("rows value of the trigon");
            string trigon = PrintTrigon(value);
            Console.WriteLine(trigon);
            Goodbye();
        }
    }
}
