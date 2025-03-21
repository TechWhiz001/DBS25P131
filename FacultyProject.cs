using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class FacultyProject
    {
        public int FacultyProjectId { get; set; }
        public Faculty Faculty { get; set; }
        public Project Project { get; set; }
        public Semester Semester { get; set; }
        public int SupervisionHours { get; set; }

        // Constructor to initialize objects
        public FacultyProject(int facultyProjectId, Faculty faculty, Project project, Semester semester, int supervisionHours)
        {
            FacultyProjectId = facultyProjectId;
            Faculty = faculty;
            Project = project;
            Semester = semester;
            SupervisionHours = supervisionHours;
        }

        // Parameterless constructor
        public FacultyProject()
        {
            Faculty = new Faculty();
            Project = new Project();
            Semester = new Semester();
        }
    }

}
