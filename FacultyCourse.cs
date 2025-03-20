using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class FacultyCourse
    {
        public int FacultyCourseId { get; set; }
        public Faculty Faculty { get; set; }
        public Course Course { get; set; }
        public Semester Semester { get; set; }

        public FacultyCourse()
        {
            Faculty = new Faculty();
            Course = new Course();
            Semester = new Semester();
        }
    }

}
