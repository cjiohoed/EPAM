using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {

            var b = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var a = new DynamicArray<int>();
            var c = 2;

            a.AddRange(b);
            a.RemoveAt(c);
            a.Add(123);

            foreach(var item in a)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();

        }
    }
}
