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

            var str1 = "написать программу, которая";
            var str2 = "описание";
            var str3 = StrExt.GetDuplicateMatching(str1, str2);

            Console.WriteLine($"3rd string: {str3}");

            General.Goodbye();
        }
    }

    public class StrExt
    {
        public static string GetDuplicateMatching(string source, string pattern)
        {
            // Deleting duplicates
            pattern = new string(pattern.Distinct().ToArray());

            var result = new StringBuilder();
            char[] sourceChars = source.ToCharArray();

            for (int i = 0; i < sourceChars.Length; i++)
            {
                result.Append(sourceChars[i]);
                if (pattern.Contains(sourceChars[i]))
                {
                    result.Append(sourceChars[i]);
                }
            }
            for(var i = 0; i < pattern.Length; i++)
            {
                string c = pattern[i].ToString();
                source = source.Replace(c, new string(pattern[i], 2));
            }

            return result.ToString();
        }
    }

}
