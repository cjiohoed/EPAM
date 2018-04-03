using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "qwer", "rtysd", "asdd", "fghjjkry", "zxc", "vb" };

            Compare comparator = IsFirstBigger;

            ThreadStart sort = () => StringSort(array, comparator);

            var evnt = new SortEvent();

            SortInThread(sort);

            Console.ReadKey();

            DisplayArray(array);

            Console.ReadKey();
        }

        
        

        public delegate bool Compare(string string1, string string2);

        public static bool IsFirstBigger(string string1, string string2)
        {
            return string1.Length != string2.Length
                ? string1.Length > string2.Length
                : string.Compare(string1, string2, StringComparison.CurrentCultureIgnoreCase) > 0;
        }

        public static void StringSort(string[] array, Compare comparator)
        {
            if (array.Length < 2)
            {
                return;
            }

            var temp = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparator(array[i], array[j]))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public static void SortInThread(ThreadStart sort)
        {
            if (sort == null)
            {
                throw new ArgumentNullException("Sort cannot be null or empty.", nameof(sort));
            }

            Thread thread = new Thread(sort);
            thread.Start();
        }

        public static void SortFinish()
        {
            Console.WriteLine("Finish!");
        }

        public static void DisplayArray(string[] array)
        {
            string result = default(string);
            for (var i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            Console.WriteLine($"{result}\n");
        }
    }

    public delegate void UI();

    public class SortEvent
    {
        public event UI SortStatus;

        public void OnSortStatus()
        {
            SortStatus();
        }
    }

}
