using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var result = MathLib.Factorial(5);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
