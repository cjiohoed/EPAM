using System;

namespace Task1
{
    public class Line : Figure, ICanvas
    {
        public override Types Type
        {
            get
            {
                return Types.Line;
            }
        }

        double _x1;
        double _y1;
        double _x2;
        double _y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public double X1
        {
            get
            {
                return _x1;
            }
            protected set
            {
                _x1 = value;
            }
        }

        public double Y1
        {
            get
            {
                return _y1;
            }
            protected set
            {
                _y1 = value;
            }
        }

        public double X2
        {
            get
            {
                return _x2;
            }
            protected set
            {
                _x2 = value;
            }
        }

        public double Y2
        {
            get
            {
                return _y2;
            }
            protected set
            {
                _y2 = value;
            }
        }

        public double Length
        {
            get
            {
                double dX = X2 - X1;
                double dY = Y2 - Y1;
                return Math.Sqrt(dX * dX + dY * dY);
            }
        }

        public override void Draw()
        {
            ConsoleApp.DrawLine(X1, Y1, X2, Y2);
        }

    }
}
