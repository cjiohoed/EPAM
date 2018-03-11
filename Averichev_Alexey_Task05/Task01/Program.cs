using System;
using System.Text.RegularExpressions;
using System.Globalization;

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

            var user2 = new User("Petr", "Petrivich", "Petrov", "male", "23.12.1946");

            Console.WriteLine($"{user1.ToString()}");
            Console.WriteLine($"{user2.ToString()}");
            Console.WriteLine($"");

            Console.ReadKey();
        }
    }

    class User
    {
        private string firstName = "N/A";
        private string lastName = "N/A";
        private string patronymic = "N/A";

        private bool gender;
        private string genderWord = "N/A";
        private string genderMale = "male";
        private string genderFemale = "female";

        private DateTime dateBirthDay = DateTime.Today;
        private int age = 0;

        public User(string firstName, string patronymic, string lastName,
            string genderword, string dateOfBirth)
        {
            FirstName = firstName;
            Patronymic = patronymic;
            LastName = lastName;
            GenderWord = genderword;
            DateOfBirth = dateOfBirth;
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
        }

        public string GenderWord
        {
            get
            {
                return genderWord;
            }
            set
            {
                if (IsGender(value))
                {
                    genderWord = value;
                    SetBoolGender(value);
                }
                else
                {
                    throw new Exception("Incorrect gender");
                }

            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateBirthDay.ToString("dd.MM.yyyy");
            }
            set
            {
                if (IsDate(value))
                {
                    dateBirthDay = DateTime.ParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    SetAge();
                }
                else
                {
                    throw new Exception("Date incorrect");
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public override string ToString()
        {
            return $"{firstName} {patronymic} {lastName}, {genderWord}, {DateOfBirth}, {Age} years old";
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

        private static bool IsDate(string str)
        {

            string datePattern = @"^(0[1-9]|[12]\d|3[01])\.(0[1-9]|1[0-2])\.((19|20)\d\d)$";
            if (Regex.IsMatch(str, datePattern))
            {
                return true;
            }
            return false;
        }

        private static bool IsGender(string str)
        {
            string genderPattern = @"^(|fe)male$";
            if (Regex.IsMatch(str, genderPattern))
            {
                return true;
            }
            return false;
        }

        private void SetBoolGender(string str)
        {
            if(str == genderMale)
            {
                gender = true;
            }
            else if(str == genderFemale)
            {
                gender = false;
            }
        }

        private void SetAge()
        {
            DateTime dateNow = DateTime.Today;
            int age = dateNow.Year - dateBirthDay.Year;
            if (dateNow.Month < dateBirthDay.Month || dateNow.Month == dateBirthDay.Month & dateNow.Day < dateBirthDay.Day)
            {
                age--;
            }

            this.age = age;
        }

    }
}
