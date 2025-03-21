using Microsoft.VisualBasic.ApplicationServices;
using DBS25P131.DataAccessLayer;

namespace DBS25P131
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private static loginForm instance;
        public static loginForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new loginForm();
                }
                return instance;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPassword fpassword = new forgetPassword();
            fpassword.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string storedUserName = txtUserName.Text.Trim();
            //string storedPassword = txtPassword.Text.Trim();
            //bool flag = true;
            //if (string.IsNullOrEmpty(storedUserName) || string.IsNullOrEmpty(storedPassword))
            //{
            //    MessageBox.Show("Please enter both Username and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //for (int i = 0; i < UserDAL.users.Count; i++)
            //{
            //    if (storedUserName == UserDAL.users[i].Username && storedPassword == UserDAL.users[i].PasswordHash)
            //    {
            //        if (UserDAL.users[i].RoleId == 1)
            //        {
            //            flag = false;
            //            HeadDepartment headdepartment = new HeadDepartment();
            //            headdepartment.Show();
            //            this.Hide();
            //        }
            //        else if (UserDAL.users[i].RoleId == 2)
            //        {
            //            flag = false;

            //            facultyMember facultymember = new facultyMember();
            //            facultymember.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            flag = false;
            //            Administrator administrator = new Administrator();
            //            administrator.Show();
            //            this.Hide();
            //        }
            //    }
            //}
            //if(flag)
            //{ 
            //        MessageBox.Show("Invalid both Username and Password", "Login faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp sign = new signUp();
            sign.Show();

        }
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Enter Username")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black; 
            }
        }
    }
}
