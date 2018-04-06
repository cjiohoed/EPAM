using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hashCode UNiqueness Test\n");

            var test = new HashTest(300);
            Console.WriteLine($"Uniqueness:\t{test.Uniqueness :.#}%");
            Console.WriteLine($"Objects:\t{test.NumberOfObjects}");
            Console.WriteLine($"Timer:\t\t{test.ElapsedTime}");

            Console.Write("\nPress any key...");
            Console.ReadKey();
        }

    }
}
