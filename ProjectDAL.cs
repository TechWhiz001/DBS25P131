﻿using System;
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
            {
                connection.Open();  // Ensure the connection is open before executing
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
            }
            return projects;
        }

        public List<Project> GetUnassignedProjects()
        {
            List<Project> unassignedProjects = new List<Project>();
            string query = "SELECT p.project_id, p.title " +
                           "FROM Projects p " +
                           "LEFT JOIN faculty_projects fp ON p.project_id = fp.project_id " +
                           "WHERE fp.project_id IS NULL"; 

            using (var connection = DatabaseHelper.Instance.GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Project project = new Project
                        {
                            ProjectId = reader.GetInt32(0),
                            Title = reader.GetString(1)
                        };
                        unassignedProjects.Add(project);
                    }
                }
            }
            return unassignedProjects;
        }
        public bool InsertProject(string title,string des)
        {
            string query = "INSERT INTO projects (title, description) VALUES (@title, @description)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@description", des);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateProject(int id ,string title, string des)
        {
            string query = "UPDATE projects SET title = @title, description = @description WHERE project_id = @project_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@description",des);
                    command.Parameters.AddWithValue("@project_id", id);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteProject(int projectId)
        {
            string query = "DELETE FROM projects WHERE project_id = @project_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@project_id", projectId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
