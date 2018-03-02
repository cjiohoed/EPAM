using Lib;
using System;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            My.Title("03.1");

            var arrayOfNumbers = new int[My.InputArg("elements of array")];
            Arr.CreateRandom(arrayOfNumbers, My.InputArgSimple("min element"), My.InputArgSimple("max element"));
            Arr.BubbleSort(arrayOfNumbers);
            Arr.Display(arrayOfNumbers);
            Console.WriteLine($"Min value of array: {Arr.MinValue(arrayOfNumbers)}");
            Console.WriteLine($"Max value of array: {Arr.MaxValue(arrayOfNumbers)}");

            My.Goodbye();
        }
    }
}
