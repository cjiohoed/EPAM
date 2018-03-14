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
            var fig = CreateRandomFigures(20);
            ConsoleDraw(fig);

            Console.ReadKey();
        }

        public static Figure[] CreateRandomFigures(int value)
        {
            Figure[] array = new Figure[value];
            var rndType = new Random();
            var rndArgs = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                switch (rndType.Next(3))
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
                }
            }
            return array;
        }

        public static void ConsoleDraw(Figure[] fig)
        {

            for (int i = 0; i < fig.Length; i++)
            {
                var currentFig = fig[i];
                Console.WriteLine(
                    $"Type: {currentFig.Type}\t" +
                    $"Start point: ({currentFig.X},{currentFig.Y})\t" +
                    $"Area: {currentFig.Area(): .00}");
            }
        }
    }

}
