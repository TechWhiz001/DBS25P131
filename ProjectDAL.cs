using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;
using MySql.Data.MySqlClient;

namespace DBS25P131.DataAccessLayer
{
    public class ProjectDAL
    {
        public List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();
            string query = "SELECT project_id, title, description FROM projects";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    projects.Add(new Project
                    {
                        ProjectId = Convert.ToInt32(reader["project_id"]),
                        Title = reader["title"].ToString(),
                        Description = reader["description"] != DBNull.Value ? reader["description"].ToString() : null
                    });
                }
            }
            return projects;
        }

        public bool InsertProject(Project project)
        {
            string query = "INSERT INTO projects (title, description) VALUES (@title, @description)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", project.Title);
                command.Parameters.AddWithValue("@description", project.Description ?? (object)DBNull.Value);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateProject(Project project)
        {
            string query = "UPDATE projects SET title = @title, description = @description WHERE project_id = @project_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", project.Title);
                command.Parameters.AddWithValue("@description", project.Description ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@project_id", project.ProjectId);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteProject(int projectId)
        {
            string query = "DELETE FROM projects WHERE project_id = @project_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@project_id", projectId);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
