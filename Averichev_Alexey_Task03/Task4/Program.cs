using Lib;
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            General.Title("03.4");

            var arrOfNum = new Arr2D(General.InputArg("elements along the X axis"), General.InputArg("elements along the Y axis"), General.InputArgSimple("min element"), General.InputArgSimple("max element"));
            Console.WriteLine($"Summ of even positions: {arrOfNum.GetSumOfEvenPositions()}");

            General.Goodbye();
        }
    }
}
