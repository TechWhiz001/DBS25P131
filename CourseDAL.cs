using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    public class CourseDAL
    {
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            string query = "SELECT course_id, course_name, course_type, credit_hours, contact_hours FROM courses";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open(); 
                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            CourseId = Convert.ToInt32(reader["course_id"]),
                            CourseName = reader["course_name"].ToString(),
                            CourseType = reader["course_type"].ToString(), 
                            CreditHours = Convert.ToInt32(reader["credit_hours"]),
                            ContactHours = Convert.ToInt32(reader["contact_hours"])
                        });
                    }
                }
            }
            return courses;
        }
        public List<Course> GetUnassignedCourses()
        {
            List<Course> unassignedCourses = new List<Course>();
            string query = @"
        SELECT c.course_id, c.course_name, c.course_type
        FROM courses c
        LEFT JOIN faculty_courses fc ON c.course_id = fc.course_id
        WHERE fc.course_id IS NULL"; 

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        unassignedCourses.Add(new Course
                        {
                            CourseId = Convert.ToInt32(reader["course_id"]),
                            CourseName = reader["course_name"].ToString(),
                            CourseType = reader["course_type"].ToString()
                        });
                    }
                }
            }
            return unassignedCourses;
        }
        public List<Course> GetAssignedCoursesByUserId(int userId)
        {
            List<Course> assignedCourses = new List<Course>();
            string query = @"
    SELECT c.course_id, c.course_name, c.course_type, c.credit_hours, c.contact_hours
    FROM users u
    JOIN faculty f ON u.user_id = f.user_id
    JOIN faculty_courses fc ON f.faculty_id = fc.faculty_id
    JOIN courses c ON fc.course_id = c.course_id
    WHERE u.user_id = @UserId;";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        assignedCourses.Add(new Course
                        {
                            CourseId = Convert.ToInt32(reader["course_id"]),
                            CourseName = reader["course_name"].ToString(),
                            CourseType = reader["course_type"].ToString(),
                            CreditHours = Convert.ToInt32(reader["credit_hours"]),
                            ContactHours = Convert.ToInt32(reader["contact_hours"])
                        });
                    }
                }
            }
            return assignedCourses;
        }


        public bool InsertCourse(Course course)
        {
            string query = "INSERT INTO courses (course_name, course_type, credit_hours, contact_hours) " +
                           "VALUES (@course_name, @course_type, @credit_hours, @contact_hours)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@course_name", course.CourseName);
                    command.Parameters.AddWithValue("@course_type", course.CourseType);
                    command.Parameters.AddWithValue("@credit_hours", course.CreditHours);
                    command.Parameters.AddWithValue("@contact_hours", course.ContactHours);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCourse(Course course)
        {
            string query = "UPDATE courses SET course_name = @course_name, course_type = @course_type, " +
                           "credit_hours = @credit_hours, contact_hours = @contact_hours WHERE course_id = @course_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open(); 
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@course_name", course.CourseName);
                    command.Parameters.AddWithValue("@course_type", course.CourseType); 
                    command.Parameters.AddWithValue("@credit_hours", course.CreditHours);
                    command.Parameters.AddWithValue("@contact_hours", course.ContactHours);
                    command.Parameters.AddWithValue("@course_id", course.CourseId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteCourse(int courseId)
        {
            string query = "DELETE FROM courses WHERE course_id = @course_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open(); 
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@course_id", courseId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
