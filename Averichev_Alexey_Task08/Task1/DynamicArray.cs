using System;

namespace Task1
{
    public class DynamicArray<T>
    {
        private T[] arr;

        public int Length { get; private set; }

        public int Capacity { get; private set; }

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
            Capacity = 8;
        }

        public DynamicArray(int capacity)
        {
            arr = new T[capacity];
            Length = 0;
            Capacity = capacity;
        }

        public DynamicArray(T[] arr)
        {
            this.arr = arr;
            Length = arr.Length;
            Capacity = arr.Length;
        }

        public void Add(T item)
        {

            if (Length + 1 >= Capacity)
            {
                T[] tempArr;
                Capacity *= 2;
                tempArr = new T[Capacity];
                //Array.Copy(arr, tempArr, 0);
                arr.CopyTo(tempArr, 0);
                tempArr[Length] = item;
                arr = tempArr;
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
                T[] tempArr;
                do
                {
                    Capacity *= 2;
                }
                while (Length + arr.Length >= Capacity);

                tempArr = new T[Capacity];
                //Array.Copy(this.arr, tempArr, 0);
                this.arr.CopyTo(tempArr, 0);
                //Array.Copy(arr, tempArr, Length);
                arr.CopyTo(tempArr, Length);
                Length += arr.Length;
                this.arr = tempArr;
            }
            else
            {
                Array.Copy(arr, this.arr, arr.Length);
                Length += arr.Length;
            }
        }

        public bool Remove(int index)
        {
            if (index >= 0 & index < arr.Length)
            {
                T[] tempArr;
                tempArr = new T[Capacity];
                Array.Copy(arr, 0, tempArr, 0, index);
                Array.Copy(arr, index + 1, tempArr, index, arr.Length - index - 1);
                arr = tempArr;
                Length--;
                return true;
            }
            else
            {
                return false;
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
