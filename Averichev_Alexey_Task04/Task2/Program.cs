using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            General.Title("04.2");

            // var str1 = General.Input("1st string");
            // var str2 = General.Input("2nd string");

            var str1 = "написать программу, которая";
            var str2 = "описание";
            var str3 = StrExt.GetDuplicateMatching(str1, str2);

            Console.WriteLine($"3rd string: {str3}");

            General.Goodbye();
        }
    }
}
