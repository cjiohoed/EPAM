using Lib;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = new int[5,6,8];
            Arr.CreateRandomThreeD(arrayOfNumbers, My.InputArgSimple("min element"), My.InputArgSimple("max element"));
            Arr.PositiveToZero(arrayOfNumbers);
            My.Goodbye();
        }
    }
}
