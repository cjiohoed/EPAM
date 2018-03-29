using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var numbers = CreateNumbers(100);

            var list = new List<int>(numbers);
            RemoveEachSecondItem(list);
            Display(list);

            var linkedList = new LinkedList<int>(numbers);
            RemoveEachSecondItem(linkedList);
            Display(linkedList);

            Console.ReadKey();

        }

        public static int[] CreateNumbers(int count)
        {
            var arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        public static void Display<T>(ICollection<T> list)
        {
            foreach (T item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }

        public static void RemoveEachSecondItem<T>(ICollection<T> list)
        {
            var temp = new List<T>();
            var flag = false;

            while (list.Count > 1)
            {
                foreach (T item in list)
                {
                    if (flag)
                    {
                        temp.Add(item);
                    }
                    flag = !flag;
                }

                foreach (T item in temp)
                {
                    list.Remove(item);
                }

                temp.Clear();
            }
        }
    }


}
