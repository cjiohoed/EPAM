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
                //
                Rewards = user.Rewards == null ? string.Empty : user.Rewards.Select(r => r.Title)
            };
        }
    }
}
