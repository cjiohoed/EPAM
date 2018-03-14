using System;

namespace Task1
{
    public class Rectangle : Figure
    {
        protected double _x;
        protected double _y;
        protected double _width = 0;
        protected double _height = 0;

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

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Это прямоугольник со сторонами {_width} x {_height} и площадью {Area()}");
        }

    }
}
