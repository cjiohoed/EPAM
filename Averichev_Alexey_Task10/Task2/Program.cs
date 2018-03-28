using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }

        public void Hello(Person person, DateTime time)
        {
            string message;
            if (time.Hour < 12)
            {
                message = "Доброе утро";
            }
            if (time.Hour >= 12 & time.Hour < 17)
            {
                message = "Добрый день";
            }
            if (time.Hour >= 17)
            {
                message = "Добрый вечер";
            }
        }

        public void Bye(Person person)
        {

        }
    }
}
