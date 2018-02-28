using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int InputArg(string arg)
        {
            int result;
            string s;
            do
            {
                Console.Write($"Input {arg} value: ");
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
        static void Sqr()
        {
            int sqr = InputArg("A") * InputArg("B");
            Console.WriteLine($"Square = {sqr}");
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Sqr();
        }
    }
}
