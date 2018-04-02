using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {

            var alex = new Person("Алекс");
            var john = new Person("Джон");
            var bill = new Person("Билл");

            alex.Came += PersonCame;
            john.Came += PersonCame;
            bill.Came += PersonCame;

            alex.Leave += PersonLeft;
            john.Leave += PersonLeft;
            bill.Leave += PersonLeft;

            alex.OnCame();
            john.OnCame();
            bill.OnCame();
            alex.OnLeave();
            john.OnLeave();
            bill.OnLeave();

            Console.ReadKey();

        }

        public delegate void HelloMsg(Person person, DateTime time);
        public static HelloMsg greetByUs;
        public delegate void ByeMsg(Person person);
        public static ByeMsg goodbyeByUs;

        static void PersonCame(Person person, DateTime e)
        {                                       
            if (person != null)
            {
                Console.WriteLine($"[ {person.Name} пришел на работу ]");
                greetByUs?.Invoke(person, e);
                greetByUs += person.Hello;
                goodbyeByUs += person.Bye;
            }
        }

        static void PersonLeft(Person person)
        {                                      
            if (person != null)
            {
                greetByUs -= person.Hello;
                goodbyeByUs -= person.Bye;
                Console.WriteLine($"[ {person.Name} ушел домой ]");
                goodbyeByUs?.Invoke(person);
            }
        }

    }
}
