using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P131
{
    public partial class AdminAssignCourse : Form
    {
        public AdminAssignCourse()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LoadForm(new ViewAssignedCourses());
        }
        private void LoadForm(Form form)
        {

            CoursesPanel.Controls.Clear();


            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            CoursesPanel.Controls.Add(form);
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomAllocationForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadForm(new faculty_course_schedule()); 
        }
    }
}
