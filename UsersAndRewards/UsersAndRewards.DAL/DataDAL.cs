using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.DAL
{
    public class DataDAL : IDataDAL
    {
        private int _usersId;
        private List<User> users = new List<User>();
        private int _rewardId;
        private List<Reward> rewards = new List<Reward>();

        public void AddUser (User user)
        {
            if (user == null)
            {
                throw new Exception();
            }
            user.ID = _usersId++;
            users.Add(user);
        }

        public void AddReward(Reward reward)
        {
            if (reward == null)
            {
                throw new Exception();
            }
            reward.ID = _rewardId++;
            rewards.Add(reward);
        }

        public List<User> GetUsersList()
        {
            return users;
        }

        public List<Reward> GetRewardsList()
        {
            return rewards;
        }

        public Reward FindRewardById(int id)
        {
            return rewards.First(r => r.ID == id);
        }

        public void EditReward(Reward reward)
        {
            var oldReward = FindRewardById(reward.ID);
            oldReward.Title = reward.Title;
            oldReward.Description = reward.Description;
        }

        public void DeleteReward(int id)
        {
            var oldReward = FindRewardById(id);
            rewards.Remove(oldReward);
        }
    }
}
