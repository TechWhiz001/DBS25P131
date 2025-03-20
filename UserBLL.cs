//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using DBS25P131.DataAccessLayer;
//using DBS25P131.Models;


//namespace DBS25P131.Business_Logic_Layer
//{
//    public class UserBLL
//    {
//        private readonly UserDAL userDAL;

//        public UserBLL()
//        {
//            userDAL = new UserDAL();
//        }

//        // Method to validate user data
//        private void ValidateUser(User user, bool checkId = false)
//        {
//            if (user == null)
//                throw new ArgumentException("User cannot be null.");

//            if (checkId && user.UserId <= 0)
//                throw new ArgumentException("Invalid user ID.");

//            if (string.IsNullOrWhiteSpace(user.Username) || user.Username.Length < 3 || user.Username.Length > 50)
//                throw new ArgumentException("Username must be between 3 and 50 characters.");

//            if (!IsValidEmail(user.Email))
//                throw new ArgumentException("Invalid email format.");

//            if (string.IsNullOrWhiteSpace(user.PasswordHash) || user.PasswordHash.Length < 8)
//                throw new ArgumentException("Password must be at least 8 characters long.");

//            if (user.RoleId.HasValue && user.RoleId.Value <= 0)
//                throw new ArgumentException("Invalid role ID.");
//        }

//        // Email validation using regex
//        private bool IsValidEmail(string email)
//        {
//            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//            return Regex.IsMatch(email, emailPattern);
//        }

//        public bool AddUser(User user)
//        {
//            ValidateUser(user);
//            return userDAL.InsertUser(user);
//        }

//        public List<User> GetAllUsers()
//        {
//            return UserDAL.GetAllUsers();
//        }

//        public User GetUserById(int userId)
//        {
//            if (userId <= 0)
//                throw new ArgumentException("Invalid user ID.");

//            return userDAL.GetUserById(userId);
//        }

//        public bool UpdateUser(User user)
//        {
//            ValidateUser(user, checkId: true);
//            return userDAL.UpdateUser(user);
//        }

//        public bool DeleteUser(int userId)
//        {
//            if (userId <= 0)
//                throw new ArgumentException("Invalid user ID.");

//            return userDAL.DeleteUser(userId);
//        }
//    }
//}