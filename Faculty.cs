using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

namespace DBS25P131.Data_Acess_layer
{
    public class Faculty

    {

        public int faculty_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string designation_id { get; set; }
        public string research_area { get; set; }
        public int total_teaching_hours { get; set; }
        public int user_id { get; set; }
        public Faculty(int faculty_id, string name, string email, string contact, string designation_id,string research_area,int total_teaching_hours,int user_id)
        {
           this.faculty_id = faculty_id;
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.designation_id = designation_id;
            this.research_area = research_area;
            this.total_teaching_hours = total_teaching_hours;
            this.user_id = user_id;
        }

        public void AddFaculty()
        {
            string query = $"INSERT INTO Faculty VALUES ( '{name}', '{email}','{contact}','{designation_id}','{research_area}', '{total_teaching_hours}','{user_id}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditFaculty()
        {
            string query = $"UPDATE Faculty SET name = '{name}',email = '{email}', contact = '{contact}', designation_id = '{designation_id}',research_area = '{research_area}', total_teaching_hours = '{total_teaching_hours}', user_id = '{user_id}'  WHERE Course_ID = '{faculty_id}'";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteFaculty()
        {
            string query = $"DELETE FROM Faculty WHERE Course_ID = '{faculty_id}'";
            DatabaseHelper.Instance.Update(query);
        }
        
    }
}
