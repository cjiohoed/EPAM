using System;

namespace Task1
{
    public class Ring : Round
    {
        public override Figures Type
        {
            get
            {
                return Figures.Ring;
            }
        }

        private double _innerRadius;

        public Ring(double x, double y, double innerRadius, double outerRadius) : base(x, y, outerRadius)
        {
            InnerRadius = innerRadius;
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

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if (value > 0 && value < Radius)
                {
                    _innerRadius = value;
                }
                else
                {
                    throw new Exception("Incorrect radius");
                }
            }
        }

        public override double Area()
        {
            return base.Area() - Math.PI * _innerRadius * _innerRadius;
        }
    }
}
