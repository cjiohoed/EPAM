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
            var p1 = new Player();
            p1.Move(Direction.Right);

            do
            {
                Console.Clear();


                Console.Write("Press any key to continue...");
                var key = Console.ReadKey();
            }
            while (true);

        }
    }

    public class Obj
    {

    }

    public interface IObject
    {
        int X { get; }
        int Y { get; }
    }
}
