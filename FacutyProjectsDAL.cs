
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    public class FacultyProjectDAL
    {
        private readonly string connectionString = "your_connection_string_here";

        // Insert FacultyProject
        public bool InsertFacultyProject(FacultyProject facultyProject)
        {
            string query = "INSERT INTO faculty_projects (faculty_id, project_id, semester_id, supervision_hours) " +
                           "VALUES (@FacultyId, @ProjectId, @SemesterId, @SupervisionHours)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FacultyId", facultyProject.Faculty.FacultyId);
                command.Parameters.AddWithValue("@ProjectId", facultyProject.Project.ProjectId);
                command.Parameters.AddWithValue("@SemesterId", facultyProject.Semester.SemesterId);
                command.Parameters.AddWithValue("@SupervisionHours", facultyProject.SupervisionHours);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public List<FacultyProject> GetAllFacultyProjects()
        {
            List<FacultyProject> facultyProjects = new List<FacultyProject>();
            string query = "SELECT fp.faculty_project_id, f.faculty_id, f.name, p.project_id, p.title, " +
                           "s.semester_id, s.term, s.year, fp.supervision_hours " +
                           "FROM faculty_projects fp " +
                           "JOIN faculty f ON fp.faculty_id = f.faculty_id " +
                           "JOIN projects p ON fp.project_id = p.project_id " +
                           "JOIN semesters s ON fp.semester_id = s.semester_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Faculty faculty = new Faculty
                        {
                            FacultyId = reader.GetInt32(1),
                            Name = reader.GetString(2)
                        };

                        Project project = new Project
                        {
                            ProjectId = reader.GetInt32(3),
                            Title = reader.GetString(4)
                        };

                        Semester semester = new Semester
                        {
                            SemesterId = reader.GetInt32(5),
                            Term = reader.GetString(6),
                            Year = reader.GetInt32(7)
                        };

                        FacultyProject facultyProject = new FacultyProject(
                            reader.GetInt32(0), faculty, project, semester, reader.GetInt32(8)
                        );

                        facultyProjects.Add(facultyProject);
                    }
                }
            }
            return facultyProjects;
        }

        // Update FacultyProject
        public bool UpdateFacultyProject(int FacultyProjectId, int facultyId, int projectId, int semesterId, int reservedHours)
        {
            string query = "UPDATE faculty_projects SET faculty_id = @FacultyId, project_id = @ProjectId, " +
                           "semester_id = @SemesterId, supervision_hours = @SupervisionHours " +
                           "WHERE faculty_project_id = @FacultyProjectId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            { 
                command.Parameters.AddWithValue("@FacultyProjectId", FacultyProjectId);
                command.Parameters.AddWithValue("@FacultyId", facultyId);
                command.Parameters.AddWithValue("@ProjectId", projectId);
                command.Parameters.AddWithValue("@SemesterId", semesterId);
                command.Parameters.AddWithValue("@SupervisionHours", reservedHours);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteFacultyProject(int facultyProjectId)
        {
            string query = "DELETE FROM faculty_projects WHERE faculty_project_id = @FacultyProjectId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FacultyProjectId", facultyProjectId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        

        public bool InsertFacultyProject( int facultyId, int projectId, int semesterId, int reservedHours)
        {
            string query = "INSERT INTO faculty_projects (faculty_id, project_id, semester_id, supervision_hours) " +
                           "VALUES (@FacultyId, @ProjectId, @SemesterId, @SupervisionHours)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FacultyId", facultyId);
                command.Parameters.AddWithValue("@ProjectId", projectId);
                command.Parameters.AddWithValue("@SemesterId", semesterId);
                command.Parameters.AddWithValue("@SupervisionHours", reservedHours);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public bool ExistsAssignment(int facultyId, int projectId, int semesterId)
        {
            string query = @"SELECT COUNT(*) FROM faculty_projects
                     WHERE faculty_id = @FacultyId 
                       AND project_id = @ProjectId 
                       AND semester_id = @SemesterId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FacultyId", facultyId);
                command.Parameters.AddWithValue("@ProjectId", projectId);
                command.Parameters.AddWithValue("@SemesterId", semesterId);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

    }

}
