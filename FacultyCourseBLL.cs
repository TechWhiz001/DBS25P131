using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
