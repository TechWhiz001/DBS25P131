using System;
using System.Collections.Generic;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class FacultyBLL
    {
        private readonly FacultyDAL _facultyDal;

        public FacultyBLL()
        {
            _facultyDal = new FacultyDAL();
        }

        public List<Faculty> GetAllFaculties()
        {
            return _facultyDal.GetAllFaculties();
        }

        public bool AddFaculty(Faculty faculty)
        {
            if (string.IsNullOrWhiteSpace(faculty.Name))
                throw new ArgumentException("Faculty name is required.");

            if (string.IsNullOrWhiteSpace(faculty.Email))
                throw new ArgumentException("Faculty email is required.");

            if (!faculty.Email.Contains("@"))
                throw new ArgumentException("Invalid email format.");

            return _facultyDal.InsertFaculty(faculty);
        }

        public bool UpdateFaculty(Faculty faculty)
        {
            if (faculty.FacultyId <= 0)
                throw new ArgumentException("Invalid Faculty ID.");

            if (string.IsNullOrWhiteSpace(faculty.Name))
                throw new ArgumentException("Faculty name is required.");

            return _facultyDal.UpdateFaculty(faculty);
        }

        public bool DeleteFaculty(int facultyId)
        {
            if (facultyId <= 0)
                throw new ArgumentException("Invalid Faculty ID.");

            return _facultyDal.DeleteFaculty(facultyId);
        }
    }
}
