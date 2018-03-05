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
            var words = StrExt.GetArrayOfWords(str);
            Console.WriteLine($"Average num of chars :{StrExt.GetAverageChars(words)}");

            General.Goodbye();
        }
    }
}
