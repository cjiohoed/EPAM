using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main()
        {
            var str = "В 7:55 я встал, позавтракал и к 10:77 пошел на работу.";
        }

        static bool IsTimeInText(string str)
        {
            var pattern = @"(0[0-9]|1[0-9]|2[0-3])[:.]([0-5][0-9])";

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
