using System;

namespace Task1
{
    class ConsoleApp
    {
        public static ICanvas[] GetRandomCollection(int value)
        {
            Figure[] array = new Figure[value];
            var rndType = new Random();
            var rndArgs = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                switch (rndType.Next(4))
                {
                    case 0:
                        array[i] = new Rectangle(
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10));
                        break;
                    case 1:
                        array[i] = new Round(
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10));
                        break;
                    case 2:
                        array[i] = new Ring(
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 5),
                            rndArgs.Next(6, 10));
                        break;
                    case 3:
                        array[i] = new Line(
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10),
                            rndArgs.Next(1, 10),
                            rndArgs.Next(6, 10));
                        break;
                }
            }
            return array;
        }

        public static void Draw(ICanvas[] canvas)
        {
            for (int i = 0; i < canvas.Length; i++)
            {
                canvas[i].Draw();
            }
        }

        public static void DrawLine(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine($"Line\t\t({x1},{y1}) - ({x2},{y2})");
        }

        public static void DrawRectangle(double x, double y, double width, double height)
        {
            Console.WriteLine($"Rectangle\t({x},{y})\t{width}x{height}");
        }

        public static void DrawRound(double x, double y, double radius)
        {
            Console.WriteLine($"Round\t\t({x},{y})\t{radius}");
        }

        public static void DrawRing(double x, double y, double innerRadius, double outerRadius)
        {
            Console.WriteLine($"Ring\t\t({x},{y})\t{innerRadius}/{outerRadius}");
        }
    }

}
