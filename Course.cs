using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }  
        public int CreditHours { get; set; }
        public int ContactHours { get; set; }

        public Course() { }

        public Course(int courseId, string courseName, string courseType, int creditHours, int contactHours)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseType = courseType;
            CreditHours = creditHours;
            ContactHours = contactHours;
        }
    }
}
