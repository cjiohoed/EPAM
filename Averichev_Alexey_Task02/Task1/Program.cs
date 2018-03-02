using System;

namespace Task1
{
    class Program
    {
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
        static void RectangleArea()
        {
            int sqr = InputArg("width") * InputArg("height");
            Console.WriteLine($"Area of rectangle: {sqr}");
        }

        static int GetArea(int width, int height)
        {
            return width * height;
        }

        static void Goodbye()
        {
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        static void Main()
        {
            var area = GetArea(InputArg("width"), InputArg("height"));
            Console.WriteLine($"Area of rectangle: {area}");
            Goodbye();
        }
    }
}
