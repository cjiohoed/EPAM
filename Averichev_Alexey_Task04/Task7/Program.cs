using System;
using System.Text.RegularExpressions;
using Lib;

namespace Task7
{
    class Program
    {
        static void Main()
        {
            General.Title("04.7");

            var str = "В 7:55 я встал, позавтракал в 08:30 и к 10:77 пошел на работу. В 77:15 я был уже пьян.";
            var rgx = new TimeRegEx(str);
            Console.WriteLine($"Time records in text: {rgx.GetTimeNum()}");

            General.Goodbye();
        }

    }

    public class TimeRegEx
    {
        public string str;
        
        // private string pattern = @"( [0-9]|[0-1][0-9]|[2][0-3])[:.-]([0-5][0-9])";
        // private string pattern = @"\b([0-1][0-9]|[2][0-3]|\d)[:.-][0-5]\d";

        // private string pattern = @"(?<= )([0-1][0-9]|[2][0-3]|\d)[:.-][0-5]\d(?= )";

        private string pattern = @"(?<=\D)([0-1][0-9]|[2][0-3]|\d)[:.-][0-5]\d(?=\D)";

        public TimeRegEx(string str)
        {
            this.str = str;
        }

        private bool IsTimeInText(string str)
        {

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }

        public int GetTimeNum()
        {
            if (IsTimeInText(str))
            {
                var matches = Regex.Matches(str, pattern);
                return matches.Count;
            }
            return -1;
        }
    }
}
