using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace UsersAndRewards.DAL
{
    public class DataDALdb : IDataDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void AddReward(Reward reward)
        {
            string sqlExpression = "AddReward";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter titleParam = new SqlParameter
                {
                    ParameterName = "@Title",
                    Value = reward.Title
                };
                command.Parameters.Add(titleParam);
                SqlParameter DescriptionParam = new SqlParameter
                {
                    ParameterName = "@Description",
                    Value = reward.Description
                };
                command.Parameters.Add(DescriptionParam);
                command.ExecuteNonQuery();
            }
        }

        public void AddUser(User user)
        {
            int? id;
            string sqlExpression1 = "AddUser";
            string sqlExpression2 = "AddUserReward";
            List<int> rewardIds = new List<int>();
            foreach (Reward reward in user.Rewards)
            {
                rewardIds.Add(reward.ID);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter firstNameParam = new SqlParameter
                {
                    ParameterName = "@Firstname",
                    Value = user.FirstName
                };
                command.Parameters.Add(firstNameParam);
                SqlParameter lastNameParam = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = user.LastName
                };
                command.Parameters.Add(lastNameParam);
                SqlParameter birthDateParam = new SqlParameter
                {
                    ParameterName = "@BirthDate",
                    Value = user.BirthDate
                };
                command.Parameters.Add(birthDateParam);
                id = (int)command.ExecuteScalar();
            }

            foreach (int rewardId in rewardIds)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression2, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter usersIdParam = new SqlParameter
                    {
                        ParameterName = "@UsersId",
                        Value = id
                    };
                    command.Parameters.Add(usersIdParam);
                    SqlParameter rewardsIdParam = new SqlParameter
                    {
                        ParameterName = "@RewardsId",
                        Value = rewardId
                    };
                    command.Parameters.Add(rewardsIdParam);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteReward(int id)
        {
            string sqlExpression1 = "DeleteReward";
            string sqlExpression2 = "DeleteUserReward";
            Reward reward = FindRewardById(id);
            List<int> userIds = new List<int>();
            foreach (User user in GetUsersList())
            {
                foreach (Reward rew in user.Rewards)
                {
                    if (rew.ID == id)
                    {
                        userIds.Add(user.ID);
                    }
                }
            }
            foreach (int userId in userIds)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression2, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter usersIdParam = new SqlParameter
                    {
                        ParameterName = "@UsersId",
                        Value = userId
                    };
                    command.Parameters.Add(usersIdParam);
                    SqlParameter rewardsIdParam = new SqlParameter
                    {
                        ParameterName = "@RewardsId",
                        Value = id
                    };
                    command.Parameters.Add(rewardsIdParam);
                    command.ExecuteNonQuery();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter rewardsIdParam = new SqlParameter
                {
                    ParameterName = "@RewardsId",
                    Value = id
                };
                command.Parameters.Add(rewardsIdParam);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int id)
        {
            string sqlExpression1 = "DeleteUser";
            string sqlExpression2 = "DeleteUserReward";
            User user = FindUserById(id);
            List<int> rewardIds = new List<int>();
            foreach (Reward reward in user.Rewards)
            {
                rewardIds.Add(reward.ID);
            }
            foreach (int rewardId in rewardIds)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression2, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter usersIdParam = new SqlParameter
                    {
                        ParameterName = "@UsersId",
                        Value = id
                    };
                    command.Parameters.Add(usersIdParam);
                    SqlParameter rewardsIdParam = new SqlParameter
                    {
                        ParameterName = "@RewardsId",
                        Value = rewardId
                    };
                    command.Parameters.Add(rewardsIdParam);
                    command.ExecuteNonQuery();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter usersIdParam = new SqlParameter
                {
                    ParameterName = "@UsersId",
                    Value = id
                };
                command.Parameters.Add(usersIdParam);
                command.ExecuteNonQuery();
            }
        }

        public void EditReward(Reward reward)
        {
            string sqlExpression = "EditReward";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter rewardsIdParam = new SqlParameter
                {
                    ParameterName = "@RewardsId",
                    Value = reward.ID
                };
                command.Parameters.Add(rewardsIdParam);
                SqlParameter titleParam = new SqlParameter
                {
                    ParameterName = "@Title",
                    Value = reward.Title
                };
                command.Parameters.Add(titleParam);
                SqlParameter descriptionParam = new SqlParameter
                {
                    ParameterName = "@Description",
                    Value = reward.Description
                };
                command.Parameters.Add(descriptionParam);
                command.ExecuteNonQuery();
            }
        }

        public void EditUser(User user)
        {
            string sqlExpression1 = "EditUser";
            string sqlExpression2 = "AddUserReward";
            string sqlExpression3 = "DeleteUserReward";
            List<int> rewardIdsAdd = new List<int>();
            List<int> rewardIdsRemove = new List<int>();
            User oldUser = FindUserById(user.ID);
            foreach (Reward reward in oldUser.Rewards)
            {
                if (!user.Rewards.Exists(r => r.ID == reward.ID))
                {
                    rewardIdsRemove.Add(reward.ID);
                }
            }
            foreach (Reward reward in user.Rewards)
            {
                if (!oldUser.Rewards.Exists(r => r.ID == reward.ID))
                {
                    rewardIdsAdd.Add(reward.ID);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression1, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter usersIdParam = new SqlParameter
                {
                    ParameterName = "@UsersId",
                    Value = user.ID
                };
                command.Parameters.Add(usersIdParam);
                SqlParameter firstNameParam = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = user.FirstName
                };
                command.Parameters.Add(firstNameParam);
                SqlParameter lastNameParam = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = user.LastName
                };
                command.Parameters.Add(lastNameParam);
                SqlParameter birthDateParam = new SqlParameter
                {
                    ParameterName = "@BirthDate",
                    Value = user.BirthDate
                };
                command.Parameters.Add(birthDateParam);
                command.ExecuteNonQuery();
            }
            foreach (int id in rewardIdsAdd)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression2, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter usersIdParam = new SqlParameter
                    {
                        ParameterName = "@UsersId",
                        Value = user.ID
                    };
                    command.Parameters.Add(usersIdParam);
                    SqlParameter rewardsIdParam = new SqlParameter
                    {
                        ParameterName = "@RewardsId",
                        Value = id
                    };
                    command.Parameters.Add(rewardsIdParam);
                    command.ExecuteNonQuery();
                }
            }
            foreach (int id in rewardIdsRemove)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression3, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter usersIdParam = new SqlParameter
                    {
                        ParameterName = "@UsersId",
                        Value = user.ID
                    };
                    command.Parameters.Add(usersIdParam);
                    SqlParameter rewardsIdParam = new SqlParameter
                    {
                        ParameterName = "@RewardsId",
                        Value = id
                    };
                    command.Parameters.Add(rewardsIdParam);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Reward FindRewardById(int id)
        {
            return GetRewardsList().First(r => r.ID == id);
        }

        public User FindUserById(int id)
        {
            return GetUsersList().First(u => u.ID == id);
        }

        public List<Reward> GetRewardsList()
        {
            string sqlExpression = "GetRewards";
            List<Reward> rewards = new List<Reward>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Reward reward = new Reward();
                        reward.ID = reader.GetInt32(0);
                        reward.Title = reader.GetString(1);
                        reward.Description = reader.GetString(2);
                        rewards.Add(reward);
                    }
                }
                reader.Close();
            }
            return rewards;
        }

        public List<User> GetUsersList()
        {

            string sqlExpression = "GetUsers";
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((users.Count > 0) && (users.Last().ID == (reader.GetInt32(0))))
                        {
                            Reward reward = new Reward();
                            reward.ID = reader.GetInt32(4);
                            reward.Title = reader.GetString(5);
                            reward.Description = reader.GetString(6);
                            users.Last().Rewards.Add(reward);
                        }
                        else
                        {
                            User user = new User();
                            user.ID = reader.GetInt32(0);
                            user.FirstName = reader.GetString(1);
                            user.LastName = reader.GetString(2);
                            user.BirthDate = reader.GetDateTime(3);
                            if (!reader.IsDBNull(4))
                            {
                                Reward reward = new Reward();
                                reward.ID = reader.GetInt32(4);
                                reward.Title = reader.GetString(5);
                                reward.Description = reader.GetString(6);
                                user.Rewards.Add(reward);
                            }
                            users.Add(user);
                        }
                    }
                }
                reader.Close();
            }
            return users;

        }
    }
}
