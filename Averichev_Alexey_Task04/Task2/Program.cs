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
        public static string GetDuplicateMatching(string str1, string str2)
        {
            // Deleting duplicates
            str2 = new string(str2.Distinct().ToArray());

            var str3 = new StringBuilder();
            char[] chars1 = str1.ToCharArray();

            for (int chr1 = 0; chr1 < chars1.Length; chr1++)
            {
                str3.Append(chars1[chr1]);
                if (str2.Contains(chars1[chr1]))
                {
                    str3.Append(chars1[chr1]);
                }
            }

            return str3.ToString();
        }
    }

}
