using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var collection = ConsoleApp.GetRandomCollection(20);
            ConsoleApp.Draw(collection);

            Console.ReadKey();
        }
    }
}

