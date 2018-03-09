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

            var test1 = new ConcAndBuildCompare(4, "*");
            Console.WriteLine($"Concatenation runtime: {test1.ConcResult()}");
            Console.WriteLine($"StringBuilder runtime: {test1.BuildResult()}\n");

            //var test2 = new ConcAndBuildCompare(1000, "*=*");
            //Console.WriteLine($"Concatenation runtime: {test2.ConcResult()}");
            //Console.WriteLine($"StringBuilder runtime: {test2.BuildResult()}\n");

            var test3 = new ConcAndBuildCompare(5, "*-54bb7e=+");
            Console.WriteLine($"Concatenation runtime: {test3.ConcResult()}");
            Console.WriteLine($"StringBuilder runtime: {test3.BuildResult()}\n");

            var test4 = new ConcAndBuildCompare(5, "Concatenation must win!!! 76476746767647657673676767373");
            Console.WriteLine($"Concatenation runtime: {test4.ConcResult()}");
            Console.WriteLine($"StringBuilder runtime: {test4.BuildResult()}\n");

            General.Goodbye();
        }
    }

    public class ConcAndBuildCompare
    {
        private int n;
        private string str;

        public ConcAndBuildCompare(int load, string str)
        {
            n = load;
            this.str = str;
        }

        public string ConcResult()
        {
            var concTimer = new Stopwatch();
            concTimer.Start();
            ConcLoad();
            concTimer.Stop();
            TimeSpan concTS = concTimer.Elapsed;

            string elapsedTimeConc = String.Format($"{concTS.TotalMilliseconds:00000} - {concTS.Ticks:00000}");

            return elapsedTimeConc;
        }

        public string BuildResult()
        {
            var buildTimer = new Stopwatch();
            buildTimer.Start();
            BuildLoad();
            buildTimer.Stop();
            TimeSpan buildTS = buildTimer.Elapsed;

            string elapsedTimeBuild = String.Format($"{buildTS.TotalMilliseconds:00000} - {buildTS.Ticks:00000}");

            return elapsedTimeBuild;
        }

        private void ConcLoad()
        {
            var s = string.Empty;
            for (int i = 0; i < n; i++)
            {
                s += str;
            }
        }

        private void BuildLoad()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }

        }
    }
}
