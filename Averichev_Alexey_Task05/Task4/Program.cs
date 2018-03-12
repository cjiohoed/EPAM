using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main()
        {

            var obj1 = new MyString("xyz");
            var obj2 = new MyString("WxyzORD WOxyzRD WORxyzD xyzWORD WORDxyzxyz : WxOyRzD WxyOyzRzxD WxxxyzOyyRxyzzzD");

            var r = obj1 != obj2;
            //var plus = obj1 + obj2;
            //Console.WriteLine(plus.ToString());
            ////Console.WriteLine(plus.Str);

            //var minus = obj2 - obj1;
            //Console.WriteLine(minus.ToString());
            ////Console.WriteLine(minus.Str);

            //if (obj1 == obj2)
            //{
            //    Console.WriteLine("Match! :)");
            //}
            //else
            //{
            //    Console.WriteLine("Dismatch! :(");
            //}

            //Console.ReadKey();
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

            if (source1.charArray.Length < source2.charArray.Length)
            {
                return source1;
            }
// asd  asdf
            var arr = new char?[source1.charArray.Length];
            bool flag;
            for (int i = 0; i < source1.charArray.Length; i++)
            {
                flag = false;
                if (source1.charArray[i] == source2.charArray[0])
                {
                    int matches = 0;
                    for (int j = 0; j < source2.charArray.Length; j++)
                    {
                        if (source1.charArray[i + j] == source2.charArray[j])
                        {
                            matches++;
                        }
                    }

                    if (matches == source2.charArray.Length)
                    {
                        for (int j = i; j < source2.charArray.Length; j++)
                        {
                            arr[j] = null;
                        }
                        i = i + source2.charArray.Length - 1;
                        flag = true;
                    }

                }

                if (!flag)
                {
                    arr[i] = source1.charArray[i];
                }
                
            }

            int resultArrayLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    resultArrayLength++;
                }
            }

            var result = new MyString();
            result.charArray = new char[resultArrayLength];

            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].HasValue)
                {
                    result.charArray[count] = arr[i].Value;
                    count++;
                }
            }

            return result;

            // Not used!
            //var result = new MyString();
            //result.charArray = source1.charArray.Except<char>(source2.charArray).ToArray<char>();
            //return result;

        }

        public static bool operator ==(MyString source1, MyString source2)
        {

            if (source1.charArray.Length != source2.charArray.Length)
            {
                return false;
            }

            for (int i = 0; i < source1.charArray.Length; i++)
            {
                if (source1.charArray[i] != source2.charArray[i])
                {
                    return false;
                }
            }

            return true;

        }

        public static bool operator !=(MyString source1, MyString source2)
        {
            return !(source1 == source2);
        }

        public override string ToString()
        {
            var result = new string(charArray);
            return result;
        }

    }
}
