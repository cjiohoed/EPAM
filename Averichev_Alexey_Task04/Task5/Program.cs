using System;
using System.Text.RegularExpressions;
using Lib;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            General.Title("04.5");

            var str = @"<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font>";
            var target = "_";
            var result = GetWithoutTags(str, target);
            Console.WriteLine($"Result: {result}");

            General.Goodbye();
        }

        static string GetWithoutTags(string str, string target = "")
        {
            var pattern = @"<[^>]*>";
            var rgx = new Regex(pattern);
            var result = rgx.Replace(str, target);
            return result;
        }
    }
}
