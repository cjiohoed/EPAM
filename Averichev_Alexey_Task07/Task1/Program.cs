using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Figure[] figures = ConsoleApp.CreateRandomCollection(20);
            
            

            Console.ReadKey();
        }
    }

    public class Canvas : ICanvas
    {
        public void Draw(Figure[] col)
        {
            for (int i = 0; i < col.Length; i++)
            {
                if (col[i] is Line)
                {
                    DrawLine((Line)col[i]);
                }
                else if (col[i] is Rectangle)
                {
                    DrawRectangle((Rectangle)col[i]);
                }
                else if (col[i] is Round)
                {
                    DrawRound((Round)col[i]);
                }
                else if (col[i] is Ring)
                {
                    DrawRing((Ring)col[i]);
                }
            }
        }

        public void DrawLine(Line obj)
        {
            Console.WriteLine($"Line\t\t({obj.X1},{obj.Y1}) - ({obj.X2},{obj.Y2})");
        }

        public void DrawRectangle(Rectangle obj)
        {
            Console.WriteLine($"Rectangle\t({obj.X},{obj.Y})\t{obj.Width}x{obj.Height}");
        }

        public void DrawRound(Round obj)
        {
            Console.WriteLine($"Round\t\t({obj.X},{obj.Y})\t{obj.Radius}");
        }

        public void DrawRing(Ring obj)
        {
            Console.WriteLine($"Ring\t\t({obj.X},{obj.Y})\t{obj.InnerRadius}/{obj.Radius}");
        }
    }
}

