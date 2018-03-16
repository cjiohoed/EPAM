using System;

namespace Task1
{
    class Ring : Round
    {

        private double _innerRadius;

        public Ring(double x, double y, double innerRadius, double outerRadius) : base(x, y, outerRadius)
        {
            InnerRadius = innerRadius;
        }

        public string Name => "Ring";

        public double X
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

        public double Y
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

        public double Area()
        {
            return base.Area() - Math.PI * _innerRadius * _innerRadius;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawRound(X, Y, InnerRadius);
            canvas.DrawRound(X, Y, Radius);
        }
    }
}
