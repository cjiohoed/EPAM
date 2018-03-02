using System;

namespace Lib
{
    public class My
    {
        public static void Title(string task)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($" ╔═══════════════════════════════╗");
            Console.WriteLine($" ║        [.NET 2018-1]          ║");
            Console.WriteLine($" ║   Averichev_Alexey_Task{task}   ║");
            Console.WriteLine($" ║     a.averichev@gmail.com     ║");
            Console.WriteLine($" ╚═══════════════════════════════╝\n");
            Console.ResetColor();
        }
        
        // Input integer value from the keyboard with verification.
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

        // Input integer value from the keyboard with simple verification.
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
            Console.Write("\nDone! Press any key...");
            Console.ReadKey();
        }
    }

    // Methods for arrays.
    public class Arr
    {
        // Method CreateRandom overloading 1.
        // Random data --> 1-dimensional array.
        public static int[] CreateRandom(int[] arr, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
            return arr;
        }

        // Method CreateRandom overloading 2.
        // Random data --> 2-dimensional array.
        public static int[,] CreateRandom(int[,] arr, int min, int max)
        {
            Random r = new Random();
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    arr[x, y] = r.Next(min, max);
                }

            }

            return arr;
        }

        // Method CreateRandom overloading 3.
        // Random data --> 3-dimensional array

        public static int[,,] CreateRandom(int[,,] arr, int min, int max)
        {
            Random r = new Random();
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    for (int x = 0; x < arr.GetLength(0); x++)
                    {
                        arr[x, y, z] = r.Next(min, max);
                    }

                }

            }
            return arr;
        }
        
        // Method displays array.
        // 1-dimensional array.
        public static void Display(int[] arr)
        {
            Console.WriteLine("Array elements:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }

        // Sort by bubble method.
        // 1-dimensional array.
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

        // Returns the maximum value from the array.
        // 1-dimensional array.
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

        // Returns the minimum value from the array.
        // 1-dimensional array.
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

        // Replaces positive values to zero.
        // 3-dimensional array.
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

        // Returns the summ of positive elements.
        // 1-dimensional array.
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

        // Returns the summ of even positions.
        // 2-dimensional array.
        public static int GetSumOfEvenPositions(int[,] arr)
        {
            int sum = 0;
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        sum += arr[x, y];
                    }
                }
            }
            return sum;
        }
    }
}
