using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    public class DynamicArray<T> : IEnumerable<T> where T : IComparable<T>
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

        public DynamicArray(IEnumerable<T> collection)
        {
            int count = 0;
            foreach (var item in collection)
            {
                count++;
            }

            if (Length + count > Capacity)
            {
                do
                {
                    ChangeCapacity(Capacity * 2);
                }
                while (Length + count >= Capacity);
            }

            int i = 0;
            foreach (var item in collection)
            {
                arr[Length + i] = item;
                i++;
            }

            Length += count;

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

            if (Length + 1 >= Capacity)
            {
                ChangeCapacity(Capacity * 2);
                arr[Length] = item;
            }

            for (int i = Length; i < index; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[index] = item;
            Length++;

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

        public IEnumerator<T> GetEnumerator()
        {
            //return ((IEnumerable<T>)arr).GetEnumerator();

            for (var i = 0; i < Length; i++)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return ((IEnumerable<T>)arr).GetEnumerator();

            for (var i = 0; i < Length; i++)
            {
                yield return arr[i];
            }
        }

    }
}
