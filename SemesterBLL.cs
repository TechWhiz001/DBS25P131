using DBS25P131.DataAccessLayer;
using DBS25P131.Models;
using System;
using System.Collections.Generic;

namespace DBS25P131.BusinessLayer
{
    public class SemesterBLL
    {
        private readonly SemesterDAL semesterDAL;

        public SemesterBLL()
        {
            semesterDAL = new SemesterDAL();
        }

        public List<Semester> GetAllSemesters()
        {
            return semesterDAL.GetAllSemesters();
        }

        public bool AddSemester(Semester semester)
        {
            if (semester == null || string.IsNullOrWhiteSpace(semester.Term) || semester.Year <= 0)
            {
                throw new ArgumentException("Invalid semester data.");
            }
            return semesterDAL.InsertSemester(semester);
        }

        public bool UpdateSemester(Semester semester)
        {
            if (semester == null || semester.SemesterId <= 0 || string.IsNullOrWhiteSpace(semester.Term) || semester.Year <= 0)
            {
                throw new ArgumentException("Invalid semester data.");
            }
            return semesterDAL.UpdateSemester(semester);
        }

        public bool DeleteSemester(int semesterId)
        {
            if (semesterId <= 0)
            {
                throw new ArgumentException("Invalid semester ID.");
            }
            return semesterDAL.DeleteSemester(semesterId);
        }

        // NEW FUNCTION: Get Semester ID by Term and Year
        public int GetSemesterIdByTermAndYear(string term, int year)
        {
            if (string.IsNullOrWhiteSpace(term) || year <= 0)
            {
                throw new ArgumentException("Term and year must be valid.");
            }
            return semesterDAL.GetSemesterId(term, year);
        }
    }
}
