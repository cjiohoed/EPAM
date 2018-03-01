using System;

namespace Task2
{
    class Program
    {
        static string ConstructLine(char symb, int value)
        {
            string s = new String(symb, value);
            return s;
        }
        static string StarLines(int value)
        {
            string s = String.Empty;
            for (int i = 1; i <= value; i++)
            {
                s += ConstructLine('*', i) + "\n";
            }
            return s;
        }
        static int InputArg(string arg)
        {
            int result;
            string s;
            do
            {
                Console.Write($"Input {arg}: ");
                s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                {
                    Console.Write("Value is null or empty! ");
                }
                else if (!int.TryParse(s, out result))
                {
                    Console.Write("Incorrect parse! ");
                }
                else if (result <= 0)
                {
                    Console.Write("Value can't be null or negative! ");
                }
            }
            while (string.IsNullOrEmpty(s) || !int.TryParse(s, out result) || result <= 0);
            return result;
        }
        static void Goodbye()
        {
            Console.Write("Press any key...");
            Console.ReadKey();
        }

        static void Main()
        {
            int numberOfRows = InputArg("number of rows");
            string str = StarLines(numberOfRows);
            Console.WriteLine(str);
            Goodbye();
        }
    }
}
