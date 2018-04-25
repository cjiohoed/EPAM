using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                return GetAge();
            }
        }
        public string Rewards
        {
            get
            {
                return String.Join(", ", MyRewards?.Select(t => t.Title) ?? new List<string>());
            }
        }
        public List<Reward> MyRewards { get; set; }

        private int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public User()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            BirthDate = DateTime.Now;
            MyRewards = new List<Reward>();
        }

        public User(string firstname, string lastname, DateTime birthdate)
        {
            FirstName =firstname;
            LastName = lastname;
            BirthDate = birthdate;
            MyRewards = new List<Reward>();
        }

        public User(string firstname, string lastname, DateTime birthdate, List<Reward> rewards)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            MyRewards = rewards;
        }


    }
}
