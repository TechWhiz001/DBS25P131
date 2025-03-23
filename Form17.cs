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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P131
{
    public partial class ProjectAllocationForm : Form
    {
        private ProjectBLL projectbll = new ProjectBLL();
        private int projectId;
        private string projectTitle;
        private string description;
        private List<Project> projectallocate;

        public ProjectAllocationForm()
        {
            InitializeComponent();
        }
        private static ProjectAssign instance;
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
        private void Load_AllocateProjects()
        {
            dataGridView1.Rows.Clear();
            var projectallocate = projectbll.GetAllProjects();

            foreach (var project in projectallocate)
            {

                dataGridView1.Rows.Add(
                    project.ProjectId,
                    project.Title,
                    project.Description
                );
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            Load_AllocateProjects();
            if (!dataGridView1.Columns.Contains("Update"))
            {
                DataGridViewButtonColumn UpdateButton = new DataGridViewButtonColumn();
                UpdateButton.Name = "Update";
                UpdateButton.HeaderText = "Action";
                UpdateButton.Text = "Update";
                UpdateButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(UpdateButton);
            }
            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Action";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButton);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            projectTitle = TltextBox3.Text;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int ProjectIdToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

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
                            projectbll.DeleteProject(ProjectIdToDelete);

                            Load_AllocateProjects();

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
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    projectId = Convert.ToInt32(row.Cells[0].Value);
                    projectTitle = row.Cells[1].Value.ToString();
                    description = row.Cells[2].Value?.ToString() ?? string.Empty;


                    TltextBox3.Text = projectTitle.ToString();
                    DesrichTextBox1.Text = description.ToString();

                }
            }
        }

        private void DesrichTextBox1_TextChanged(object sender, EventArgs e)
        {
            description = DesrichTextBox1.Text;
        }

        private void Assignbutton_Click(object sender, EventArgs e)
        {
            try
            {
                

                if ( string.IsNullOrEmpty(projectTitle) || string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("Please fill in all fields before adding a project assignment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                if (projectId == 0)
                {
                    projectbll.AddProject(  projectTitle, description);
                    MessageBox.Show("Project assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    projectbll.UpdateProject( projectId, projectTitle, description);
                    MessageBox.Show("Project assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    projectId = 0;
                }


                Load_AllocateProjects();


                //ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
