using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.DAL
{
    public interface IDataDAL
    {
        void AddUser(User user);
        List<User> GetUsersList();
        void AddReward(Reward reward);
        List<Reward> GetRewardsList();
        Reward FindRewardById(int id);
        void EditReward(Reward reward);
        void DeleteReward(int id);
        User FindUserById(int id);
        void EditUser(User user);
        void DeleteUser(int id);
    }
}
