using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    public class FacultyDAL
    {
        public List<Faculty> GetAllFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            string query = @"SELECT f.faculty_id, f.name, f.email, f.contact, l.lookup_id, 
                                    f.research_area, f.total_teaching_hours, U.user_id
                             FROM faculty f
                             JOIN lookup l ON f.designation_id = l.lookup_id
                             JOIN users U ON f.user_id = U.user_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        faculties.Add(new Faculty
                        {
                            FacultyId = Convert.ToInt32(reader["faculty_id"]),
                            Designation = new Lookup { LookupId = Convert.ToInt32(reader["lookup_id"]) },
                            User = new User { UserId = Convert.ToInt32(reader["user_id"]) },
                            Name = reader["name"].ToString(),
                            Email = reader["email"].ToString(),
                            Contact = reader["contact"].ToString(),
                            ResearchArea = reader["research_area"].ToString(),
                            TotalTeachingHours = Convert.ToInt32(reader["total_teaching_hours"])
                        });
                    }
                }
            }
            return faculties;
        }

        public bool InsertFaculty(string name, string email, int designationId, string contact, string researchArea, int totalHours, int userId)
        {
            string query = @"INSERT INTO faculty (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) 
                             VALUES (@name, @email, @contact, @designation_id, @research_area, @total_teaching_hours, @user_id)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@designation_id", designationId);
                command.Parameters.AddWithValue("@research_area", researchArea);
                command.Parameters.AddWithValue("@total_teaching_hours", totalHours);
                command.Parameters.AddWithValue("@user_id", userId);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateFaculty(int facultyId, string name, string email, int designationId, string contact, string researchArea, int totalHours, int userId)
        {
            string query = @"UPDATE faculty 
                             SET name = @name, email = @email, contact = @contact, 
                                 designation_id = @designation_id, research_area = @research_area, 
                                 total_teaching_hours = @total_teaching_hours, user_id = @user_id
                             WHERE faculty_id = @faculty_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@faculty_id", facultyId);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@designation_id", designationId);
                command.Parameters.AddWithValue("@research_area", researchArea);
                command.Parameters.AddWithValue("@total_teaching_hours", totalHours);
                command.Parameters.AddWithValue("@user_id", userId);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public string GetFacultyResearchArea(int facultyId)
        {
            string researchArea = "";
            string query = "SELECT research_area FROM faculty WHERE faculty_id = @faculty_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@faculty_id", facultyId);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    researchArea = result.ToString();
                }
            }
            return researchArea;
        }

        public bool DeleteFaculty(int facultyId)
        {
            string query = "DELETE FROM faculty WHERE faculty_id = @faculty_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@faculty_id", facultyId);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
