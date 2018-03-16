using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 10;
            var figures = GetFigures(count);
            ICanvas canvas = new ConsoleCanvas();
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Name);
                figure.Draw(canvas);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static List<IFigure> GetFigures(int cound)
        {
            var figures = new List<IFigure>();
            var rnd = new Random();
            for (int i = 0; i < cound; i++)
            {
                switch (rnd.Next(4))
                {
                    case 0:
                        figures.Add(new Rectangle(
                            rnd.Next(1, 10),
                            rnd.Next(1, 10),
                            rnd.Next(1, 10),
                            rnd.Next(1, 10)));
                        break;
                    case 1:
                        figures.Add(new Round(
                            rnd.Next(1, 10),
                            rnd.Next(1, 10),
                            rnd.Next(1, 10)));
                        break;
                    case 2:
                        figures.Add(new Ring(
                            rnd.Next(1, 10),
                            rnd.Next(1, 10),
                            rnd.Next(1, 5),
                            rnd.Next(6, 10)));
                        break;
                    case 3:
                        figures.Add(new Line(
                            rnd.Next(1, 10),
                            rnd.Next(1, 10),
                            rnd.Next(1, 10),
                            rnd.Next(6, 10)));
                        break;
                }
            }

            return figures;
        }
    }
}
