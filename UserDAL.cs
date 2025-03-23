using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    public class UserDAL
    {
        // Insert User
        public bool InsertUser(User user)
        {
            string query = "INSERT INTO users (username, email, password_hash, role_id) " +
                           "VALUES (@Username, @Email, @PasswordHash, @RoleId)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                command.Parameters.AddWithValue("@RoleId", user.Role.LookupId);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        // Retrieve All Users
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT u.user_id, u.username, u.email, u.password_hash, " +
                           "l.lookup_id, l.category, l.value " +
                           "FROM users u " +
                           "LEFT JOIN lookup l ON u.role_id = l.lookup_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Lookup role = reader.IsDBNull(4) ? null : new Lookup
                        {
                            LookupId = reader.GetInt32(4),
                            Category = reader.GetString(5),
                            Value = reader.GetString(6)
                        };

                        User user = new User
                        {
                            UserId = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Email = reader.GetString(2),
                            PasswordHash = reader.GetString(3),
                            Role = role
                        };

                        users.Add(user);
                    }
                }
            }
            return users;
        }

        // Retrieve a User by ID
        public User GetUserById(int userId)
        {
            string query = "SELECT u.user_id, u.username, u.email, u.password_hash, " +
                           "l.lookup_id, l.category, l.value " +
                           "FROM users u " +
                           "LEFT JOIN lookup l ON u.role_id = l.lookup_id " +
                           "WHERE u.user_id = @UserId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Lookup role = reader.IsDBNull(4) ? null : new Lookup
                        {
                            LookupId = reader.GetInt32(4),
                            Category = reader.GetString(5),
                            Value = reader.GetString(6)
                        };

                        return new User
                        {
                            UserId = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Email = reader.GetString(2),
                            PasswordHash = reader.GetString(3),
                            Role = role
                        };
                    }
                }
            }
            return null;
        }

        // Update User
        public bool UpdateUser(int userId, string username, string email, string passwordHash, int? roleId)
        {
            string query = "UPDATE users SET username = @Username, email = @Email, password_hash = @PasswordHash, " +
                           "role_id = @RoleId WHERE user_id = @UserId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@RoleId", roleId.HasValue ? (object)roleId.Value : DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        // Delete User
        public bool DeleteUser(int userId)
        {
            string query = "DELETE FROM users WHERE user_id = @UserId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        // Insert User with Primitive Parameters
        public bool Insertuser(string username, string email, string passwordHash, int? roleId)
        {
            string query = "INSERT INTO users (username, email, password_hash, role_id) " +
                           "VALUES (@Username, @Email, @PasswordHash, @RoleId)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@RoleId", roleId.HasValue ? (object)roleId.Value : DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
