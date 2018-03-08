using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Round();
            obj1.X = 15;
            obj1.Y = 22;
            obj1.Radius = 13;

            var obj2 = new Round(15, 22, 13);

            Console.WriteLine($"Circle Lenght: {obj1.Lenght}\nCircle Area: {obj1.Area}");
            Console.WriteLine($"\nCircle Lenght: {obj2.Lenght}\nCircle Area: {obj2.Area}");

            Console.ReadKey();
        }
    }

    public class Round
    {
        private double pi = 3.14;
        private double x = 0;
        private double y = 0;
        private double radius;
        private double circleLenght;
        private double circleArea;

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Round()
        {

        }

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public double Lenght
        {
            get
            {
                return 2 * pi * radius;
            }
        }

        public double Area
        {
            get
            {
                return pi * radius * radius;
            }
        }
    }
}
