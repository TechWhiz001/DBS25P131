//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using DBS25P131.Models;

//namespace DBS25P131.DataAccessLayer
//{
//    public class UserDAL
//    {
//        // Method to Insert a New User
//        public bool InsertUser(User user)
//        {
//            string query = "INSERT INTO users (username, email, password_hash, role_id) VALUES (@username, @email, @password_hash, @role_id)";

//            using (var connection = DatabaseHelper.Instance.GetConnection())
//            using (var command = new MySqlCommand(query, connection))
//            {
//                command.Parameters.AddWithValue("@username", user.Username);
//                command.Parameters.AddWithValue("@email", user.Email);
//                command.Parameters.AddWithValue("@password_hash", user.PasswordHash);
//                command.Parameters.AddWithValue("@role_id", user.RoleId.HasValue ? (object)user.RoleId.Value : DBNull.Value);

//                return command.ExecuteNonQuery() > 0;
//            }
//        }

//        // Method to Retrieve All Users
//        public List<User> GetAllUsers()
//        {
//            List<User> users = new List<User>();
//            string query = "SELECT * FROM users";

//            using (var connection = DatabaseHelper.Instance.GetConnection())
//            using (var command = new MySqlCommand(query, connection))
//            using (var reader = command.ExecuteReader())
//            {
//                while (reader.Read())
//                {
//                    users.Add(new User(
//                        reader.GetInt32(reader.GetOrdinal("user_id")),
//                        reader.GetString(reader.GetOrdinal("username")),
//                        reader.GetString(reader.GetOrdinal("email")),
//                        reader.GetString(reader.GetOrdinal("password_hash")),
//                        reader.IsDBNull(reader.GetOrdinal("role_id")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("role_id"))
//                    ));
//                }
//            }
//            return users;
//        }

//        // Method to Retrieve a User by ID
//        public User GetUserById(int id)
//        {
//            string query = "SELECT * FROM users WHERE user_id = @id";

//            using (var connection = DatabaseHelper.Instance.GetConnection())
//            using (var command = new MySqlCommand(query, connection))
//            {
//                command.Parameters.AddWithValue("@id", id);

//                using (var reader = command.ExecuteReader())
//                {
//                    if (reader.Read())
//                    {
//                        return new User(
//                            reader.GetInt32(reader.GetOrdinal("user_id")),
//                            reader.GetString(reader.GetOrdinal("username")),
//                            reader.GetString(reader.GetOrdinal("email")),
//                            reader.GetString(reader.GetOrdinal("password_hash")),
//                            reader.IsDBNull(reader.GetOrdinal("role_id")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("role_id"))
//                        );
//                    }
//                }
//            }
//            return null; // Return null if not found
//        }

//        // Method to Update an Existing User
//        public bool UpdateUser(User user)
//        {
//            string query = "UPDATE users SET username = @username, email = @email, password_hash = @password_hash, role_id = @role_id WHERE user_id = @user_id";

//            using (var connection = DatabaseHelper.Instance.GetConnection())
//            using (var command = new MySqlCommand(query, connection))
//            {
//                command.Parameters.AddWithValue("@username", user.Username);
//                command.Parameters.AddWithValue("@email", user.Email);
//                command.Parameters.AddWithValue("@password_hash", user.PasswordHash);
//                command.Parameters.AddWithValue("@role_id", user.RoleId.HasValue ? (object)user.RoleId.Value : DBNull.Value);
//                command.Parameters.AddWithValue("@user_id", user.UserId);

//                return command.ExecuteNonQuery() > 0;
//            }
//        }

//        // Method to Delete a User by ID
//        public bool DeleteUser(int id)
//        {
//            string query = "DELETE FROM users WHERE user_id = @id";

//            using (var connection = DatabaseHelper.Instance.GetConnection())
//            using (var command = new MySqlCommand(query, connection))
//            {
//                command.Parameters.AddWithValue("@id", id);
//                return command.ExecuteNonQuery() > 0;
//            }
//        }
//    }
//}
