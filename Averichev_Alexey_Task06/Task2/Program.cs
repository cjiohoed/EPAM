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
            Console.WriteLine($"{a.CircleArea}\t\t{a.CircleLenght}");

            Console.WriteLine("-\t\t+");

            var b = new Round(0, 0, 5);
            Console.WriteLine($"{b.CircleArea}\t\t{b.CircleLenght}");

            Console.WriteLine("=\t\t=");

            var c = new Ring(0, 0, 5, 6);
            Console.WriteLine($"{c.RingArea}\t\t{c.SumLenghts}");

            Console.ReadKey();
        }
    }
}
