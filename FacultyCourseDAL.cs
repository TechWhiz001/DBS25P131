using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    public class FacultyCourseDAL
    {
        public List<FacultyCourse> GetAllFacultyCourses()
        {
            List<FacultyCourse> facultyCourses = new List<FacultyCourse>();
            string query = @"
            SELECT fc.faculty_course_id, 
                   f.faculty_id, f.name AS faculty_name, 
                   c.course_id, c.course_name, 
                   s.semester_id, s.term, s.year
            FROM faculty_courses fc
            LEFT JOIN faculty f ON fc.faculty_id = f.faculty_id
            LEFT JOIN courses c ON fc.course_id = c.course_id
            LEFT JOIN semester s ON fc.semester_id = s.semester_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    facultyCourses.Add(new FacultyCourse
                    {
                        FacultyCourseId = Convert.ToInt32(reader["faculty_course_id"]),
                        Faculty = new Faculty
                        {
                            FacultyId = Convert.ToInt32(reader["faculty_id"]),
                            Name = reader["faculty_name"].ToString()
                        },
                        Course = new Course
                        {
                            CourseId = Convert.ToInt32(reader["course_id"]),
                            CourseName = reader["course_name"].ToString()
                        },
                        Semester = new Semester
                        {
                            SemesterId = Convert.ToInt32(reader["semester_id"]),
                            Term = reader["term"].ToString(),
                            Year = Convert.ToInt32(reader["year"])
                        }
                    });
                }
            }
            return facultyCourses;
        }

        public bool InsertFacultyCourse(FacultyCourse facultyCourse)
        {
            string query = @"INSERT INTO faculty_courses (faculty_id, course_id, semester_id)
                             VALUES (@faculty_id, @course_id, @semester_id)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@faculty_id", facultyCourse.Faculty.FacultyId);
                command.Parameters.AddWithValue("@course_id", facultyCourse.Course.CourseId);
                command.Parameters.AddWithValue("@semester_id", facultyCourse.Semester.SemesterId);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateFacultyCourse(FacultyCourse facultyCourse)
        {
            string query = @"UPDATE faculty_courses 
                             SET faculty_id = @faculty_id, course_id = @course_id, semester_id = @semester_id
                             WHERE faculty_course_id = @faculty_course_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@faculty_id", facultyCourse.Faculty.FacultyId);
                command.Parameters.AddWithValue("@course_id", facultyCourse.Course.CourseId);
                command.Parameters.AddWithValue("@semester_id", facultyCourse.Semester.SemesterId);
                command.Parameters.AddWithValue("@faculty_course_id", facultyCourse.FacultyCourseId);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteFacultyCourse(int facultyCourseId)
        {
            string query = "DELETE FROM faculty_courses WHERE faculty_course_id = @faculty_course_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@faculty_course_id", facultyCourseId);
                return command.ExecuteNonQuery() > 0;
            }
        }

        // NEW FUNCTION: Check if the course is assigned to a faculty in a given semester
        public bool IsFacultyCourseAssigned(int courseId, int facultyId, int semesterId)
        {
            string query = @"SELECT COUNT(*) FROM faculty_courses 
                     WHERE course_id = @course_id 
                     AND faculty_id = @faculty_id 
                     AND semester_id = @semester_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open(); // Open connection before executing query

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@course_id", courseId);
                    command.Parameters.AddWithValue("@faculty_id", facultyId);
                    command.Parameters.AddWithValue("@semester_id", semesterId);

                    object result = command.ExecuteScalar();

                    // Ensure result is valid before converting
                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        return count > 0; // True if already assigned, False otherwise
                    }

                    return false;
                }
            }
        }

    }
}
