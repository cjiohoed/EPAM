using System;
using System.Collections;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var b = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var d = new int[] { 0, 1, 2 };
            var a = new DynamicArray<int>();
            var c = 1;

            a.AddRange(b);
            a.RemoveAt(c);
            a.Add(123);
            a.Show();
            Console.WriteLine($"Length: {a.Length}");
            Console.WriteLine($"Capacity: {a.Capacity}");
            Console.WriteLine($"Element 1: {a[c]}");

            Console.ReadKey();
        }
    }
}
