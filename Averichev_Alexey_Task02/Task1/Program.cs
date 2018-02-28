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
            Console.Write($"Input {arg} value: ");
            return int.Parse(Console.ReadLine());
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
