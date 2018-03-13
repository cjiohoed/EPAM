using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {

            var a = new User(
                "Ivan",
                "Ivanovich",
                "Ivanov",
                User.GenderList.male,
                new DateTime(1982, 10, 25));
            Console.WriteLine(a.ToString());

            var b = new User(
                "Maria",
                "Petrovna",
                "Kolesnikova",
                User.GenderList.female,
                new DateTime(1956, 03, 23));
            Console.WriteLine(b.ToString());

            var c = new Employee(
                "Petr",
                "Petrovich",
                "Petrov",
                User.GenderList.male,
                new DateTime(1978, 08, 01),
                20,
                "cashier");
            Console.WriteLine(c.ToString());

            Console.ReadKey();

        }
    }
}
