using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TwoDPointWithHash(1, 1);
            var b = new TwoDPointWithHash(10, 10);

            var c = new TwoDPointWithHash(1, 10);
            var d = new TwoDPointWithHash(10, 1);

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine($"{c} =equals= {d}\t{c.Equals(d).ToString()}");
            Console.WriteLine($"{c} =hash= {d}\t{(c.GetHashCode() == d.GetHashCode()).ToString()}");

            Console.ReadKey();
        }
    }
}
