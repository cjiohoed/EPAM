using System;
namespace Task1
{
    public class Employee : User
    {
        private int experience = 0;
        private DateTime experienceBeginning;

        private string position = String.Empty;

        public Employee(
            string firstName,
            string patronymic,
            string lastName,
            GenderList gender,
            DateTime dateOfBirth,
            DateTime expBeginning,
            string position)
            : base(
                  firstName,
                  patronymic,
                  lastName,
                  gender,
                  dateOfBirth)
        {
            experienceBeginning = expBeginning;
            Position = position;
        }

        public int Experience
        {
            get
            {
                return DateTimeExtensions.GetFullYears(experienceBeginning);
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    position = value;
                }
                else
                {
                    throw new Exception("Empty position");
                }
            }
        }

        public override string ToString()
        {
            return $"{firstName} {patronymic} {lastName}, {Gender}, {dateBirthDay.ToString("dd.MM.yyyy")}, {Age}, {Experience}, {Position}";
        }
    }
}
