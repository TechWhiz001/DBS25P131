using System;
using System.Collections.Generic;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class FacultyBLL
    {
        private readonly FacultyDAL facultyDal;

        public FacultyBLL()
        {
            facultyDal = new FacultyDAL();
        }

        public List<Faculty> GetAllFaculties()
        {
            return facultyDal.GetAllFaculties();
        }

        public bool InsertFaculty(string name, string email, int designationId, string contact, string researchArea, int totalHours,int user_id)
        {
            return facultyDal.InsertFaculty(name, email, designationId, contact, researchArea, totalHours,user_id);
        }

        public bool UpdateFaculty(int id ,string name, string email, int designationId, string contact, string researchArea, int totalHours, int user_id)
        {
            return facultyDal.UpdateFaculty(id, name, email, designationId, contact, researchArea, totalHours, user_id);
        }

        public bool DeleteFaculty(int facultyId)
        {
            return facultyDal.DeleteFaculty(facultyId);
        }
    }
}
