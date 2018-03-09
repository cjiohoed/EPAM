using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            var t = new Triangle(10, 10, 10);

            Console.WriteLine($"Perimeter: {t.Perimeter}\nArea: {t.Area: .00}");

            t.A = 50;
            t.B = 45;
            t.C = 40;

            Console.WriteLine($"Perimeter: {t.Perimeter}\nArea: {t.Area : .00}");
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

            public double A
            {
                get
                {
                    return a;
                }

                set
                {
                    if(A > b + c)
                    {
                        throw new Exception("A must be less than the sum of B and C");
                    }
                    a = value;
                }
            }

            public double B
            {
                get
                {
                    return b;
                }

                set
                {
                    if (B > a + c)
                    {
                        throw new Exception("B must be less than the sum of A and C");
                    }
                    b = value;
                }
            }

            public double C
            {
                get
                {
                    return c;
                }

                set
                {
                    if (C > a + b)
                    {
                        throw new Exception("B must be less than the sum of A and C");
                    }
                    c = value;
                }
            }

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
