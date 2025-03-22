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
            string query = "SELECT semester_id, term, year FROM semesters";

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
                            semesters.Add(new Semester
                            {
                                SemesterId = Convert.ToInt32(reader["semester_id"]),
                                Term = reader["term"].ToString(),
                                Year = Convert.ToInt32(reader["year"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching semesters: " + ex.Message);
            }
            return semesters;
        }

        public bool InsertSemester(string term, int y)
        {
            string query = "INSERT INTO semesters (term, year) VALUES (@term, @year)";
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@term", term);
                    command.Parameters.AddWithValue("@year", y);

                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting semester: " + ex.Message);
                return false;
            }
        }

        public bool UpdateSemester(int id, string term,int year )
        {
            string query = "UPDATE semesters SET term = @term, year = @year WHERE semester_id = @semester_id";

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@term", term);
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@semester_id", id);

                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating semester: " + ex.Message);
                return false;
            }
        }

        public bool DeleteSemester(int semesterId)
        {
            string query = "DELETE FROM semesters WHERE semester_id = @semester_id";
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                using (var command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@semester_id", semesterId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting semester: " + ex.Message);
                return false;
            }
        }

        public int GetSemesterId(string term, int year)
        {
            string query = "SELECT semester_id FROM semesters WHERE term = @term AND year = @year";

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    if (connection == null)
                        throw new Exception("Database connection is null. Check your database connection settings.");

                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@term", term);
                        command.Parameters.AddWithValue("@year", year);

                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching semester ID: " + ex.Message);
                return -1;
            }
        }
    }
}
