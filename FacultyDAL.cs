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
            string query = @"SELECT f.faculty_id, f.name, f.email, f.contact, 
                                    l.lookup_id, f.research_area, 
                                    f.total_teaching_hours, U.user_id
                             FROM faculty f
                             JOIN lookup l ON f.designation_id = l.lookup_id
                             JOIN users U ON f.user_id = U.user_id";

            try
            {
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
                                Name = reader["name"].ToString(),
                                Email = reader["email"].ToString(),
                                Contact = reader["contact"].ToString(),
                                Designation = new Lookup { LookupId = Convert.ToInt32(reader["lookup_id"]) },
                                ResearchArea = reader["research_area"] != DBNull.Value ? reader["research_area"].ToString() : string.Empty,
                                TotalTeachingHours = reader["total_teaching_hours"] != DBNull.Value ? Convert.ToInt32(reader["total_teaching_hours"]) : 0,
                                User = new User { UserId = Convert.ToInt32(reader["user_id"]) }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching faculty data: " + ex.Message);
            }
            return faculties;
        }
        public bool InsertFaculty(string name, string email, int designationId, string contact, string researchArea, int totalHours, int userId)
        {
            string query = @"INSERT INTO faculty 
                     (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) 
                     VALUES (@name, @email, @contact, @designation_id, @research_area, @total_teaching_hours, @user_id)";
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contact", contact);
                    command.Parameters.AddWithValue("@designation_id", designationId);
                    command.Parameters.AddWithValue("@research_area", string.IsNullOrEmpty(researchArea) ? DBNull.Value : (object)researchArea);
                    command.Parameters.AddWithValue("@total_teaching_hours", totalHours);
                    command.Parameters.AddWithValue("@user_id", userId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting faculty: " + ex.Message);
                return false;
            }
        }

        public bool InsertOrUpdateFaculty(int? facultyId, string name, string email, int designationId, string contact, string researchArea, int totalHours, int userId)
        {
            string query = facultyId == null
                ? @"INSERT INTO faculty (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) 
                   VALUES (@name, @email, @contact, @designation_id, @research_area, @total_teaching_hours, @user_id)"
                : @"UPDATE faculty 
                   SET name = @name, email = @email, contact = @contact, 
                       designation_id = @designation_id, research_area = @research_area, 
                       total_teaching_hours = @total_teaching_hours, user_id = @user_id
                   WHERE faculty_id = @faculty_id";

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    if (facultyId != null)
                        command.Parameters.AddWithValue("@faculty_id", facultyId);

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@contact", contact);
                    command.Parameters.AddWithValue("@designation_id", designationId);
                    command.Parameters.AddWithValue("@research_area", string.IsNullOrEmpty(researchArea) ? DBNull.Value : researchArea);
                    command.Parameters.AddWithValue("@total_teaching_hours", totalHours);
                    command.Parameters.AddWithValue("@user_id", userId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {(facultyId == null ? "inserting" : "updating")} faculty: " + ex.Message);
                return false;
            }
        }

        public string GetFacultyResearchArea(int facultyId)
        {
            string researchArea = string.Empty;
            string query = "SELECT research_area FROM faculty WHERE faculty_id = @faculty_id";

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@faculty_id", facultyId);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        researchArea = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching faculty research area: " + ex.Message);
            }
            return researchArea;
        }

        public int GetFacultyIdByUserId(int userId)
        {
            int facultyId = -1;
            string query = "SELECT faculty_id FROM faculty WHERE user_id = @UserId";

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            facultyId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching faculty ID by user ID: " + ex.Message);
            }
            return facultyId;
        }

        public bool DeleteFaculty(int facultyId)
        {
            string query = "DELETE FROM faculty WHERE faculty_id = @faculty_id";

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@faculty_id", facultyId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting faculty: " + ex.Message);
                return false;
            }
        }
    }
}
