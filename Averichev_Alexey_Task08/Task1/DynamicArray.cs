using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DynamicArray<T>
    {
        T[] arr;

        // Свойство Length – получение длины заполненной части массива.
        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        // Свойство Capacity – получение реальной ёмкости массива.
        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        // Индексатор, позволяющий работать с элементом с указанным номером.
        // При выходе за границу массива должно генерироваться
        // исключение ArgumentOutOfRangeException. 
        public T this[int index]
        {
            get
            {
                if(index >= 0 & index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // * Конструктор без параметров (создается массив емкостью 8 элементов).
        public DynamicArray()
        {
            arr = new T[8];
        }

        // * Конструктор с 1 целочисленным параметром (создается массив заданной емкости). 
        public DynamicArray(int capacity)
        {
            arr = new T[capacity];
        }

        // Конструктор, который в качестве параметра принимает массив.
        public DynamicArray(T[] arr)
        {

        }

        // Метод Add, добавляющий в конец массива один элемент.
        // При нехватке места для добавления элемента
        // емкость массива должна расширяться в 2 раза.
        public void Add()
        {

        }

        // Метод AddRange, добавляющий в конец массива содержимое переданного массива.
        // Обратите внимание, метод должен корректно учитывать число элементов в коллекции с тем,
        // чтобы при необходимости расширения массива делать это только один раз
        //вне зависимости от числа элементов в добавляемой коллекции.
        public void AddRange()
        {

        }

        // Метод Remove, удаляющий из коллекции указанный элемент.
        // Метод должен возвращать true, если удаление прошло успешно и false в противном случае.
        //При удалении элементов реальная емкость массива не должна уменьшаться.
        public bool Remove()
        {
            return false;
        }

        // Метод Insert, позволяющий добавить элемент в произвольную позицию массива
        // (обратите внимание, может потребоваться расширить массив).
        // При выходе за границу массива должно генерироваться
        // исключение ArgumentOutOfRangeException.
        public void Insert()
        {

        }


    }
}
