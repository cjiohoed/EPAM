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
            var FigCollection = ConsoleApp.CreateRandomCollection(20);
            ConsoleApp.DrawCollection(FigCollection);

            Console.ReadKey();
        }
    }
}
