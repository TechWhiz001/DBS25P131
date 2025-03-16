namespace DBS25P131
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
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
            string uId = txtUserName.Text;
            string password = txtPassword.Text;
            string role = comboRole.SelectedItem.ToString();

             if(role == "Department Head")
            {
                HeadDepartment headdepartment = new HeadDepartment();
                    headdepartment.Show();
            }
            else if (role == "Faculty Member")
            {

                facultyMember facultymember = new facultyMember();
                facultymember.Show();
            }
            else if (role == "Administrative Staff")
            {
                Administrator administrator = new Administrator();
                administrator.Show();
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
    }
}
