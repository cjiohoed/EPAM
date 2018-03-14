using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISeries aProgression = new ArithmeticalProgression(2, 2);
            //Console.WriteLine("Progression:");
            //PrintSeries(aProgression);

            //ISeries List = new List(new double[] { 5, 8, 6, 3, 1 });
            //Console.WriteLine("List:");
            //PrintSeries(List);

            ISeries gProgression = new GeometicalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(gProgression);

            ISeries[] newProgression = new GeometicalProgression[5];

            Console.ReadKey();
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        static void PrintNew(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}