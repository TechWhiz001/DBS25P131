using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DBS25P131.Data_Acess_layer;

namespace DBS25P132.data_access
{
    internal class UsersDAL
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password_hash { get; set; }
        public int role_id { get; set; }

        public UsersDAL(string username, string email, string password_hash, int role_id)
        {
            this.username = username;
            this.email = email;
            this.password_hash = password_hash;
            this.role_id = role_id;
        }

        public UsersDAL(string email, string password_hash)
        {
            this.email = email;
            this.password_hash = password_hash;

            if (this.SearchUser())
            {
                this.GetRoleID();
                this.GetUserID();
                this.GetUsername();
            }
        }

        public void AddUser()
        {
            string query = $"INSERT INTO Users (username, email, password_hash, role_id) VALUES ('{username}', '{email}', '{password_hash}', '{role_id}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void RemoveUserName()
        {
            string query = $"DELETE FROM Users WHERE username = '{username}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void RemoveUserEmail()
        {
            string query = $"DELETE FROM Users WHERE email = '{email}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditUsername()
        {
            string query = $"UPDATE Users SET username = '{username}' WHERE email = '{email}'";
            DatabaseHelper.Instance.Update(query);
        }
        public void EditUserEmail()
        {
            string query = $"UPDATE Users SET email = '{email}' WHERE username = '{username}'";
            DatabaseHelper.Instance.Update(query);
        }
        public void EditPassword()
        {
            string query = $"UPDATE Users SET password_hash = '{password_hash}' WHERE email = '{email}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditRoleID()
        {
            string query = $"UPDATE Users SET role_id = '{role_id}' WHERE email = '{email}'";
            DatabaseHelper.Instance.Update(query);
        }


        public bool SearchUser()
        {
            string query = $"SELECT * FROM Users WHERE email = '{email}' AND password_hash = '{password_hash}'";

            var reader = DatabaseHelper.Instance.getData(query);
            return reader.Read();
        }

        public bool SearchEmail()
        {
            string query = $"SELECT * FROM Users WHERE email = '{email}'";

            var reader = DatabaseHelper.Instance.getData(query);
            return reader.Read();
        }

        public bool SearchUsername()
        {
            string query = $"SELECT * FROM Users WHERE username = '{username}'";

            var reader = DatabaseHelper.Instance.getData(query);
            return reader.Read();
        }

        public int GetRoleID()
        {
            string query = $"SELECT role_id From Users WHERE email = '{email}' AND password_hash = '{password_hash}'";
            var reader = DatabaseHelper.Instance.getData(query);

            role_id = Convert.ToInt32(reader["role_id"]);
            return role_id;
        }

        public string GetUsername()
        {
            string query = $"SELECT username From Users WHERE email = '{email}' AND password_hash = '{password_hash}'";
            var reader = DatabaseHelper.Instance.getData(query);

            username = Convert.ToString(reader["username"]);
            return username;
        }

        public int GetUserID()
        {
            string query = $"SELECT user_id From Users WHERE email = '{email}' AND password_hash = '{password_hash}'";
            var reader = DatabaseHelper.Instance.getData(query);

            user_id = Convert.ToInt32(reader["user_id"]);
            return user_id;
        }
    }
}
