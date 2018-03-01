using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static bool Divider(int n, int d)
        {
            if (d != 0 && (n % d) == 0)
            {
                return true;
            }
            return false;
        }
        static int Sum (int maxValue)
        {
            int sum = 0;
            for (int i = 1; i < maxValue; i++)
            {
                if (Divider(i, 3) || Divider(i, 5))
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static void Goodbye()
        {
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int maxValue = 1000;
            int sum = Sum(maxValue);
            Console.WriteLine($"Sum of numbers 1-{maxValue} dividing by 3 and 5: {sum}");
            Goodbye();
        }
    }
}
