using Lib;
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = new int[My.InputArg("elements along the X axis"), My.InputArg("elements along the Y axis")];
            Arr.CreateRandomTwoD(arrayOfNumbers, My.InputArgSimple("min element"), My.InputArgSimple("max element"));
            Console.WriteLine($"Summ of even positions: {Arr.GetSumOfEvenPositions(arrayOfNumbers)}");
            My.Goodbye();
        }
    }
}
