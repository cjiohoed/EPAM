using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = @"D:\C#\Tasks\Task12";
            var fileName = "disposable_task_file.txt";
            int func(int x) => x * x;

            var test = new FileDataReplace(dir, fileName, func);
            test.ReplaceDone += () => Console.WriteLine("Done!");
            test.Replace();
            Console.WriteLine(test);

            Console.ReadKey();
        }
    }
}
