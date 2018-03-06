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
        static void Main()
        {
            General.Title("04.6");

            Console.Write("Input number: ");
            var str = Console.ReadLine();
            Console.WriteLine(WhatIsNumber(str));

            General.Goodbye();
        }

        static string WhatIsNumber(string str)
        {
            if(IsNormalNum(str))
            {
                return "This number is in the usual notation";
            }
            else if (IsSciNum(str))
            {
                return "This number is in scientific notation";
            }
            else
            {
                return "This is not a number";
            }
        }

        static bool IsNormalNum(string str)
        {
            var pattern = @"^-?\d+(\.\d+)?$";

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }

        static bool IsSciNum(string str)
        {
            var pattern = @"^-?\d+(\.\d+)?[eE][+-]\d+$";

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
