using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UsersAndRewards.DAL
{
    public class DataDALdb : IDataDAL
    {
        string con = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public void AddReward(Reward reward)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteReward(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public void EditReward(Reward reward)
        {
            throw new NotImplementedException();
        }

        public void EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public Reward FindRewardById(int id)
        {
            throw new NotImplementedException();
        }

        public User FindUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reward> GetRewardsList()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersList()
        {
            throw new NotImplementedException();
        }
    }
}
