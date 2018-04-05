using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] source = { "qwer", "rtysd", "asdd", "fghjjkry", "zxc", "vb" };

            var stringArray = new StringArray(source);

            var handler = new Handler();

            stringArray.sortDone += handler.doneMsg;

            // упрощение через лямбду
            // stringArray.sortDone += () => Console.WriteLine("Отсортировано");

            stringArray.SortInThread();
            
            Console.ReadKey();

        }
    }
}
