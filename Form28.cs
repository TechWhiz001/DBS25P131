using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DBS25P131
{
    public partial class facultyMember : Form
    {
        public facultyMember()
        {
            InitializeComponent();
        }
        private void LoadForm(Form form)
        {

            dashfacultypanel.Controls.Clear();


            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            dashfacultypanel.Controls.Add(form);
            form.Show();
        }
        private void dashworkpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Workload_Click(object sender, EventArgs e)
        {
            LoadForm(new VeiwCourses());
        }

        private void Requests_Click(object sender, EventArgs e)
        {
            LoadForm(new submitRequest());
        }

        private void Resources_Click(object sender, EventArgs e)
        {
            LoadForm(new requestStatus());
        }
    }
}
