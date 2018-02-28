using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static bool Div(int n, int d)
        {
            if (d != 0 && (n % d) == 0)
            {
                return true;
            }
            return false;
        }
        static void Sum (int maxValue)
        {
            int sum = 0;
            for (int i = 1; i < maxValue; i++)
            {
                if (Div(i, 3) || Div(i, 5))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"Sum of numbers 1-{maxValue} dividing by 3 and 5: {sum}");
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Sum(1000);
            
        }
    }
}
