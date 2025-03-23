using Microsoft.VisualBasic.ApplicationServices;
using DBS25P131.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.Models;
using DBS25P131.BusinessLogicLayer;

namespace DBS25P131
{
    public partial class loginForm : Form
    {
        private readonly UserBLL userbll = new UserBLL();

        private List<Models.User> users;
       
        public loginForm()
        {
            InitializeComponent();
            users= userbll.GetAllUsers();

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
            string storedUserName = txtUserName.Text.Trim();
            string storedPassword = txtPassword.Text.Trim();
            bool flag = true;
            
            if (string.IsNullOrEmpty(storedUserName) || string.IsNullOrEmpty(storedPassword))
            {
                MessageBox.Show("Please enter both Username and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach(var user in users)
            {
                if (storedUserName == user.Username && storedPassword == user.PasswordHash)
                {
                    if (user.Role.LookupId == 3)
                    {
                        flag = false;
                        HeadDepartment headdepartment = new HeadDepartment();
                        headdepartment.Show();
                        this.Hide();
                    }
                    else if (user.Role.LookupId == 2)
                    {
                        flag = false;
                        facultyMember facultymember = new facultyMember(user.UserId);
                        facultymember.Show();
                        this.Hide();
                    }
                    else if (user.Role.LookupId == 1)
                    {
                        flag = false;
                        Administrator administrator = new Administrator();
                        administrator.Show();
                        this.Hide();
                    }
                }
            }
            if (flag)
            {
                MessageBox.Show("Invalid both Username and Password", "Login faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


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
