using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P131
{
    public partial class AssignCourses : Form
    {
        private static AssignCourses instance;
        private FacultyDAL facultyDAL = new FacultyDAL();
        private CourseDAL courseDAL = new CourseDAL();
        private SemesterDAL semesterDAL = new SemesterDAL();
        private FacultyCourseDAL facultyCourseDAL = new FacultyCourseDAL();
        private List<Course> unassignedCourses;
        private List<Faculty> faculties;
        private int courseid, facultyid, year;
        private string term;

        public AssignCourses()
        {
            InitializeComponent();
        }
        public static AssignCourses Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AssignCourses();
                }
                return instance;
            }
        }
        private void LoadFaculties()
        {
            faculties = facultyDAL.GetAllFaculties();
            fNameComboBox.Items.Clear();
            foreach (var faculty in faculties)
            {
                fNameComboBox.Items.Add(faculty.Name);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AssignCourses_Load(object sender, EventArgs e)
        {
            LoadFaculties();
            LoadCourses(); 
            LoadSemesters();

            termcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            yearcomboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            CncomboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            fNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Ctypecombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CncomboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CncomboBox4.SelectedItem != null)
            {
                Course selectedCourse = unassignedCourses.Find(c => c.CourseName == CncomboBox4.SelectedItem.ToString());
                if (selectedCourse != null)
                {
                    courseid = selectedCourse.CourseId;
                    cIdetextBox2.Text = courseid.ToString();

                    Ctypecombobox.Items.Clear();
                    Ctypecombobox.Items.Add(selectedCourse.CourseType);
                    Ctypecombobox.SelectedIndex = 0; 
                }
            }
        }




        private void cIdetextBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(cIdetextBox2.Text, out courseid);
        }

        private void fNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fNameComboBox.SelectedIndex >= 0)
            {
                Faculty faculty = faculties.Find(f => f.Name == fNameComboBox.SelectedItem.ToString());
                if (faculty != null)
                {
                    facultyid = faculty.FacultyId;
                    fIdtextBox3.Text = facultyid.ToString();

                    LoadCourses();
                }
            }
        }

        private void LoadCourses()
        {
            string selectedCourse = CncomboBox4.SelectedItem?.ToString();

            unassignedCourses = courseDAL.GetUnassignedCourses();

            CncomboBox4.Items.Clear();
            foreach (var course in unassignedCourses)
            {
                CncomboBox4.Items.Add(course.CourseName);
            }

            if (!string.IsNullOrEmpty(selectedCourse))
            {
                var selectedCourseExists = unassignedCourses.Any(c => c.CourseName == selectedCourse);
                if (selectedCourseExists)
                {
                    CncomboBox4.SelectedItem = selectedCourse;
                }
            }
        }


        private void LoadSemesters()
        {
            var semesters = semesterDAL.GetAllSemesters(); 

            termcomboBox1.Items.Clear();
            yearcomboBox2.Items.Clear();

            foreach (var semester in semesters)
            {
                if (!termcomboBox1.Items.Contains(semester.Term))
                {
                    termcomboBox1.Items.Add(semester.Term);
                }
                if (!yearcomboBox2.Items.Contains(semester.Year.ToString()))
                {
                    yearcomboBox2.Items.Add(semester.Year.ToString());
                }
            }
        }


        private void fIdtextBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(fIdtextBox3.Text, out facultyid);
        }

        private void Ctypecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseType = Ctypecombobox.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(yearcomboBox2.Text, out year);
        }

        private void termcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            term = termcomboBox1.Text;
        }

        private void AssignCourseButton_Click(object sender, EventArgs e)
        {
            if (facultyid <= 0 || courseid <= 0 || string.IsNullOrWhiteSpace(term) || year <= 0)
            {
                MessageBox.Show("Please select a faculty, course, term, and year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int semesterId = semesterDAL.GetSemesterId(term, year);
            if (semesterId == -1)
            {
                MessageBox.Show("Semester not found! Please ensure the semester exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isAssigned = facultyCourseDAL.IsFacultyCourseAssigned(courseid, facultyid, semesterId);
            if (isAssigned)
            {
                MessageBox.Show("Course is already assigned to this faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Debug Info:\nFacultyID: {facultyid}\nCourseID: {courseid}\nSemesterID: {semesterId}",
                "Debugging Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FacultyCourse facultyCourse = new FacultyCourse
            {
                Faculty = new Faculty { FacultyId = facultyid },
                Course = new Course { CourseId = courseid },
                Semester = new Semester { SemesterId = semesterId }
            };

            bool success = facultyCourseDAL.InsertFacultyCourse(facultyCourse);

            if (success)
            {
                MessageBox.Show("Course assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadFaculties();
                LoadCourses(); 
                LoadSemesters();

                this.Hide();
                AssignCourses newForm = new AssignCourses();
                newForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Course assignment failed! Please check database connection and ensure faculty and course exist.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
 }
