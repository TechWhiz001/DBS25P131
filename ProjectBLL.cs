using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class ProjectBLL
    {
        private readonly ProjectDAL projectDAL;

        public ProjectBLL()
        {
            projectDAL = new ProjectDAL();
        }

        public List<Project> GetAllProjects()
        {
            return projectDAL.GetAllProjects();
        }

        public bool AddProject(Project project)
        {
            if (project == null || string.IsNullOrWhiteSpace(project.Title))
            {
                throw new ArgumentException("Invalid project data.");
            }
            return projectDAL.InsertProject(project);
        }
        // Get all unassigned projects
        public List<Project> GetUnassignedProjects()
        {
            return projectDAL.GetUnassignedProjects();
        }
        public bool UpdateProject(Project project)
        {
            if (project == null || project.ProjectId <= 0 || string.IsNullOrWhiteSpace(project.Title))
            {
                throw new ArgumentException("Invalid project data.");
            }
            return projectDAL.UpdateProject(project);
        }

        public bool DeleteProject(int projectId)
        {
            if (projectId <= 0)
            {
                throw new ArgumentException("Invalid project ID.");
            }
            return projectDAL.DeleteProject(projectId);
        }
    }
}
