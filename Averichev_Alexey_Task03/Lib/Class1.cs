using System;

namespace Lib
{
    public class My
    {
        public static int InputArg(string arg)
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

        public static int InputArgSimple(string arg)
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
            }
            while (string.IsNullOrEmpty(s) || !int.TryParse(s, out result));
            return result;
        }

        public static void Goodbye()
        {
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
    public class Arr
    {
        public static int[] CreateRandom(int[] arr, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
            return arr;
        }

        public static int[,,] CreateRandomThreeD(int[,,] arr, int min, int max)
        {
            Random r = new Random();
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    for (int x = 0; x < arr.GetLength(0); x++)
                    {
                        arr[x,y,z] = r.Next(min, max);
                    }

                }

            }
            return arr;
        }

        public static void Display(int[] arr)
        {
            Console.WriteLine("Array elements:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }

        public static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static int MaxValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int MinValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int[,,] PositiveToZero(int[,,] arr)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    for (int x = 0; x < arr.GetLength(0); x++)
                    {
                        if (arr[x, y, z] > 0)
                        {
                            arr[x, y, z] = 0;
                        }
                    }

                }

            }
            return arr;
        }

        public static int GetPositiveSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
