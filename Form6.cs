using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DBS25P131.Models;
using DBS25P131.BusinessLayer;
using DBS25P131.DataAccessLayer;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P131.Business_Logic_Layer;
using DBS25P131.BusinessLogicLayer;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P131
{
    public partial class ManageFacultyProfiles : Form
    {
        private FacultyBLL facultybll = new FacultyBLL();
        private UserBLL userbll = new UserBLL();

        private int facultyId;
        private string facultyName;
        private string email;
        private string contact;
        private int designationId;
        private string researchArea;
        private int totalHours;
        private int userId;
        private List<User> userassign;
        private List<Faculty> facultyassign;
        public ManageFacultyProfiles()
        {
            InitializeComponent();
        }
        private static ManageFacultyProfiles instance;
        public static ManageFacultyProfiles Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageFacultyProfiles();
                }
                return instance;
            }
        }
        //private void Load_Faculty()
        //{
        //    var faculties = facultybll.GetAllFaculties();
        //    FNtextBox7.Clear();
        //    foreach (var faculty in faculties)
        //    {
        //        FNtextBox7.Items.Add(faculty.Name);
        //    }
        //}
        private void Load_Faculty()
        {
            dataGridView1.Rows.Clear();
            var faculties = facultybll.GetAllFaculties();

            foreach (var faculty in faculties)
            {

                dataGridView1.Rows.Add(
                    faculty.FacultyId,
                    faculty.Name,
                    faculty.Email,
                    faculty.Contact,
                    faculty.Designation,
                    faculty.ResearchArea,
                    faculty.TotalTeachingHours,
                    faculty.User
                );
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int facultyProjectIdToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this Faculty memeber?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            facultybll.DeleteFaculty(facultyProjectIdToDelete);

                            Load_Faculty();

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

                    facultyId = Convert.ToInt32(row.Cells[0].Value);
                    facultyName = row.Cells[1].Value.ToString();
                    email = row.Cells[2].Value.ToString();
                    contact = row.Cells[3].Value.ToString();
                    designationId = Convert.ToInt32(row.Cells[4].Value);
                    researchArea = row.Cells[5].Value.ToString();
                    totalHours = Convert.ToInt32(row.Cells[6].Value);
                    userId = Convert.ToInt32(row.Cells[7].Value);

                    FNtextBox7.Text = facultyName.ToString();
                    emtextBox1.Text = email.ToString();
                    ContextBox8.Text = contact.ToString();
                    DItextBox5.Text = researchArea.ToString();
                    RAtextBox4.Text = researchArea.ToString();
                    TTHtextBox6.Text = totalHours.ToString();
                    UItextBox2.Text = userId.ToString();

                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FNtextBox7_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(FNtextBox7.Text))
            //{
            //    MessageBox.Show("Please enter a faculty name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

             facultyName = FNtextBox7.Text.Trim();

            //if (!facultyName.All(char.IsLetter))
            //{
            //    MessageBox.Show("Faculty name should only contain letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //var selectedFaculty = facultybll.GetAllFaculties().FirstOrDefault(f => f.Name.Equals(facultyName, StringComparison.OrdinalIgnoreCase));

            //if (selectedFaculty != null)
            //{
            //    facultyId = selectedFaculty.FacultyId;
            //    FNtextBox7.Text = facultyId.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Faculty not found. Please enter a valid faculty name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void EtextBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void ContextBox8_TextChanged(object sender, EventArgs e)
        {
            contact = ContextBox8.Text.Trim();

            // Contact number validation (only digits & length check)
            if (!contact.All(char.IsDigit) || contact.Length == 11)
            {
                MessageBox.Show("Invalid contact number. It should contain only digits and be at least 10 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContextBox8.Focus();
            }
        }

        private void RAtextBox4_TextChanged(object sender, EventArgs e)
        {
            researchArea = RAtextBox4.Text.Trim();

            // Ensure research area is not empty
            if (string.IsNullOrWhiteSpace(researchArea))
            {
                MessageBox.Show("Research area cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RAtextBox4.Focus();
            }
        }

        private void TTHtextBox6_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TTHtextBox6.Text.Trim(), out totalHours) || totalHours < 0)
            {
                MessageBox.Show("Invalid total hours. Please enter a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TTHtextBox6.Focus();
            }
        }

        private void DItextBox5_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(DItextBox5.Text.Trim(), out designationId) || designationId <= 0)
            {
                MessageBox.Show("Invalid designation ID. Please enter a valid number greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DItextBox5.Focus();
            }
        }

        private void UItextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(UItextBox2.Text.Trim(), out userId) || userId <= 0)
            {
                MessageBox.Show("Invalid user ID. Please enter a valid number greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UItextBox2.Focus();
            }
        }

        // Helper Method for Email Validation
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void AssignBuuton_Click(object sender, EventArgs e)
        {
            try
            {
                if (facultyId == 0)
                {
                    facultybll.InsertFaculty(facultyName, email, designationId, contact, researchArea, totalHours, userId);
                    MessageBox.Show("Project assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    facultybll.UpdateFaculty(facultyId, facultyName, email, designationId, contact, researchArea, totalHours, userId);
                    MessageBox.Show("Project assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    facultyId = 0;
                }


                Load_Faculty();


                //ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {

            Load_Faculty();
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

        private void emailomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (emailomboBox2.SelectedItem != null)
            //{
            //    string email = emailomboBox2.SelectedItem.ToString();

            //    var selectedUser = userbll.GetAllUsers().FirstOrDefault(u => u.Email == email);

            //    if (selectedUser != null)
            //    {
            //        UItextBox2.Text = selectedUser.UserId.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("User not found for the selected email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        UItextBox2.Clear();
            //    }

            //    if (!IsValidEmail(email))
            //    {
            //        MessageBox.Show("Invalid email format. Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        emailomboBox2.Focus();
            
            //    }
            //}
        }

        private void emtextBox1_TextChanged(object sender, EventArgs e)
        {
            email = emtextBox1.Text.Trim();

            //var selectedUser = userbll.GetAllUsers().FirstOrDefault(u => u.Email == email);

            //if (selectedUser != null)
            //{
            //    userId = selectedUser.UserId;
            //    UItextBox2.Text = userId.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("User not found for the selected email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    UItextBox2.Clear();
            //}

            //if (!IsValidEmail(email))
            //{
            //    MessageBox.Show("Invalid email format. Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    emtextBox1.Focus();
            //}
        }
    }
}
