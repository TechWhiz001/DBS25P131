using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

namespace DBS25P131.Data_Acess_layer
{

   

        public class Courses

        {
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public string Course_Type { get; set; }
        public int Credit_Hours { get; set; }
        public int Contact_Hours { get; set; }

        public Courses(int courseId, string coursename, string coursetype, int credithours, int contacthours)
        {
            Course_ID = courseId;
            Course_Name = coursename;
            Course_Type = coursetype;
            Credit_Hours = credithours;
            Contact_Hours = contacthours;

        }

        public void AddCourses()
        {
            string query = $"INSERT INTO Courses VALUES ( '{Course_Name}', '{Course_Type}','{Credit_Hours}','{Contact_Hours}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditCourses()
        {
            string query = $"UPDATE Courses SET Course_Name = '{Course_Name}',Course_Type = '{Course_Type}', Credit_Hours = '{Credit_Hours}', Contact_Hours = '{Contact_Hours}' WHERE Course_ID = '{Course_ID}'";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteCourses()
        {
            string query = $"DELETE FROM Courses WHERE Course_ID = '{Course_ID}'";
            DatabaseHelper.Instance.Update(query);
        }
         
    }
}
