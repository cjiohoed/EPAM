using System;
using System.Text;
using System.Diagnostics;
using Lib;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            General.Title("04.4");

            var str = new ConcAndBuildCompare(100000);
            Console.WriteLine($"Concatenation runtime: {str.ConcResult()}");
            Console.WriteLine($"StringBuilder runtime: {str.BuildResult()}");

            General.Goodbye();
        }
    }

    public class ConcAndBuildCompare
    {
        private int n;
        public ConcAndBuildCompare(int load)
        {
            n = load;
        }

        public string ConcResult()
        {
            var concTimer = new Stopwatch();
            concTimer.Start();
            ConcLoad(n);
            concTimer.Stop();
            TimeSpan concTS = concTimer.Elapsed;

            string elapsedTimeConc = String.Format($"{concTS.Hours:00}:{concTS.Minutes:00}:" +
                $"{concTS.Seconds:00}.{concTS.Milliseconds:000}");

            return elapsedTimeConc;
        }

        public string BuildResult()
        {
            var buildTimer = new Stopwatch();
            buildTimer.Start();
            BuildLoad(n);
            buildTimer.Stop();
            TimeSpan buildTS = buildTimer.Elapsed;

            string elapsedTimeBuild = String.Format($"{buildTS.Hours:00}:{buildTS.Minutes:00}:" +
                $"{buildTS.Seconds:00}.{buildTS.Milliseconds:000}");

            return elapsedTimeBuild;
        }

        private void ConcLoad(int n)
        {
            var str = string.Empty;
            for (int i = 0; i < n; i++)
            {
                str += "*";
            }
        }

        private void BuildLoad(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }

        }
    }
}
