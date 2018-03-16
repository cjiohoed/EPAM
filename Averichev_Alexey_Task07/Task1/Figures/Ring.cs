using System;

namespace Task1
{
    public class Ring : Round, ICanvas
    {
        public override Types Type
        {
            get
            {
                return Types.Ring;
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
            protected set
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
            protected set
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

        public override void Draw()
        {
            ConsoleApp.DrawRing(X, Y, InnerRadius, Radius);
        }

    }
}
