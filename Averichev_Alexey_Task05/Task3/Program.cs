﻿using System;
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
            //trigon.A = 10;
            //trigon.B = 10;
            //trigon.C = 10;

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
                A = a;
                B = b;
                C = c;
            }

            public Triangle()
            {

            }

            public double A
            {
                get
                {
                    return a;
                }

                set
                {
                    if(a < b + c)
                    {
                        a = value;
                    }
                    else
                    {
                        throw new Exception("A must be less than the sum of B and C");
                    }
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
                    if (b < a + c)
                    {
                        b = value;
                    }
                    else
                    {
                        throw new Exception("B must be less than the sum of A and C");
                    }
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
                    if (c < a + b)
                    {
                        c = value;
                    }
                    else
                    {
                        throw new Exception("B must be less than the sum of A and C");
                    }
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
