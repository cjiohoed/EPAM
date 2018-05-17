using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.BLL
{
    public interface IDataBL
    {
        void AddUser(User user);
        void AddReward(Reward reward);
        void EditUser(User user);
        void DeleteUser(int id);
        List<Reward> GetRewardsList();
        List<User> GetUsersList();
        Reward FindRewardById(int id);
        void EditReward(Reward reward);
        void DeleteReward(int id);
        User FindUserById(int id);
        List<UserViewModel> GetUsersViewModel();
    }
}
