using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Rewards { get; set; }

        public static UserViewModel GetModel(User user)
        {
            return new UserViewModel
            {
                ID = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                Age = user.Age,
                Rewards = user.Rewards == null ? string.Empty : String.Join(", ", user.Rewards.Select(r => r.Title))
            };
        }
    }
}
