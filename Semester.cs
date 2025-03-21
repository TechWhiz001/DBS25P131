using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string Term { get; set; } 
        public int Year { get; set; }

        public Semester() { }

        public Semester(int semesterId, string term, int year)
        {
            SemesterId = semesterId;
            Term = term;
            Year = year;
        }
    }
}
