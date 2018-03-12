﻿using System;
namespace Task1
{
    public class Employee : User
    {
        private int experience = 0;

        //public enum Positions { chief, advocate, cashier, junior }
        //private Positions position;

        private string position = String.Empty;

        public Employee(
            string firstName,
            string patronymic,
            string lastName,
            GenderList gender,
            DateTime dateOfBirth,
            int experience,
            string position
            )
        {
            FirstName = firstName;
            Patronymic = patronymic;
            LastName = lastName;
            Gender = gender;
            dateBirthDay = dateOfBirth;
            Experience = experience;
            Position = position;
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if(value < age)
                {
                    experience = value;
                }
                else
                {
                    throw new Exception("Incorrect experience");
                }
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
                if(!String.IsNullOrEmpty(value))
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
