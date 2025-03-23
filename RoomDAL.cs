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
    public class RoomDAL
    {
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            string query = "SELECT room_id, room_name, room_type, capacity FROM rooms";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            RoomId = Convert.ToInt32(reader["room_id"]),
                            RoomName = reader["room_name"].ToString(),
                            RoomType = reader["room_type"].ToString(),
                            Capacity = Convert.ToInt32(reader["capacity"])
                        });
                    }

                }
                return rooms;
            }
        }
        public List<Room> GetUnassignedRooms()
        {
            List<Room> unassignedRooms = new List<Room>();
            string query = "SELECT R.room_id, R.room_name " +
                           "FROM Rooms R " +
                           "LEFT JOIN faculty_room_allocations fr ON R.room_id = fr.allocation_id " +
                           "WHERE fr.room_id IS NULL";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room
                            {
                                RoomId = reader.GetInt32(0),
                                RoomName = reader.GetString(1)
                            };
                            unassignedRooms.Add(room);
                        }
                    }


                }
                return unassignedRooms;
            }
        }
        public bool InsertRoom(string rname, string rtype, int capacity)
        {
            string query = "INSERT INTO rooms (room_name, room_type, capacity) VALUES (@room_name, @room_type, @capacity)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@room_name", rname);
                    command.Parameters.AddWithValue("@room_type", rtype);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateRoom(int rid, string rname, string rtype, int capacity)
        {
            string query = "UPDATE rooms SET room_name = @room_name, room_type = @room_type, capacity = @capacity WHERE room_id = @room_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@room_name", rname);
                    command.Parameters.AddWithValue("@room_type", rtype);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@room_id", rid);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteRoom(int roomId)
        {
            string query = "DELETE FROM rooms WHERE room_id = @room_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@room_id", roomId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
