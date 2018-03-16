using System;

namespace Task1
{
    class Round : IFigure
    {

        protected double _x;
        protected double _y;
        protected double _radius;
        public string Name => "Round";

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;

        }

        public double X
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

        public double Y
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

        public double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawRound(X, Y, Radius);
        }
    }
}
