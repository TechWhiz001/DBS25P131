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
            string storedUserId = txtUserName.Text.Trim();
            string storedPassword = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(storedUserId) || string.IsNullOrEmpty(storedPassword))
            {
                MessageBox.Show("Please enter both Username and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (storedUserId == "asd" && storedPassword == "123")
            {
                HeadDepartment headdepartment = new HeadDepartment();
                headdepartment.Show();
                this.Hide();
            }

            else if (storedUserId == "dfg" && storedPassword == "456")
            {
                facultyMember facultymember = new facultyMember();
                facultymember.Show();
                this.Hide();
            }
            else if (storedUserId == "hjk" && storedPassword == "789")
            {
                Administrator administrator = new Administrator();
                administrator.Show();
                this.Hide();
            }
            else
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
                txtUserName.ForeColor = Color.Black; // Change text color to normal
            }
        }
    }
}
