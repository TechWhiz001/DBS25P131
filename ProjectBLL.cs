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

        public bool AddProject(string title,string description)
        {
            return projectDAL.InsertProject(title,description);
        }
        public List<Project> GetUnassignedProjects()
        {
            return projectDAL.GetUnassignedProjects();
        }
        public bool UpdateProject(int id, string title, string des)
        {
            
            return projectDAL.UpdateProject(id,title,des);
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
