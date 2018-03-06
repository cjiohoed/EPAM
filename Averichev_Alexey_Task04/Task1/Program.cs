using Lib;
using System;

namespace Task1
{

    class Program
    {
        static void Main()
        {
            General.Title("04.1");

            //var str = General.Input("string");
            var str = "Клара у Карла украла кораллы. Карл у Клары украл кларнет.";
            var words = new StrExt(str);
            Console.WriteLine($"Average num of chars :{words.GetAverageChars()}");

            General.Goodbye();
        }
    }
    public class StrExt
    {
        string str;
        string[] words;

        public StrExt(string str)
        {
            this.str = str;
        }

        private string[] GetArrayOfWords()
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "(", ")", "{", "}", "\'", "\"", "<", ">", "\\", "[", "]", "=", "/", "*", "@" };
            string[] arrOfWords = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return arrOfWords;
        }

        public int GetAverageChars()
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
