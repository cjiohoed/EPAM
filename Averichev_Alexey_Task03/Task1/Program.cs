using Lib;
using System;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            General.Title("03.1");

            var arrOfNum = new Arr(General.InputArg("elements of array"), General.InputArgSimple("min element"), General.InputArgSimple("max element"));
            arrOfNum.BubbleSort();
            arrOfNum.Display();
            Console.WriteLine($"Min value of array: {arrOfNum.GetMinValue()}");
            Console.WriteLine($"Max value of array: {arrOfNum.GetMaxValue()}");

            General.Goodbye();
        }
    }
}
