using System;
using System.Collections.Generic;
using DBS25P131.Models;
using DBS25P131.DataAccessLayer;

namespace DBS25P131.Business_Logic_Layer
{
    public class CourseBLL
    {
        private readonly CourseDAL _courseDal;

        public CourseBLL()
        {
            _courseDal = new CourseDAL();
        }

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAllCourses();
        }

        public bool AddCourse(Course course)
        {
            if (string.IsNullOrWhiteSpace(course.CourseName))
                throw new ArgumentException("Course name is required.");

            if (course.CreditHours <= 0)
                throw new ArgumentException("Credit hours must be greater than 0.");

            return _courseDal.InsertCourse(course);
        }

        public bool UpdateCourse(Course course)
        {
            if (course.CourseId <= 0)
                throw new ArgumentException("Invalid Course ID.");

            if (string.IsNullOrWhiteSpace(course.CourseName))
                throw new ArgumentException("Course name is required.");

            return _courseDal.UpdateCourse(course);
        }

        public bool DeleteCourse(int courseId)
        {
            if (courseId <= 0)
                throw new ArgumentException("Invalid Course ID.");

            return _courseDal.DeleteCourse(courseId);
        }

        // NEW FUNCTION: Get unassigned courses based on faculty research area
        public List<Course> GetUnassignedCourses()
        {
            return _courseDal.GetUnassignedCourses();
        }
    }
}
