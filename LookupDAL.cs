using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;
using MySql.Data.MySqlClient;

namespace DBS25P131.DataAccessLayer
{
    public class LookupDAL
    {
        public List<Lookup> GetAllLookups()
        {
            List<Lookup> lookups = new List<Lookup>();
            string query = "SELECT lookup_id, category, value FROM lookup";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lookups.Add(new Lookup
                    {
                        LookupId = Convert.ToInt32(reader["lookup_id"]),
                        Category = reader["category"].ToString(),
                        Value = reader["value"].ToString()
                    });
                }
            }
            return lookups;
        }

        public bool InsertLookup(Lookup lookup)
        {
            string query = "INSERT INTO lookup (category, value) VALUES (@category, @value)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@category", lookup.Category);
                command.Parameters.AddWithValue("@value", lookup.Value);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteLookup(int lookupId)
        {
            string query = "DELETE FROM lookup WHERE lookup_id = @lookup_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@lookup_id", lookupId);
                return command.ExecuteNonQuery() > 0;
            }
        }
        public int GetItemIdByName(string itemName)
        {
            int itemId = -1; // Default value if not found
            string query = "SELECT lookup_id FROM lookup WHERE value = @itemName LIMIT 1";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@itemName", itemName);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        itemId = Convert.ToInt32(reader["lookup_id"]);
                    }
                }
            }
            return itemId;
        }
    }

}
