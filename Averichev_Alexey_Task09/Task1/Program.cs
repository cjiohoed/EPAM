using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {

            //var names = new[] { "Вова", "Вася", "Маша", "Сережа", "Жора", "Света", "Марина" };
            var names = CreateNames(100);
            var list1 = new List<string>(names);
            var list2 = new LinkedList<string>(names);


        }

        static string[] CreateNames(int count)
        {
            var arr = new string[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = (i + 1).ToString();
            }
            return arr;
        }

    }


}
