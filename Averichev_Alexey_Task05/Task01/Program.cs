using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var user = new User();

            user.FirstName = "Alexey";
            user.Patronymic = "Alexandrovich";
            user.LastName = "Averichev";
            user.Gender = true;
            user.YearOfBirth = 1983;
            user.MonthOfBirth = 5;
            user.DayOfBirth = 25;

            Console.WriteLine($"UserInfo:\n{user.ToString()}");

            if (user.Pensioner)
            {
                Console.WriteLine("Pensioner");
            }
            else
            {
                Console.WriteLine("Not pensioner");
            }

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
                    throw new Exception("Surname error");
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
                if (value >= 1 & value <= 31)
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

        public bool Pensioner
        {
            get
            {
                if ((gender & age >= 63) | (!gender & age >= 58))
                {
                    return true;
                }
                return false;
            }
        }

        public override string ToString()
        {
            string gndr = string.Empty;
            if (gender)
            {
                gndr = "Male";
            }
            else
            {
                gndr = "Female";
            }

            return $"FirstName: {firstName}, Patronymic: {patronymic} LastName: {lastName}, Gender: {gndr}, BirthDate: {dayOfBirth}.{monthOfBirth}.{yearOfBirth}, Age: {Age}";
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
