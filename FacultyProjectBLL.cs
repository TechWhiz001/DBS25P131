using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class FacultyProjectBLL
    {
        private FacultyProjectDAL facultyProjectDAL = new FacultyProjectDAL();

        
        public bool AddFacultyProject(FacultyProject facultyProject)
        {
            return facultyProjectDAL.InsertFacultyProject(facultyProject);
        }

        public List<FacultyProject> GetAllFacultyProjects()
        {
            return facultyProjectDAL.GetAllFacultyProjects();
        }

        public bool updateFacultyProject(int fpid, int fid, int pid, int sid, int shours)
        {
            return facultyProjectDAL.UpdateFacultyProject(fpid,fid,pid,sid,shours);
        }

        public bool RemoveFacultyProject(int facultyProjectId)
        {
            return facultyProjectDAL.DeleteFacultyProject(facultyProjectId);
        }


        public bool insertFacultyProject(int f, int p, int s, int h)
        {
            return facultyProjectDAL.InsertFacultyProject(f, s, p, h);
        }
    }
}
