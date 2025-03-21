using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBS25P131.Business_Logic_Layer;
using DBS25P131.Models;

namespace DBS25P131
{
    public partial class AprrovedCourse : Form
    {
        private CourseBLL courseBll;
        private int selectedCourseId = 0;

        public AprrovedCourse()
        {
            InitializeComponent();
            courseBll = new CourseBLL();
        }

        private void AprrovedCourse_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadCourses();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("CourseId", "Course ID");
            dataGridView1.Columns.Add("CourseName", "Course Name");
            dataGridView1.Columns.Add("CourseType", "Course Type");
            dataGridView1.Columns.Add("CreditHours", "Credit Hours");
            dataGridView1.Columns.Add("ContactHours", "Contact Hours");


            DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn
            {
                Name = "UpdateButton",
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(updateButton);


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButton);
        }

        private void LoadCourses()
        {
            dataGridView1.Rows.Clear();
            List<Course> courses = courseBll.GetAllCourses();

            foreach (var course in courses)
            {
                dataGridView1.Rows.Add(course.CourseId, course.CourseName, course.CourseType,
                                       course.CreditHours, course.ContactHours);
            }
        }

        private void AAddbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = acname.Text;
                string courseType = acomboboxtype.SelectedItem?.ToString();
                int creditHours = int.Parse(achours.Text);
                int contactHours = int.Parse(acontacthours.Text);

                Course newCourse = new Course
                {
                    CourseName = courseName,
                    CourseType = courseType,
                    CreditHours = creditHours,
                    ContactHours = contactHours
                };

                if (selectedCourseId == 0)
                {
                    courseBll.AddCourse(newCourse);
                    MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    newCourse.CourseId = selectedCourseId;
                    courseBll.UpdateCourse(newCourse);
                    MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedCourseId = 0;
                }

                ClearFields();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int courseId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                if (e.ColumnIndex == dataGridView1.Columns["UpdateButton"].Index)
                {
                    selectedCourseId = courseId;
                    acname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    acomboboxtype.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    achours.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    acontacthours.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        courseBll.DeleteCourse(courseId);
                        MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCourses();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            acname.Text = "";
            acomboboxtype.SelectedIndex = -1;
            achours.Text = "";
            acontacthours.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
