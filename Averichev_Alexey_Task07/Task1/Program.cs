using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Figure rect = new Rectangle(5, 6);
            Console.WriteLine(rect.Area());

            Figure round = new Round(0, 0, 10);
            Console.WriteLine(round.Area());

            Figure ring = new Ring(0, 0, 5, 10);
            Console.WriteLine(ring.Area());

            Console.WriteLine();

            Console.ReadKey();
        }
    }

}
