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
            bill.OnCame();
            bill.OnLeave();
            john.OnCame();
            alex.OnLeave();

            Console.ReadKey();

        }

        public delegate void HelloMsg(Person person, DateTime time);
        public static HelloMsg greetByUs;
        public delegate void ByeMsg(Person person);
        public static ByeMsg goodbyeByUs;

        static void PersonCame(object sender, EventArgs e)
        {
            var person = sender as Person;

            if (person != null && !person.IsCame)
            {
                Console.WriteLine($"[ {person.Name} пришел на работу ]");
                person.IsCame = true;
                greetByUs?.Invoke(person, DateTime.Now);
                greetByUs += person.Hello;
                goodbyeByUs += person.Bye;
            }
        }

        static void PersonLeft(object sender, EventArgs e)
        {
            var person = sender as Person;

            if (person != null && person.IsCame)
            {
                greetByUs -= person.Hello;
                goodbyeByUs -= person.Bye;
                Console.WriteLine($"[ {person.Name} ушел домой ]");
                person.IsCame = false;
                goodbyeByUs?.Invoke(person);
            }
        }

    }
}
