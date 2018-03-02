using Lib;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = new int[My.InputArg("elements of array")];
            Arr.CreateRandom(arrayOfNumbers, My.InputArgSimple("min element"), My.InputArgSimple("max element"));
            Console.WriteLine($"Summ of positive elements: {Arr.GetPositiveSum(arrayOfNumbers)}");
            My.Goodbye();
        }
    }
}
