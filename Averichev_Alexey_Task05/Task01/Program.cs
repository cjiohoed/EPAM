using System;
using System.Text.RegularExpressions;

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
            user1.Gender = true;
            user1.YearOfBirth = 1978;
            user1.MonthOfBirth = 3;
            user1.DayOfBirth = 27;

            var user2 = new User("Petr", "Petrivich", "Petrov", true, 23, 12, 1946);

            Console.WriteLine($"UserInfo: {user1.ToString()}");
            Console.WriteLine($"UserInfo: {user2.ToString()}");

            Console.ReadKey();
        }
    }

    class User
    {
        private string firstName = "N/A";
        private string lastName = "N/A";
        private string patronymic = "N/A";
        private bool gender = false;
        private int age = 0;
        private int maxAge = 150;
        private int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());
        private int yearOfBirth = 0;
        private int monthOfBirth = 0;
        private int dayOfBirth = 0;

        public User(string firstName, string patronymic, string lastName, 
            bool gender, int dayOfBirth, int monthOfBirth, int yearOfBirth)
        {
            FirstName = firstName;
            Patronymic = patronymic;
            LastName = lastName;
            Gender = gender;
            DayOfBirth = dayOfBirth;
            MonthOfBirth = monthOfBirth;
            YearOfBirth = yearOfBirth;
        }

        public User()
        {

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (IsName(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("Name error");
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (IsName(value))
                {
                    lastName = value;
                }
                else
                {
                    throw new Exception("Lastname error");
                }
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (IsName(value))
                {
                    patronymic = value;
                }
                else
                {
                    throw new Exception("Surname error");
                }
            }
        }

        public bool Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                if(value < currentYear & currentYear - value < maxAge)
                {
                    yearOfBirth = value;
                }
                else
                {
                    throw new Exception("Incorrect year");
                }
            }
        }

        public int MonthOfBirth
        {
            get
            {
                return monthOfBirth;
            }
            set
            {
                if(value >= 1 & value <= 12)
                {
                    monthOfBirth = value;
                }
                else
                {
                    throw new Exception("Incorrect month");
                }
            }
        }

        public int DayOfBirth
        {
            get
            {
                return dayOfBirth;
            }
            set
            {
                if (value > 0 & value < 32)
                {
                    dayOfBirth = value;
                }
                else
                {
                    throw new Exception("Incorrect day");
                }
            }
        }

        public int Age
        {
            get
            {
                return currentYear - yearOfBirth;
            }
        }

        public override string ToString()
        {
            string gndr = string.Empty;
            switch (gender)
            {
                case true:
                    gndr = "male";
                    break;
                case false:
                    gndr = "female";
                    break;
            }

            return $"{firstName} {patronymic} {lastName}, {gndr}, {dayOfBirth}.{monthOfBirth}.{yearOfBirth}, {Age}";
        }

        private static bool IsName(string str)
        {
            string namePattern = @"^[A-ZА-Я]\w{2,}$";
            if (Regex.IsMatch(str, namePattern))
            {
                return true;
            }
            return false;
        }
    }
}
