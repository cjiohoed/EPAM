using Lib;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            General.Title("03.3");

            var arrOfNum = new Arr(General.InputArg("elements of array"), General.InputArgSimple("min element"), General.InputArgSimple("max element"));
            Console.WriteLine($"Summ of positive elements: {arrOfNum.GetPositiveSum()}");

            General.Goodbye();
        }
    }
}
