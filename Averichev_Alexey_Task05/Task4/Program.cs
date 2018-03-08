using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main()
        {

            var obj1 = new MyString("Мама мыла раму ");
            var obj2 = new MyString("Клара у Карла украла кораллы");
            //var obj2 = new MyString("Мама мыла раму ");

            //var obj1 = new MyString();
            //var obj2 = new MyString();
            //obj1.Str = "Мама мыла раму ";
            //obj2.Str = "Клара у Карла украла кораллы";

            var plus = obj1 + obj2;
            Console.WriteLine(plus.ToString());
            Console.WriteLine(plus.Str);

            var minus = obj2 - obj1;
            Console.WriteLine(minus.ToString());
            Console.WriteLine(minus.Str);

            if (obj1 == obj2)
            {
                Console.WriteLine("Match! :)");
            }
            else
            {
                Console.WriteLine("Dismatch! :(");
            }


            Console.ReadKey();
        }
    }

    public class MyString
    {
        private char[] charArray;

        public string Str
        {
            get
            {
                var result = new string(charArray);
                return result;
            }
            set
            {
                charArray = value.ToArray();
            }
        }

        public MyString()
        {

        }

        public MyString(string str)
        {
            Str = str;
        }

        public static MyString operator +(MyString source1, MyString source2)
        {
            var result = new MyString();
            var arr = new char[source1.charArray.Length + source2.charArray.Length];
            source1.charArray.CopyTo(arr, 0);
            source2.charArray.CopyTo(arr, source1.charArray.Length);
            result.charArray = arr;
            return result;

            //source1.charArray.Concat(source2.charArray).ToArray();
            //return source1;
        }

        public static MyString operator -(MyString source1, MyString source2)
        {
            var result = new MyString();
            result.charArray = source1.charArray.Except<char>(source2.charArray).ToArray<char>();
            return result;
        }

        public static bool operator ==(MyString source1, MyString source2)
        {

            int matches = 0;
            for (int i = 0; i < source1.charArray.Length; i++)
            {
                if (source1.charArray[i] == source2.charArray[i])
                {
                    matches++;
                }
            }

            if (matches == source1.charArray.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(MyString source1, MyString source2)
        {
            int matches = 0;
            for (int i = 0; i < source1.charArray.Length; i++)
            {
                if (source1.charArray[i] == source2.charArray[i])
                {
                    matches++;
                }
            }

            if (matches == source1.charArray.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            var result = new string(charArray);
            return result;
        }

    }
}
