using System;

namespace Lib
{
    public class General
    {
        public static string Input(string arg)
        {
            string str;
            do
            {
                Console.Write($"Input {arg}: ");
                str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    Console.Write("ERROR! Empty string!");
                }
            }
            while (string.IsNullOrEmpty(str));
            return str;
        }

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
    }
}
