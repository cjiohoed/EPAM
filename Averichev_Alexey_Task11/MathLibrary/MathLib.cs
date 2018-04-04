using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathLib
    {
        public static int Factorial(int value)
        {
            int result = 1;
            for (var i = 1; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }

        public static double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
