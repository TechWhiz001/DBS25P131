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
using static System.Windows.Forms.DataFormats;

namespace DBS25P131
{
    public partial class facultyMember : Form
    {
        private int userid;
        public facultyMember(int uid)
        {
            InitializeComponent();
            this.userid = uid;
        }
        private static facultyMember instance;

        public static facultyMember GetInstance(int uid)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new facultyMember(uid);
            }
            return instance;
        }
        private void LoadForm(Form form)
        {

            dashfacultypanel.Controls.Clear();


            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            dashfacultypanel.Controls.Add(form);
            form.Show();
             // Fetch user data

            //if (user != null)
            //{
            //    lblUserName.Text = user.Username;
            //    lblRole.Text = (user.RoleId == 2) ? "Faculty Member" : "Other Role";
            //    lblEmail.Text = user.Email;
            //    lblPhone.Text = user.PhoneNumber;
            //}
        
        }
        private void dashworkpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Workload_Click(object sender, EventArgs e)
        {
            
            LoadForm(new VeiwCourses(userid));
        }

        private void Requests_Click(object sender, EventArgs e)
        {
            LoadForm(new submitRequest());
        }

        private void Resources_Click(object sender, EventArgs e)
        {
            LoadForm(new requestStatusform(userid));
        }

        private void facultyMember_Load(object sender, EventArgs e)
        {

        }
    }
}
