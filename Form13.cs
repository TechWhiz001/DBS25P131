using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P131.BusinessLayer;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131
{
    public partial class ProjectAssign : Form
    {
        private FacultyBLL facultybll = new FacultyBLL();
        private ProjectBLL projectbll = new ProjectBLL();
        private SemesterBLL semesterbll = new SemesterBLL();
        private FacultyProjectBLL facultyProjectbll = new FacultyProjectBLL();

        private int facultyProjectId;
        private string facultyName;
        private int facultyId;
        private string projectTitle;
        private int projectId;
        private string semesterTerm;
        private int semesterYear;
        private int supervisionHours;
        private List<Project> projectassign;
        private List<Semester> semesterassign;
        private List<FacultyCourse> facultyprojects;

        private static ProjectAssign instance;

        public ProjectAssign()
        {
            InitializeComponent();
        }
        public static ProjectAssign Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectAssign();
                }
                return instance;
            }
        }
        private void Load_Projects()
        {
            projectassign = projectbll.GetUnassignedProjects();
            PTCombobox.Items.Clear();
            foreach (var project in projectassign)
            {
                PTCombobox.Items.Add(project.Title);
            }
        }
        // Load Semester Data
        private void Load_Semester()
        {
            semesterassign = semesterbll.GetAllSemesters();
            TermcomboBox2.Items.Clear();
            YearcomboBox1.Items.Clear();
            foreach (var semester in semesterassign)
            {
                TermcomboBox2.Items.Add(semester.Term);
                YearcomboBox1.Items.Add(semester.Year.ToString());
            }
        }
        private void Load_Faculty()
        {
            var faculties = facultybll.GetAllFaculties();
            FNcomboBox1.Items.Clear();
            foreach (var faculty in faculties)
            {
                FNcomboBox1.Items.Add(faculty.Name);
            }
        }


        private void Load_AssignedProjects()
        {
            dataGridView1.Rows.Clear();
            var facultyProjects = facultyProjectbll.GetAllFacultyProjects();

            foreach (var project in facultyProjects)
            {

                dataGridView1.Rows.Add(
                    project.FacultyProjectId,
                    project.Faculty.FacultyId,
                    project.Faculty.Name,
                    project.Project.ProjectId,
                    project.Project.Title,
                    project.Semester.Year,
                    project.Semester.Term,
                    project.SupervisionHours
                );
            }
        }
        private void ResetFields()
        {
            // Clear TextBoxes
            FItextBox5.Clear();
            PItextBox1.Clear();
            shourtextBox4.Clear();

            // Reset ComboBoxes
            FNcomboBox1.SelectedIndex = -1;
            PTCombobox.SelectedIndex = -1;
            TermcomboBox2.SelectedIndex = -1;
            YearcomboBox1.SelectedIndex = -1;

            // Reset Stored Values
            facultyProjectId = 0;
            facultyId = 0;
            projectId = 0;
            semesterTerm = "";
            semesterYear = 0;
            supervisionHours = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            Load_Faculty();
            Load_Projects();
            Load_Semester();
            Load_AssignedProjects();
            if (!dataGridView1.Columns.Contains("Update"))
            {
                DataGridViewButtonColumn UpdateButton = new DataGridViewButtonColumn();
                UpdateButton.Name = "Update";
                UpdateButton.HeaderText = "Action";
                UpdateButton.Text = "Update";
                UpdateButton.UseColumnTextForButtonValue = true; // Display "Delete" as button text
                dataGridView1.Columns.Add(UpdateButton);
            }
            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Action";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true; // Display "Delete" as button text
                dataGridView1.Columns.Add(deleteButton);
            }
           
        }

        private void FPItextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void FNtextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FItextBox5_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(FItextBox5.Text, out facultyId);

        }

        private void PTCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PTCombobox.SelectedItem != null)
            {
                projectTitle = PTCombobox.SelectedItem.ToString();

                var selectedProject = projectassign.FirstOrDefault(p => p.Title == projectTitle);

                if (selectedProject != null)
                {
                    projectId = selectedProject.ProjectId;
                    PItextBox1.Text = projectId.ToString(); // Auto-fill Project ID
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void YearcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearcomboBox1.SelectedItem != null)
            {
                int.TryParse(YearcomboBox1.SelectedItem.ToString(), out semesterYear);
            }

        }

        private void TermcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TermcomboBox2.SelectedItem != null)
            {
                semesterTerm = TermcomboBox2.SelectedItem.ToString();
            }
            else
            {
                semesterTerm = ""; // Default empty string or handle accordingly
            }
        }

        private void ShorstextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure facultyId is set
                if (FNcomboBox1.SelectedItem != null)
                {
                    facultyName = FNcomboBox1.SelectedItem.ToString();
                    var selectedFaculty = facultybll.GetAllFaculties().FirstOrDefault(f => f.Name == facultyName);
                    if (selectedFaculty != null)
                        facultyId = selectedFaculty.FacultyId;
                }

                // Ensure projectId is set
                if (PTCombobox.SelectedItem != null)
                {
                    projectTitle = PTCombobox.SelectedItem.ToString();
                    var selectedProject = projectassign.FirstOrDefault(p => p.Title == projectTitle);
                    if (selectedProject != null)
                        projectId = selectedProject.ProjectId;
                }

                // Ensure semesterTerm and semesterYear are set
                if (TermcomboBox2.SelectedItem != null)
                    semesterTerm = TermcomboBox2.SelectedItem.ToString();

                if (YearcomboBox1.SelectedItem != null)
                    int.TryParse(YearcomboBox1.SelectedItem.ToString(), out semesterYear);

                // Ensure supervisionHours is set
                if (!int.TryParse(shourtextBox4.Text, out supervisionHours) || supervisionHours <= 0)
                {
                    MessageBox.Show("Please enter a valid number for supervision hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure all fields are filled
                if (facultyId == 0 || projectId == 0 || string.IsNullOrEmpty(semesterTerm) || semesterYear == 0 || supervisionHours == 0)
                {
                    MessageBox.Show("Please fill in all fields before adding a project assignment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int semesterId = semesterbll.GetSemesterIdByTermAndYear(semesterTerm, semesterYear);

                if (facultyProjectId == 0) // INSERT Mode
                {
                    facultyProjectbll.insertFacultyProject(facultyId, projectId, semesterId, supervisionHours);
                    MessageBox.Show("Project assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // UPDATE Mode
                {
                    facultyProjectbll.updateFacultyProject(facultyProjectId, facultyId, projectId, semesterId, supervisionHours);
                    MessageBox.Show("Project assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    facultyProjectId = 0; // Reset for new insert
                }

                // Refresh the DataGridView
                Load_AssignedProjects();

                // Reset Fields
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete") // If Delete button is clicked
                {
                    int facultyProjectIdToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    // Confirm before deletion
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this project assignment?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Call the BLL function to delete the entry
                            facultyProjectbll.RemoveFacultyProject(facultyProjectIdToDelete);

                            // Refresh DataGridView
                            Load_AssignedProjects();

                            MessageBox.Show("Project assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Handle row selection for editing
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    facultyProjectId = Convert.ToInt32(row.Cells[0].Value);
                    facultyId = Convert.ToInt32(row.Cells[1].Value);
                    facultyName = row.Cells[2].Value.ToString();
                    projectId = Convert.ToInt32(row.Cells[3].Value);
                    projectTitle = row.Cells[4].Value.ToString();
                    semesterYear = Convert.ToInt32(row.Cells[5].Value);
                    semesterTerm = row.Cells[6].Value.ToString();
                    supervisionHours = Convert.ToInt32(row.Cells[7].Value);

                    FItextBox5.Text = facultyId.ToString();
                    PItextBox1.Text = projectId.ToString();
                    shourtextBox4.Text = supervisionHours.ToString();

                    FNcomboBox1.SelectedItem = facultyName;
                    PTCombobox.SelectedItem = projectTitle;
                    TermcomboBox2.SelectedItem = semesterTerm;
                    YearcomboBox1.SelectedItem = semesterYear.ToString();
                }
            }
        }

        private void PItextBox4_TextChanged(object sender, EventArgs e)
        {
            if (shourtextBox4.Text != null)
            {
                int.TryParse(shourtextBox4.Text, out supervisionHours);
                shourtextBox4.Text = supervisionHours.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FNcomboBox1.SelectedItem != null)
            {
                facultyName = FNcomboBox1.SelectedItem.ToString();

                var selectedFaculty = facultybll.GetAllFaculties().FirstOrDefault(f => f.Name == facultyName);

                if (selectedFaculty != null)
                {
                    facultyId = selectedFaculty.FacultyId;
                    FItextBox5.Text = facultyId.ToString(); // Auto-fill Faculty ID
                }
            }
        }

        private void ShourscomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PItextBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(PItextBox1.ToString(), out projectId);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
