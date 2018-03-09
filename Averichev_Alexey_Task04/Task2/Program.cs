using Lib;
using System;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            General.Title("04.2");

            var source = "написать программу, которая";
            var pattern = "описание";
            var result = StringDouble.GetDuplicateMatching(source, pattern);

            Console.WriteLine($"3rd string: {result}");

            General.Goodbye();
        }
    }

    public class StringDouble
    {
        public static string GetDuplicateMatching(string source, string pattern)
        {
            // Deleting duplicates
            pattern = new string(pattern.Distinct().ToArray());

            var result = new StringBuilder();
            char[] sourceChars = source.ToCharArray();

            for(var i = 0; i < pattern.Length; i++)
            {
                string c = pattern[i].ToString();
                source = source.Replace(c, new string(pattern[i], 2));
            }

            return result.ToString();
        }
    }

}
