using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.Models;
using MySql.Data.MySqlClient;

namespace DBS25P131.DataAccessLayer
{
    public class FacultyRoomAllocationDAL
    {
        private string connectionString = "your_connection_string_here"; 

        public bool Insert(int facultyId, int roomId, int semesterId, int reservedHours)
        {
            string checkQuery = "SELECT COUNT(*) FROM semesters WHERE semester_id = @semesterId";
            using (var connection = DatabaseHelper.Instance.GetConnection())

            {
                connection.Open();
                using (var command = new MySqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@semesterId", semesterId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Invalid Semester ID. Please enter a valid semester.");
                        return false;
                    }
                }

                string query = "INSERT INTO Faculty_Room_AllocationS (faculty_id, room_id, reserved_hours, semester_id) " +
                               "VALUES (@FacultyId, @RoomId, @ReservedHours, @SemesterId)";

            //using (var connection = DatabaseHelper.Instance.GetConnection())
            //{
            //    connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacultyId", facultyId);
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@ReservedHours", reservedHours); 
                    command.Parameters.AddWithValue("@SemesterId", semesterId);       


                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<FacultyRoomAllocation> GetAllAllocations()
        {
            List<FacultyRoomAllocation> allocations = new List<FacultyRoomAllocation>();

            string query = @"SELECT fra.allocation_id, 
                                    f.faculty_id, f.name, 
                                    r.room_id, r.room_name, 
                                    fra.reserved_hours, 
                                    s.semester_id, s.term, s.year 
                             FROM faculty_room_allocations fra
                             JOIN faculty f ON fra.faculty_id = f.faculty_id
                             JOIN rooms r ON fra.room_id = r.room_id
                             JOIN semesters s ON fra.semester_id = s.semester_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Faculty faculty = new Faculty
                            {
                                FacultyId = reader.GetInt32(1),
                                Name = reader.GetString(2)
                            };

                            Room room = new Room
                            {
                                RoomId = reader.GetInt32(3),
                                RoomName = reader.GetString(4)
                            };

                            Semester semester = new Semester
                            {
                                SemesterId = reader.GetInt32(6),
                                Term = reader.GetString(7),
                                Year = reader.GetInt32(8)
                            };

                            FacultyRoomAllocation allocation = new FacultyRoomAllocation(
                                reader.GetInt32(0), faculty, room, reader.GetInt32(5), semester
                            );

                            allocations.Add(allocation);
                        }
                    }
                }
                return allocations;
            }
        }
        public bool Update(int allocationId, int facultyId, int roomId, int semesterId, int reservedHours)
        {
            string query = @"UPDATE faculty_room_allocations 
                                 SET faculty_id = @FacultyId, room_id = @RoomId, reserved_hours = @ReservedHours, semester_id = @SemesterId
                                 WHERE allocation_id = @AllocationId";
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FacultyId", facultyId);
                    command.Parameters.AddWithValue("@RoomId", roomId);
                    command.Parameters.AddWithValue("@ReservedHours", reservedHours);
                    command.Parameters.AddWithValue("@SemesterId", semesterId);
                    command.Parameters.AddWithValue("@AllocationId", allocationId);

                    return command.ExecuteNonQuery() > 0;

                }
            }
        }
        
        public bool Delete(int allocationId)
        {
            string query = "DELETE FROM Faculty_Room_Allocations WHERE allocation_id = @AllocationId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AllocationId", allocationId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
