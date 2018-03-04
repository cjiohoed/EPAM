using Lib;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            General.Title("03.2");

            var arrOfNum = new Arr3D(General.InputArg("elements along the X axis"), General.InputArg("elements along the Y axis"), General.InputArg("elements along the Z axis"), General.InputArgSimple("min element"), General.InputArgSimple("max element"));
            arrOfNum.PositiveToZero();

            General.Goodbye();
        }
    }
}
