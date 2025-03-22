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

        public bool AddSemester( string term, int year)
        {
            
            return semesterDAL.InsertSemester( term,year);
        }

        public bool UpdateSemester(int id, string term,int y)
        {
            
            return semesterDAL.UpdateSemester(id, term,y);
        }

        public bool DeleteSemester(int semesterId)
        {
            if (semesterId <= 0)
            {
                throw new ArgumentException("Invalid semester ID.");
            }
            return semesterDAL.DeleteSemester(semesterId);
        }

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
