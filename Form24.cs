﻿using System;
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
    public partial class WorkloadAssign : Form
    {

        public WorkloadAssign()
        {
            InitializeComponent();

        }
        private static WorkloadAssign instance;
        public static WorkloadAssign Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkloadAssign();
                }
                return instance;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadForm(Form form)
        {

            WorkloadPanel.Controls.Clear();


            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            WorkloadPanel.Controls.Add(form);
            form.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LoadForm(new AssignCourses());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadForm(new ProjectForm());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadForm(new semestersForm());
        }
    }
}
