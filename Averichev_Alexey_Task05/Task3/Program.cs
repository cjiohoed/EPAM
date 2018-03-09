using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            var trigon = new Triangle(10, 10, 10);

            Console.WriteLine($"Perimeter: {trigon.Perimeter}\nArea: {trigon.Area}");
            Console.ReadKey();
        }

        public class Triangle
        {
            private double a;
            private double b;
            private double c;

            private double perimeter;
            private double area;

            public Triangle(double a, double b, double c)
            {
                if (a > b + c && b > a + c && c > a + b)
                {
                    throw new Exception("Incorrect arguments!");
                }

                this.a = a;
                this.b = b;
                this.c = c;

            }

            /*
            public Triangle()
            {

            }
            */

            /*
            public double A
            {
                get
                {
                    return a;
                }

                set
                {
                    if(A < B + C)
                    {
                        a = value;
                    }
                    else
                    {
                        throw new Exception("A must be less than the sum of B and C");
                    }
                }
            }
            */

            /*
            public double B
            {
                get
                {
                    return b;
                }

                set
                {
                    if (B < A + C)
                    {
                        b = value;
                    }
                    else
                    {
                        throw new Exception("B must be less than the sum of A and C");
                    }
                }
            }
            */

            /*
            public double C
            {
                get
                {
                    return c;
                }

                set
                {
                    if (C < A + B)
                    {
                        c = value;
                    }
                    else
                    {
                        throw new Exception("B must be less than the sum of A and C");
                    }
                }
            }
            */

            public double Perimeter
            {
                get
                {
                    perimeter = a + b + c;
                    return perimeter;
                }
            }

            public double Area
            {
                get
                {
                    area = Heron();
                    return area;
                }
            }

            private double Heron()
            {
                return Math.Sqrt((a + b - c) * (a - b + c) * (-a + b + c) * (a + b + c)) / 4;
            }
        }
    }
}
