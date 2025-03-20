using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    public class SemesterDAL
    {
        public List<Semester> GetAllSemesters()
        {
            List<Semester> semesters = new List<Semester>();
            string query = "SELECT semester_id, term, year FROM semester";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    semesters.Add(new Semester
                    {
                        SemesterId = Convert.ToInt32(reader["semester_id"]),
                        Term = reader["term"].ToString(),
                        Year = Convert.ToInt32(reader["year"])
                    });
                }
            }
            return semesters;
        }

        public bool InsertSemester(Semester semester)
        {
            string query = "INSERT INTO semester (term, year) VALUES (@term, @year)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@term", semester.Term);
                command.Parameters.AddWithValue("@year", semester.Year);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateSemester(Semester semester)
        {
            string query = "UPDATE semester SET term = @term, year = @year WHERE semester_id = @semester_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@term", semester.Term);
                command.Parameters.AddWithValue("@year", semester.Year);
                command.Parameters.AddWithValue("@semester_id", semester.SemesterId);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSemester(int semesterId)
        {
            string query = "DELETE FROM semester WHERE semester_id = @semester_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@semester_id", semesterId);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
