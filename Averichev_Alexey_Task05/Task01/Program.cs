using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var user1 = new User();
            user1.FirstName = "Ivan";
            user1.Patronymic = "Ivanovich";
            user1.LastName = "Ivanov";
            user1.GenderWord = "male";
            user1.DateOfBirth = "27.02.1978";

           var a= user1.Age;

            var user2 = new User("Petr", "Petrivich", "Petrov", "male", "23.12.1946");

            Console.WriteLine($"{user1.ToString()}");
            Console.WriteLine($"{user2.ToString()}");
            Console.WriteLine($"");

            Console.ReadKey();
        }
    }
}
