using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            General.Title("04.6");

            //var str = Console.ReadLine();

            Console.WriteLine(IsNormalNum("6g348"));

            General.Goodbye();
        }

        static string IsNormalNum(string str)
        {
            //var pattern = @"[-]*\d+";
            //var pattern = @"\d{1,}\.?\d{1,}";
            var pattern = @"[-]*\d{1,}\.?\d{1,}";
            var rgx = new Regex(pattern);

            if (rgx.IsMatch(str))
            {
                return "true";
            }
            return "false";
        }

        static bool IsSciNum(string str)
        {
            var pattern = @"\d{1,}\.?\d{1,}";
            //var rgx = new Regex(pattern);

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
