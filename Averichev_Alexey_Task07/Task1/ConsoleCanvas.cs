using System;

namespace Task1
{
    public class ConsoleCanvas : ICanvas
    {
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine($"Line drawn x1: {x1} y1: {y1}, x2: {x2}, y2: {y2}");
        }

        public void DrawRound(double x, double y, double r)
        {
            Console.WriteLine($"Round drawn center.x = {x}, center.y = {y}, r = {r}");
        }
    }
}
