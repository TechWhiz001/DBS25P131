using System;
using System.Collections.Generic;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class FacultyCourseBLL
    {
        private readonly FacultyCourseDAL _facultyCourseDAL;

        public FacultyCourseBLL()
        {
            _facultyCourseDAL = new FacultyCourseDAL();
        }

        public List<FacultyCourse> GetAllFacultyCourses()
        {
            return _facultyCourseDAL.GetAllFacultyCourses();
        }

        public bool AddFacultyCourse(FacultyCourse facultyCourse)
        {
            if (facultyCourse == null ||
                facultyCourse.Faculty == null || facultyCourse.Faculty.FacultyId <= 0 ||
                facultyCourse.Course == null || facultyCourse.Course.CourseId <= 0 ||
                facultyCourse.Semester == null || facultyCourse.Semester.SemesterId <= 0)
            {
                throw new ArgumentException("Invalid faculty course data.");
            }
            return _facultyCourseDAL.InsertFacultyCourse(facultyCourse);
        }

        public bool UpdateFacultyCourse(FacultyCourse facultyCourse)
        {
            if (facultyCourse == null || facultyCourse.FacultyCourseId <= 0 ||
                facultyCourse.Faculty == null || facultyCourse.Faculty.FacultyId <= 0 ||
                facultyCourse.Course == null || facultyCourse.Course.CourseId <= 0 ||
                facultyCourse.Semester == null || facultyCourse.Semester.SemesterId <= 0)
            {
                throw new ArgumentException("Invalid faculty course data.");
            }
            return _facultyCourseDAL.UpdateFacultyCourse(facultyCourse);
        }

        public bool DeleteFacultyCourse(int facultyCourseId)
        {
            if (facultyCourseId <= 0)
            {
                throw new ArgumentException("Invalid faculty course ID.");
            }
            return _facultyCourseDAL.DeleteFacultyCourse(facultyCourseId);
        }

        public bool AssignCourseToFaculty(int courseId, int facultyId, int semesterId)
        {
            if (courseId <= 0 || facultyId <= 0 || semesterId <= 0)
            {
                throw new ArgumentException("Invalid course ID, faculty ID, or semester ID.");
            }
            return _facultyCourseDAL.IsFacultyCourseAssigned(courseId, facultyId, semesterId);
        }
    }
}
