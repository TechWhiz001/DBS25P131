using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.DataAccessLayer

{
    public class DatabaseHelper
    {
        private string serverName = "127.0.0.1";
        private string port = "3306";
        private string databaseName = "midprojectdb";
        private string databaseUser = "root";
        private string databasePassword = "Abdulrehman149808";

        private DatabaseHelper() { }

        private static DatabaseHelper _instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }

        private string GetConnectionString()
        {
            return $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=None;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(GetConnectionString());
        }

        public MySqlDataReader getData(string query)
        {
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public int Update(string query)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
        public object ExecuteScalar(string query)
        {
            using (var connection = GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                return command.ExecuteScalar();
            }
        }
    }

}
