using System;
using System.Threading;

namespace Task3
{
    public class StringArray
    {
        private string[] array;

        private delegate bool Compare(string string1, string string2);
        private static Compare comparator = IsFirstBigger;

        public delegate void Notification();
        public event Notification sortDone;

        public StringArray(string[] array)
        {
            this.array = array;
        }

        private static bool IsFirstBigger(string string1, string string2)
        {
            return string1.Length != string2.Length
                ? string1.Length > string2.Length
                : string.Compare(string1, string2, StringComparison.CurrentCultureIgnoreCase) > 0;
        }

        public void StringSort()
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

            sortDone?.Invoke();

        }

        public void SortInThread()
        {

            ThreadStart sort = () => StringSort();

            Thread thread = new Thread(sort);
            thread.Start();

        }

        public override string ToString()
        {
            string result = default(string);
            for (var i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;
        }

    }

}
