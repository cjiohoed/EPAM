using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lib
{
    public class StrExt
    {
        public static string[] GetArrayOfWords(string str)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "(", ")", "{", "}", "\'", "\"", "<", ">", "\\", "[", "]", "=", "/", "*", "@" };
            string[] arrOfWords = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return arrOfWords;
        }

        public static int GetAverageChars(string[] words)
        {
            int wordsNum = 0;
            int sumChars = 0;

            foreach (var word in words)
            {
                wordsNum++;
                sumChars += word.Length;
            }
            return (int)(sumChars / wordsNum);
        }

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
