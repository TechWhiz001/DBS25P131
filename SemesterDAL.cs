using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.Data_Acess_layer
{
    public class SemesterDAL
    {
        // Method to Insert a New Semester
        public bool InsertSemester(Semester semester)
        {
            try
            {
                string query = "INSERT INTO semesters (term, year) VALUES (@term, @year)";
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@term", semester.Term);
                        command.Parameters.AddWithValue("@year", semester.Year);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting semester: {ex.Message}");
                return false;
            }
        }

        // Method to Retrieve All Semesters
        public List<Semester> GetAllSemesters()
        {
            List<Semester> semesters = new List<Semester>();
            string query = "SELECT semester_id, term, year FROM semesters";

            try
            {
                using (var reader = DatabaseHelper.Instance.GetData(query))
                {
                    while (reader.Read())
                    {
                        semesters.Add(new Semester
                        {
                            SemesterId = reader.GetInt32("semester_id"),
                            Term = reader.GetString("term"),
                            Year = reader.GetInt32("year")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving semesters: {ex.Message}");
            }

            return semesters;
        }

        // Method to Retrieve a Semester by ID
        public Semester GetSemesterById(int id)
        {
            string query = "SELECT semester_id, term, year FROM semesters WHERE semester_id = @id";

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Semester
                                {
                                    SemesterId = reader.GetInt32("semester_id"),
                                    Term = reader.GetString("term"),
                                    Year = reader.GetInt32("year")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving semester by ID: {ex.Message}");
            }

            return null;  // Return null if not found
        }

        // Method to Update an Existing Semester
        public bool UpdateSemester(Semester semester)
        {
            try
            {
                string query = "UPDATE semesters SET term = @term, year = @year WHERE semester_id = @id";
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@term", semester.Term);
                        command.Parameters.AddWithValue("@year", semester.Year);
                        command.Parameters.AddWithValue("@id", semester.SemesterId);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating semester: {ex.Message}");
                return false;
            }
        }

        // Method to Delete a Semester by ID
        public bool DeleteSemester(int id)
        {
            try
            {
                string query = "DELETE FROM semesters WHERE semester_id = @id";
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting semester: {ex.Message}");
                return false;
            }
        }
    }
}
