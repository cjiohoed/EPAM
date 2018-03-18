using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    partial class Program
    {
        static void Main()
        {

            const int width = 50;
            const int height = 30;
            const int objNum = 10;

            //GameObject player = new Player("Johnny", 0, 0);
            //IGameField field = new ConsoleGame();
            //player.Draw(field);
            //player.MoveTo(Direction.Down);
            //player.Draw(field);

            var objects = GetObjectPack(width, height, objNum);
            var game = new ConsoleGame(width, height);
            game.Clear();
            game.Place(objects);

            GameObject player = new Player("Johnny", 0, 0);
            game.Place(player);

            game.Display();

            Console.Write("Press any key to move...");
            Console.ReadKey();

            player.MoveTo(Direction.Down);

            Console.Write("Press any key...");
            Console.ReadKey();
        }

        private static List<GameObject> GetObjectPack(int width, int height, int count)
        {
            var figures = new List<GameObject>();
            var rnd = new Random();
            //figures.Add(new Player("Pl", rnd.Next(0, width), rnd.Next(0, height)));
            for (int i = 0; i < count; i++)
            {
                figures.Add(new Monster("Mo", rnd.Next(0, width), rnd.Next(0, height)));
            }

            return figures;
        }

        public static GameObject[,] GetObjects(int width, int height)
        {
            GameObject[,] result = new GameObject[width, height];
            var rnd = new Random();
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    switch (rnd.Next(10))
                    {
                        case 0:
                            result[i, j] = new Player("Pl", rnd.Next(0, width), rnd.Next(0, height));
                            break;
                        case 1:
                            result[i, j] = new Monster("Mo", rnd.Next(0, width), rnd.Next(0, height));
                            break;
                        default:

                            break;
                    }
                }
            }
            return result;
        }

        static void ConsoleMove(IMoveable obj)
        {
            var key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case 'w': obj.MoveTo(Direction.Up); break;
                case 'a': obj.MoveTo(Direction.Left); break;
                case 's': obj.MoveTo(Direction.Down); break;
                case 'd': obj.MoveTo(Direction.Right); break;
            }
        }
    }
}
