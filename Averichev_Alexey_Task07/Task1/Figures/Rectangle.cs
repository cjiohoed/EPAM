using System;

namespace Task1
{
    public class Rectangle : IFigure
    {

        protected double _x;
        protected double _y;
        protected double _width = 0;
        protected double _height = 0;
        public string Name => "Rectangle";

        //public string Name
        //{
        //	get
        //	{
        //		return "Rectangle";
        //	}
        //}

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

        public double Width
        {
            get
            {
                return _width;
            }

            protected set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Incorrect Width");
                }
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
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new Exception("Incorrect Height");
                }
            }
        }

        public Rectangle(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return _width * _height;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawLine(X, Y, X + Width, Y);
            canvas.DrawLine(X + Width, Y, X + Width, Y + Height);
            canvas.DrawLine(X + Width, Y + Height, X, Y + Height);
            canvas.DrawLine(X, Y + Height, X, Y);
        }
    }
}
