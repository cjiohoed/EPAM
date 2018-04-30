using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using UsersAndRewards.DAL;

namespace UsersAndRewards.BLL
{
    public class DataBL : IDataBL
    {
        private readonly IDataDAL dataDAL;

        public DataBL()
        {
            dataDAL = new DataDAL();
        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new Exception("Empty user!");
            }
            dataDAL.AddUser(user);
        }

        public void AddReward(Reward reward)
        {
            if (reward == null)
            {
                throw new Exception("Empty reward!");
            }
            dataDAL.AddReward(reward);
        }

        public void DeleteUser(int id)
        {
            dataDAL.DeleteUser(id);
        }

        public void EditUser(User user)
        {
            dataDAL.EditUser(user);
        }

        public List<User> InitUsers()
        {
            AddUser(new User()
            {
                FirstName = "Алексей",
                LastName = "Аверичев",
                BirthDate = new DateTime(1983, 5, 25)
            });
            return GetUsersList();
        }

        public List<Reward> InitRewards()
        {
            AddReward(new Reward()
            {
                Title = "Shnobel Prize",
                Description = "47 chromosome"
            });
            return GetRewardsList();
        }


        public List<User> GetUsersList()
        {
            return dataDAL.GetUsersList();
        }

        public List<Reward> GetRewardsList()
        {
            return dataDAL.GetRewardsList();
        }

        public Reward FindRewardById(int id)
        {
            return dataDAL.FindRewardById(id);
        }

        public User FindUserById(int id)
        {
            return dataDAL.FindUserById(id);
        }

        public void EditReward(Reward reward)
        {
            dataDAL.EditReward(reward);
        }

        public void DeleteReward(int id)
        {
            dataDAL.DeleteReward(id);
        }

    }
}
