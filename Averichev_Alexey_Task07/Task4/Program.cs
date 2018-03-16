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
            

            //Status(player1);
            //player1.Move(Direction.Down);
            //Status(player1);

            char key;

            do
            {
                Status(player1);
                Console.WriteLine("W - move up; S - move down; A - Left; D - Right; X - exit ");
                //key = Console.ReadKey().KeyChar;
                ConsoleMove(player1);
            }
            while (true);

            Console.ReadKey();
        }

        static void Status(GameObject obj)
        {
            Console.WriteLine($"Name: {obj.Name}\tPosition: ({obj.X},{obj.Y})");
        }

        static void ConsoleMove(IMoveable obj)
        {
            var key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case 'w': obj.Move(Direction.Up); break;
                case 'a': obj.Move(Direction.Left); break;
                case 's': obj.Move(Direction.Down); break;
                case 'd': obj.Move(Direction.Right); break;
            }
        }
    }
}
