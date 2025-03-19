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
    public partial class AssignCourse : Form
    {
        public string courseName;
        public string courseType;
        public int facultyId;
        public string facultyName;
        public int creditHours;
        public int contactHours;

        public AssignCourse()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cname_TextChanged(object sender, EventArgs e)
        {
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Ctype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            private void button_Approve_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = Cname.Text;
                string courseType = Ctype.SelectedItem.ToString();
                int facultyId = Convert.ToInt32(fId.Text);
                string facultyName = fName.Text;
                int creditHours = Convert.ToInt32(cHours.Text);
                int contactHours = Convert.ToInt32(Contacthours.Text);

                bool isAssigned = courseManager.AssignCourse(courseName, courseType, facultyId, facultyName, creditHours, contactHours);

                if (isAssigned)
                {
                    MessageBox.Show("Course assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = courseManager.GetAllCourses(); // Refresh the table
                }
                else
                {
                    MessageBox.Show("Failed to assign course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
}
