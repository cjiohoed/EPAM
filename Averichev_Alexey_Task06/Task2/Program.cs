using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            var a = new Round(0, 0, 6);
            Console.WriteLine(a.Area);
            Console.WriteLine(a.CircleLenght);

            var b = new Round(0, 0, 5);
            Console.WriteLine(b.Area);
            Console.WriteLine(b.CircleLenght);

            var c = new Ring(0, 0, 5, 6);
            Console.WriteLine(c.Area);
            Console.WriteLine(c.SumLenghts);

            Console.ReadKey();
        }
    }
}
