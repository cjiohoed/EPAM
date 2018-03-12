using System;

namespace Task2
{
    public class Ring : Round
    {
        private double innerRadius = 0;
        private double ringArea = 0;
        private double innerLenght = 0;
        private double sumLenghts = 0;

        public Ring(double x, double y, double innerRadius, double outerRadius)
        {
            X = x;
            Y = y;
            Radius = outerRadius;
            InnerRadius = innerRadius;
        }

        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }
            set
            {
                if(value > 0 & value < Radius)
                {
                    innerRadius = value;
                }
                else
                {
                    throw new Exception("Incorrect inner radius");
                }
            }
        }

        public double Area
        {
            get
            {
                return pi * (radius * radius - innerRadius * innerRadius);
            }
        }

        public double SumLenghts
        {
            get
            {
                return CircleLenght + 2 * pi * innerRadius;
            }
        }
    }
}
