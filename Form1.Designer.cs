namespace DBS25P131
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            label = new Label();
            Llabel1 = new Label();
            txtUserName = new TextBox();
            Llabel2 = new Label();
            txtPassword = new TextBox();
            loginButton = new Button();
            linkLabelP = new LinkLabel();
            linkLabelS = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(80, 103);
            label.Name = "label";
            label.Size = new Size(154, 46);
            label.TabIndex = 0;
            label.Text = "LOGIN";
            label.Click += label1_Click;
            // 
            // Llabel1
            // 
            Llabel1.BackColor = Color.Transparent;
            Llabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Llabel1.Location = new Point(463, 203);
            Llabel1.Name = "Llabel1";
            Llabel1.Size = new Size(100, 29);
            Llabel1.TabIndex = 1;
            Llabel1.Text = "Username";
            Llabel1.Click += label1_Click_1;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.ForeColor = Color.Gray;
            txtUserName.Location = new Point(463, 235);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(269, 25);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "Username";
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // Llabel2
            // 
            Llabel2.BackColor = Color.Transparent;
            Llabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Llabel2.Location = new Point(463, 284);
            Llabel2.Name = "Llabel2";
            Llabel2.Size = new Size(100, 29);
            Llabel2.TabIndex = 5;
            Llabel2.Text = "Password";
            Llabel2.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(463, 316);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '.';
            txtPassword.Size = new Size(272, 25);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox3_TextChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(19, 16, 16);
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(638, 386);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(97, 32);
            loginButton.TabIndex = 9;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click_1;
            // 
            // linkLabelP
            // 
            linkLabelP.AutoSize = true;
            linkLabelP.BackColor = Color.Transparent;
            linkLabelP.BorderStyle = BorderStyle.Fixed3D;
            linkLabelP.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabelP.Location = new Point(621, 344);
            linkLabelP.Name = "linkLabelP";
            linkLabelP.Size = new Size(114, 19);
            linkLabelP.TabIndex = 10;
            linkLabelP.TabStop = true;
            linkLabelP.Text = "Forget Password?";
            linkLabelP.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabelS
            // 
            linkLabelS.AutoSize = true;
            linkLabelS.BackColor = Color.Transparent;
            linkLabelS.BorderStyle = BorderStyle.Fixed3D;
            linkLabelS.LinkColor = Color.Black;
            linkLabelS.Location = new Point(463, 440);
            linkLabelS.Name = "linkLabelS";
            linkLabelS.Size = new Size(214, 19);
            linkLabelS.TabIndex = 11;
            linkLabelS.TabStop = true;
            linkLabelS.Text = "Don't have an account yet? Sign up";
            linkLabelS.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 655);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg;
            pictureBox1.Location = new Point(30, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 652);
            Controls.Add(panel1);
            Controls.Add(linkLabelS);
            Controls.Add(linkLabelP);
            Controls.Add(loginButton);
            Controls.Add(txtPassword);
            Controls.Add(Llabel2);
            Controls.Add(txtUserName);
            Controls.Add(Llabel1);
            MinimumSize = new Size(978, 691);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label Llabel1;
        private TextBox txtUserName;
        private Label Llabel2;
        private TextBox txtPassword;
        private Button loginButton;
        private LinkLabel linkLabelP;
        private LinkLabel linkLabelS;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
