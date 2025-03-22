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
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P131
{
    public partial class semestersForm : Form
    {
        private SemesterBLL semesterbll = new SemesterBLL();
        private int semesterId;
        private int year;
        private string stype;
        private List<semestersForm> semesterassign;
        public semestersForm()
        {
            InitializeComponent();
        }
        private static semestersForm instance;
        public static semestersForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new semestersForm();
                }
                return instance;
            }
        }
        private void load_semester()
        {
            dataGridView1.Rows.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("Spring");
            comboBox1.Items.Add("Fall");
            comboBox1.Items.Add("Summer");

            int year = DateTime.Now.Year;
            for (int i = 0; i < 4; i++)
            {
                comboBox2.Items.Add((year - i).ToString());
            }


            var semesterassign = semesterbll.GetAllSemesters();

            foreach (var semester in semesterassign)
            {

                dataGridView1.Rows.Add(
                    semester.SemesterId,
                    semester.Term,
                    semester.Year

                );
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            load_semester();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                     semesterId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

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
                            semesterbll.DeleteSemester(semesterId);

                            load_semester();

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

                    semesterId = Convert.ToInt32(row.Cells[0].Value);
                    stype = row.Cells[1].Value.ToString();
                    year = Convert.ToInt32(row.Cells[2].Value);

               

                    comboBox1.SelectedItem = stype;
                    comboBox2.SelectedItem = year;
             
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    stype = comboBox1.SelectedItem.ToString();
                }

                if (comboBox2.SelectedItem != null)
                {
                    year = Convert.ToInt32(comboBox2.SelectedItem);
                }

                if (string.IsNullOrEmpty(stype) || year == 0)
                {
                    MessageBox.Show("Please fill in all fields before adding a project assignment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (semesterId == 0)
                {
                    semesterbll.AddSemester(stype,year);
                    MessageBox.Show("Project assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                semesterbll.UpdateSemester(semesterId, stype, year);
                MessageBox.Show("Project assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                semesterId = 0;

                load_semester();  // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load_semester();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}

       