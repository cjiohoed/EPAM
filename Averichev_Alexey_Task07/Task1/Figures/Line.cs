using System;

namespace Task1
{
    public class Line : IFigure
    {

        double _x1;
        double _y1;
        double _width;
        double _height;
        public string Name => "Line";

        public Line(double x1, double y1, double x2, double y2)
        {
            _x1 = x1;
            _y1 = y1;
            _width = x2;
            _height = y2;
        }

        public double X
        {
            get
            {
                return _x1;
            }
            set
            {
                _x1 = value;
            }
        }

        public double Y
        {
            get
            {
                return _y1;
            }
            set
            {
                _y1 = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            protected set
            {
                _width = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            protected set
            {
                _height = value;
            }
        }

        public double Length
        {
            get
            {
                double dX = Width - X;
                double dY = Height - Y;
                return Math.Sqrt(dX * dX + dY * dY);
            }
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawLine(X, Y, X + Width, Y + Height);
        }
    }
}
