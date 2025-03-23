using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Lookup Role { get; set; } 

        public User() { }

        public User(int userId, string username, string email, string passwordHash, Lookup role)
        {
            UserId = userId;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}
