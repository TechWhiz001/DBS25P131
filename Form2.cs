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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        private static signUp instance;
        public static signUp Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new signUp();
                }
                return instance;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string signUser = sUserName.Text;
            string signemail = sEmail.Text;
            string signpassword = sPassword.Text;
            string signrole = sRole.SelectedItem.ToString();
            if (signrole == "Department Head")
            {
                HeadDepartment headdepartment = new HeadDepartment();
                headdepartment.Show();
            }
            else if (signrole == "Faculty Member")
            {

                facultyMember facultymember = new facultyMember();
                facultymember.Show();
            }
            else if(signrole == "Administrative Staff")
            {
                Administrator administrator = new Administrator();
                administrator.Show();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
