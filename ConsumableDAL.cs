using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.Models;
using MySql.Data.MySqlClient;

namespace DBS25P131.DataAccessLayer
{
    public class ConsumableDAL
    {
        public List<Consumables> GetAllConsumables()
        {
            List<Consumables> consumables = new List<Consumables>();
            string query = "SELECT consumable_id, item_name FROM consumable";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    consumables.Add(new Consumables
                    {
                        ConsumableId = Convert.ToInt32(reader["consumable_id"]),
                        ItemName = reader["item_name"].ToString()
                    });
                }
            }
            return consumables;
        }

        public bool InsertConsumable(Consumables consumable)
        {
            string query = "INSERT INTO consumable (item_name) VALUES (@item_name)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@item_name", consumable.ItemName);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateConsumable(Consumables consumable)
        {
            string query = "UPDATE consumable SET item_name = @item_name WHERE consumable_id = @consumable_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@item_name", consumable.ItemName);
                command.Parameters.AddWithValue("@consumable_id", consumable.ConsumableId);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteConsumable(int consumableId)
        {
            string query = "DELETE FROM consumable WHERE consumable_id = @consumable_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@consumable_id", consumableId);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
