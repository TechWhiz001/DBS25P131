using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.DataAccessLayer
{
   public  class FacultyAdminRoles
    {
        public int admin_role_id { get; set; }
        public int faculty_id { get; set; }
        public string role_name { get; set; }
        public int semester_id { get; set; }

        public FacultyAdminRoles(int admin_role_id, int faculty_id, string role_name, int semester_id)
        {
            this.admin_role_id = admin_role_id;
            this.faculty_id = faculty_id;
            this.role_name = role_name;
            this.semester_id = semester_id;
            


        }

        public void addFacultyAdminRoles()
        {
            string query = $"INSERT INTO Courses VALUES ('{faculty_id}', '{role_name}', '{semester_id}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void editFacultyAdminRoles()
        {
            string query = $"UPDATE Courses SET faculty_id = '{faculty_id}',role_name = '{role_name}', semester_id = '{semester_id}' WHERE Course_ID = '{admin_role_id}'";
            DatabaseHelper.Instance.Update(query);
        }
        public void deletFacultyAdminRoles()
        {
            string query = $"DELETE FROM Courses WHERE Course_ID = '{admin_role_id}'";
            DatabaseHelper.Instance.Update(query);
        }

    }
}
