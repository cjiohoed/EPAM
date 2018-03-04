using System;

namespace Lib
{
    // General methods. Title, inputs, goodbye.
    public class General
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

    // 1D array class.
    public class Arr
    {
        private int[] arr;
        private int length;
        public int minValue;
        public int maxValue;

        // Constructor 1D array
        public Arr(int count, int min, int max)
        {
            Random r = new Random();
            length = count;
            arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = r.Next(min, max);
            }
        }

        // Method displays 1D array.
        public void Display()
        {
            Console.WriteLine("Array elements:");

            for (int i = 0; i < this.arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }

        // Sort 1D array by bubble method.
        public void BubbleSort()
        {
            int temp;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (this.arr[i] > this.arr[j])
                    {
                        temp = this.arr[i];
                        this.arr[i] = this.arr[j];
                        this.arr[j] = temp;
                    }
                }
            }
        }

        // Returns the maximum value from the array.
        public int GetMaxValue()
        {
            int maxValue = this.arr[0];
            for (int i = 1; i < this.arr.Length; i++)
            {
                if (this.arr[i] > maxValue)
                {
                    maxValue = this.arr[i];
                }
            }
            return maxValue;
        }

        // Returns the minimum value from the array.
        public int GetMinValue()
        {
            int minValue = this.arr[0];
            for (int i = 1; i < this.arr.Length; i++)
            {
                if (this.arr[i] < minValue)
                {
                    minValue = this.arr[i];
                }
            }
            return minValue;
        }

        // Returns the summ of positive elements.
        public int GetPositiveSum()
        {
            int sum = 0;
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i] > 0)
                {
                    sum += this.arr[i];
                }
            }
            return sum;
        }
    }

    // 2D array class.
    public class Arr2D
    {
        private int[,] arr;
        private int lengthX;
        private int lengthY;

        public Arr2D(int countX, int countY, int min, int max)
        {
            Random r = new Random();
            lengthX = countX;
            lengthY = countY;
            arr = new int[countX, countY];

            for (int y = 0; y < countY; y++)
            {
                for (int x = 0; x < countX; x++)
                {
                    arr[x, y] = r.Next(min, max);
                }

            }
        }

        // Returns the summ of even positions.
        public int GetSumOfEvenPositions()
        {
            int sum = 0;
            for (int y = 0; y < this.arr.GetLength(1); y++)
            {
                for (int x = 0; x < this.arr.GetLength(0); x++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        sum += this.arr[x, y];
                    }
                }
            }
            return sum;
        }
    }

    // 3D array class.
    public class Arr3D
    {

        private int[,,] arr;
        private int lengthX;
        private int lengthY;
        private int lengthZ;

        // Constructor 3D array
        public Arr3D(int countX, int countY, int countZ, int min, int max)
        {
            Random r = new Random();
            lengthX = countX;
            lengthY = countY;
            lengthZ = countZ;
            arr = new int[countX, countY, countZ];

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
        }

        // Replaces positive values to zero.
        public void PositiveToZero()
        {
            for (int z = 0; z < this.arr.GetLength(2); z++)
            {
                for (int y = 0; y < this.arr.GetLength(1); y++)
                {
                    for (int x = 0; x < this.arr.GetLength(0); x++)
                    {
                        if (this.arr[x, y, z] > 0)
                        {
                            this.arr[x, y, z] = 0;
                        }
                    }

                }

            }
        }

    }

    // NOT USED! Old version!
    // Static methods class.
    public class ArrStatic
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
