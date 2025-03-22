using System;
using System.Collections.Generic;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLogicLayer
{
    public class UserBLL
    {
        private readonly UserDAL _userDal;

        public UserBLL()
        {
            _userDal = new UserDAL();
        }

        // Insert User (Object-based)
        public bool InsertUser(User user)
        {
            if (user == null || string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.PasswordHash))
            {
                throw new ArgumentException("Invalid user data provided.");
            }

            return _userDal.InsertUser(user);
        }

        // Insert User (Primitive parameters)
        public bool Insertuser(string username, string email, string passwordHash, int? roleId)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(passwordHash))
            {
                throw new ArgumentException("Invalid user data provided.");
            }

            return _userDal.Insertuser(username, email, passwordHash, roleId);
        }

        // Retrieve all users
        public List<User> GetAllUsers()
        {
            return _userDal.GetAllUsers();
        }

        // Retrieve user by ID
        public User GetUserById(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("Invalid user ID.");
            }

            return _userDal.GetUserById(userId);
        }

        // Update User
        public bool UpdateUser(int userId, string username, string email, string passwordHash, int? roleId)
        {
            if (userId <= 0 || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(passwordHash))
            {
                throw new ArgumentException("Invalid user data provided.");
            }

            return _userDal.UpdateUser(userId, username, email, passwordHash, roleId);
        }

        // Delete User
        public bool DeleteUser(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("Invalid user ID.");
            }

            return _userDal.DeleteUser(userId);
        }
    }
}
