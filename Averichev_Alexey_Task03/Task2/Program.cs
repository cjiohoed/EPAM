using Lib;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            My.Title("03.2");

            var arrayOfNumbers = new int[My.InputArg("elements along the X axis"), My.InputArg("elements along the Y axis"), My.InputArg("elements along the Z axis")];
            Arr.CreateRandom(arrayOfNumbers, My.InputArgSimple("min element"), My.InputArgSimple("max element"));
            Arr.PositiveToZero(arrayOfNumbers);

            My.Goodbye();
        }
    }
}
