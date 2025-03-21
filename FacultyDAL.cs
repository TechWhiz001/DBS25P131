using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.BusinessLayer;
using MySql.Data.MySqlClient;
using DBS25P131.Models;
using DBS25P131.DataAccessLayer;

namespace DBS25P131.DataAccessLayer
{

    public class FacultyDAL
    {
        public List<Faculty> GetAllFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            string query = "SELECT faculty_id, name, email, contact, research_area, total_teaching_hours FROM faculty";

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
                            ResearchArea = reader["research_area"].ToString(),
                            TotalTeachingHours = Convert.ToInt32(reader["total_teaching_hours"])
                        });
                    }
                }
                return faculties;
            }
        }

        public bool InsertFaculty(Faculty faculty)
        {
            string query = @"INSERT INTO faculty (name, email, contact, research_area, total_teaching_hours) 
                             VALUES (@name, @email, @contact, @research_area, @total_teaching_hours)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", faculty.Name);
                command.Parameters.AddWithValue("@email", faculty.Email);
                command.Parameters.AddWithValue("@contact", faculty.Contact);
                command.Parameters.AddWithValue("@research_area", faculty.ResearchArea);
                command.Parameters.AddWithValue("@total_teaching_hours", faculty.TotalTeachingHours);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            string query = @"UPDATE faculty SET name = @name, email = @email, contact = @contact, 
                             research_area = @research_area, total_teaching_hours = @total_teaching_hours 
                             WHERE faculty_id = @faculty_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", faculty.Name);
                command.Parameters.AddWithValue("@email", faculty.Email);
                command.Parameters.AddWithValue("@contact", faculty.Contact);
                command.Parameters.AddWithValue("@research_area", faculty.ResearchArea);
                command.Parameters.AddWithValue("@total_teaching_hours", faculty.TotalTeachingHours);
                command.Parameters.AddWithValue("@faculty_id", faculty.FacultyId);

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
                command.Parameters.AddWithValue("@faculty_id", facultyId);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
    
