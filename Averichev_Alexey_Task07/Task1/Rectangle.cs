using System;

namespace Task1
{
    public class Rectangle : Figure
    {
        public override Figures Type
        {
            get
            {
                return Figures.Rectangle;
            }
        }

        protected double _x;
        protected double _y;
        protected double _width = 0;
        protected double _height = 0;

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

        public double Width
        {
            get
            {
                return _width;
            }

            set
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

            set
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

        public override double Area()
        {
            return _width * _height;
        }

    }
}
