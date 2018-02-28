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
                do
                {
                    Console.Write($"Input {arg} value: ");
                    s = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(s));
                result = int.Parse(s);
            }
            while (result <= 0);
            return result;
        }
        static void Sqr()
        {

            int argA = InputArg("A");
            int argB = InputArg("B");
            int sqr = argA * argB;
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
