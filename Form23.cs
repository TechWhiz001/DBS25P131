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
    public partial class HeadDepartment : Form
    {
        public HeadDepartment()
        {
            InitializeComponent();
        }
        private static HeadDepartment instance;
        public static HeadDepartment Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HeadDepartment();
                }
                return instance;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            LoadForm(new WorkloadAssign());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }
        private void LoadForm(Form form)
        {

            dashworkpanel.Controls.Clear();


            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            dashworkpanel.Controls.Add(form);
            form.Show();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Requests_Click(object sender, EventArgs e)
        {

            LoadForm(new FacultyRequest());
        }

        private void Resources_Click(object sender, EventArgs e)
        {
            LoadForm(new Resource());
        }
    }
}
