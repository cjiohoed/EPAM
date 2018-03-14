using System;

namespace Task1
{
    public class Ring : Round
    {
        private double _innerRadius;

        public Ring(double x, double y, double innerRadius, double outerRadius) : base (x, y, outerRadius)
        {
            InnerRadius = innerRadius;
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if(value > 0 && value < Radius)
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
