using System;

namespace Task1
{
    public class Round : Figure
    {
        public override Figures Type
        {
            get
            {
                return Figures.Round;
            }
        }

        protected double _x;
        protected double _y;
        protected double _radius;

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;

        }

        public override double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public override double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            protected set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new Exception("Incorrect radius");
                }
            }
        }

        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
