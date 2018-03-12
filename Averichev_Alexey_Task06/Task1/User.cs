using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Task1
{
    public class User
    {
        protected string firstName = "N/A";
        protected string lastName = "N/A";
        protected string patronymic = "N/A";
        public enum GenderList { female, male };
        protected GenderList gender;
        protected DateTime dateBirthDay = DateTime.Today;
        protected int age = 0;

        public User(
            string firstName,
            string patronymic,
            string lastName,
            GenderList gender,
            DateTime dateOfBirth
            )
        {
            FirstName = firstName;
            Patronymic = patronymic;
            LastName = lastName;
            Gender = gender;
            dateBirthDay = dateOfBirth;
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

        public GenderList Gender { get; set; }

        public int Age
        {
            get

            {
                SetAge();
                return age;
            }
        }

        public override string ToString()
        {
            return $"{firstName} {patronymic} {lastName}, {Gender}, {dateBirthDay.ToString("dd.MM.yyyy")}, {Age}";
        }

        private static bool IsName(string source)
        {
            string namePattern = @"^[A-ZА-Я]\w+$";
            if (Regex.IsMatch(source, namePattern))
            {
                return true;
            }
            return false;
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
