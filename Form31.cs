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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        private static Administrator instance;

        private void adminFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadForm(Form form)
        {

            adminFormPanel.Controls.Clear();


            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            adminFormPanel.Controls.Add(form);
            form.Show();
        }

        private void FacultyProfiles_Click(object sender, EventArgs e)
        {
            LoadForm(new UserProfiles());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminAssignCourse());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new Process_faculty_requests()); 
        }

        public static Administrator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Administrator();
                }
                return instance;
            }
        }
    }
}
