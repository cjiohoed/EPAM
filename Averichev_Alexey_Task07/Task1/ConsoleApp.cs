using System;

namespace Task1
{
    class ConsoleApp
    {
        public static ICanvas[] CreateRandomCollection(int value)
        {
            ICanvas[] array = new ICanvas[value];
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

        public static void DrawCollection(ICanvas[] pack)
        {
            for (int i = 0; i < pack.Length; i++)
            {
                pack[i].Draw();
            }
        }

        public static void DrawRectangle(double x, double y, double w, double h)
        {
            Console.WriteLine($"Rectangle\t({x},{y})\t{w}x{h}");
        }

        public static void DrawRound(double x, double y, double r)
        {
            Console.WriteLine($"Round\t\t({x},{y})\t{r}");
        }

        public static void DrawRing(double x, double y, double ri, double ro)
        {
            Console.WriteLine($"Ring\t\t({x},{y})\t{ri}/{ro}");
        }

        public static void DrawLine(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine($"Line\t\t({x1},{y1}) - ({x2},{y2})");
        }
    }

}
