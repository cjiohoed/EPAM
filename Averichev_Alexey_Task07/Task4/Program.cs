using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            var player1 = new Player("John", 0, 0);
            

            Status(player1);
            player1.Move(Direction.Down);
            Status(player1);

            Console.ReadKey();
        }

        static void Status(Obj obj)
        {
            Console.WriteLine($"Name: {obj.Name}\tPosition: ({obj.X},{obj.X})");
        }
    }
}
