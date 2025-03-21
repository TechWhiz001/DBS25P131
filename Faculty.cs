using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public Lookup Designation { get; set; } 
        public string ResearchArea { get; set; }
        public int TotalTeachingHours { get; set; }
        public User User { get; set; }  

        public Faculty() { }

        public Faculty(int facultyId, string name, string email, string contact, Lookup designation, string researchArea, int totalTeachingHours, User user)
        {
            FacultyId = facultyId;
            Name = name;
            Email = email;
            Contact = contact;
            Designation = designation;
            ResearchArea = researchArea;
            TotalTeachingHours = totalTeachingHours;
            User = user;
        }
    }
}
