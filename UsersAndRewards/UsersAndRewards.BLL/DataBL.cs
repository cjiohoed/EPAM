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
            dataDAL = new DataDALdb();
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

        public List<User> GetUsersList()
        {
            return dataDAL.GetUsersList();
        }

        public List<UserViewModel> GetUsersViewModel()
        {
            var users = GetUsersList();
            return users.Select(u => UserViewModel.GetModel(u)).ToList();
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

        public void DeleteManyRewards(List<Reward> rewsforDelete)
        {
            foreach (var r in rewsforDelete)
            {
                foreach (User user in GetUsersList())
                {
                    if (user.Rewards.Contains(r))
                    {
                        user.Rewards.Remove(r);
                    }
                }
                DeleteReward(r.ID);
            }
        }

    }
}
