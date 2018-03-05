using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Lib;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            General.Title("04.4");

            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100000;

            var concTimer = new Stopwatch();
            var buildTimer = new Stopwatch();

            concTimer.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            concTimer.Stop();
            TimeSpan concTS = concTimer.Elapsed;

            buildTimer.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            buildTimer.Stop();
            TimeSpan buildTS = buildTimer.Elapsed;

            string elapsedTimeConc = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            concTS.Hours, concTS.Minutes, concTS.Seconds,
            concTS.Milliseconds / 10);

            string elapsedTimeBuild = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            buildTS.Hours, buildTS.Minutes, buildTS.Seconds,
            buildTS.Milliseconds / 10);

            Console.WriteLine($"Concatenation runtime: {elapsedTimeConc}");
            Console.WriteLine($"StringBuilder runtime: {elapsedTimeBuild}");

            General.Goodbye();
        }
    }
}
