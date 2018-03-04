using Lib;
using System;

namespace Task1
{

    class Program
    {
        static void Main()
        {
            var str = General.Input("string");
            var words = General.GetArrayOfWords(str);
            Console.WriteLine($"Average num of chars :{General.GetAverageChars(words)}");
            Console.ReadKey();

        }
    }
}
