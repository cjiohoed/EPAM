using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            var text = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                "ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis " +
                "nostrud exercitation ullamco laboris nisi ut aliquip ex ea " +
                "commodo consequat. Duis aute irure dolor in reprehenderit in " +
                "voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa " +
                "qui officia deserunt mollit anim id est laborum";

            var dict = new WordsCounter(text);

            foreach (var item in dict.Dictionary)
            {
                Console.WriteLine(item);
            }

            var a = dict.Text;

            Console.ReadKey();
        }
    }
}
