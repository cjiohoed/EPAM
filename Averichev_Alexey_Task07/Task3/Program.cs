using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISeries progression = new ArithmeticalProgression(2, 2);
            //Console.WriteLine("Progression:");
            //PrintSeries(progression);

            //ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            //Console.WriteLine("List:");
            //PrintSeries(list);

            IIndexable progr = new ArithmeticalProgression(2, 2);
            Console.WriteLine(progr[2]);

            IIndexable list = new List(new double[] { 3, 7, 12, 6, 2, 104, 72, 1 });
            Console.WriteLine(list[5]);

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
    }
}
