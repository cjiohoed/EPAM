using System;
using System.Collections;

namespace Task1
{
    public class DynamicArray<T> where T : IComparable<T>
    {
        private T[] arr;

        public int Length { get; private set; }

        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 & index < Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public DynamicArray()
        {
            arr = new T[8];
            Length = 0;
        }

        public DynamicArray(int capacity)
        {
            arr = new T[capacity];
            Length = 0;
        }

        public DynamicArray(T[] arr)
        {
            this.arr = arr;
            Length = arr.Length;
        }

        public void Add(T item)
        {

            if (Length + 1 >= Capacity)
            {
                ChangeCapacity(Capacity * 2);
                arr[Length] = item;
            }
            else
            {
                arr[Length] = item;
            }

            Length++;

        }

        public void AddRange(T[] arr)
        {
            if (Length + arr.Length > Capacity)
            {
                do
                {
                    ChangeCapacity(Capacity * 2);
                }
                while (Length + arr.Length >= Capacity);

                arr.CopyTo(this.arr, Length);
                Length += arr.Length;
            }
            else
            {
                Array.Copy(arr, this.arr, arr.Length);
                Length += arr.Length;
            }
        }

        public void RemoveAt(int index)
        {
            T[] tempArr;
            tempArr = new T[Capacity];
            Array.Copy(arr, 0, tempArr, 0, index);
            Array.Copy(arr, index + 1, tempArr, index, arr.Length - index - 1);
            arr = tempArr;
            Length--;
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(arr, item);
            if (index == -1)
            {
                return false;
            }
            else
            {
                RemoveAt(index);
                return true;
            }
        }

        public void Insert(T item, int index)
        {
            if (index < 0 && index > Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                arr[index] = item;
            }
        }

        private void ChangeCapacity(int newCapacity)
        {
            T[] tempArr;
            tempArr = new T[newCapacity];
            arr.CopyTo(tempArr, 0);
            arr = tempArr;
        }

        public void Sort()
        {
            T temp;
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");
        }
    }
}
