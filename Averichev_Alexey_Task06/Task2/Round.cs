using System;

namespace Task2
{
    public class Round
    {
        protected double pi = 3.14;
        protected double x = 0;
        protected double y = 0;
        protected double radius;
        protected double circleLenght;
        protected double circleArea;

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Round()
        {

        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if(value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Incorrect radius");
                }
            }
        }

        public double CircleLenght
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
