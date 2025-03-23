namespace DBS25P131
{
    partial class signUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUp));
            sPassword = new TextBox();
            sLabel3 = new Label();
            sUserName = new TextBox();
            label = new Label();
            sLabel2 = new Label();
            sEmail = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            signButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            slabel1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sPassword
            // 
            sPassword.Location = new Point(463, 363);
            sPassword.Name = "sPassword";
            sPassword.PasswordChar = '.';
            sPassword.Size = new Size(242, 25);
            sPassword.TabIndex = 16;
            sPassword.UseSystemPasswordChar = true;
            // 
            // sLabel3
            // 
            sLabel3.BackColor = Color.Transparent;
            sLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sLabel3.Location = new Point(463, 318);
            sLabel3.Name = "sLabel3";
            sLabel3.Size = new Size(100, 23);
            sLabel3.TabIndex = 15;
            sLabel3.Text = "Password";
            sLabel3.Click += label3_Click;
            // 
            // sUserName
            // 
            sUserName.BorderStyle = BorderStyle.FixedSingle;
            sUserName.Location = new Point(463, 202);
            sUserName.Name = "sUserName";
            sUserName.Size = new Size(242, 25);
            sUserName.TabIndex = 14;
            sUserName.TextChanged += textBox1_TextChanged;
            // 
            // label
            // 
            label.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(42, 77);
            label.Name = "label";
            label.Size = new Size(136, 36);
            label.TabIndex = 12;
            label.Text = "Sign up";
            label.Click += label_Click;
            // 
            // sLabel2
            // 
            sLabel2.BackColor = Color.Transparent;
            sLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sLabel2.Location = new Point(463, 239);
            sLabel2.Name = "sLabel2";
            sLabel2.Size = new Size(122, 23);
            sLabel2.TabIndex = 22;
            sLabel2.Text = "Email Address";
            sLabel2.Click += label2_Click;
            // 
            // sEmail
            // 
            sEmail.Location = new Point(463, 279);
            sEmail.Name = "sEmail";
            sEmail.Size = new Size(242, 25);
            sEmail.TabIndex = 23;
            sEmail.TextChanged += textBox2_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(84, 58, 20);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(962, 43);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // signButton
            // 
            signButton.BackColor = Color.FromArgb(19, 16, 16);
            signButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signButton.ForeColor = Color.White;
            signButton.Location = new Point(608, 438);
            signButton.Name = "signButton";
            signButton.Size = new Size(97, 31);
            signButton.TabIndex = 25;
            signButton.Text = "Sign up";
            signButton.UseVisualStyleBackColor = false;
            signButton.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 609);
            panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_male_user_color_icon;
            pictureBox1.Location = new Point(23, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // slabel1
            // 
            slabel1.BackColor = Color.Transparent;
            slabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slabel1.Location = new Point(463, 166);
            slabel1.Name = "slabel1";
            slabel1.Size = new Size(122, 23);
            slabel1.TabIndex = 27;
            slabel1.Text = "Username";
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 652);
            Controls.Add(slabel1);
            Controls.Add(panel1);
            Controls.Add(signButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(sEmail);
            Controls.Add(sLabel2);
            Controls.Add(sPassword);
            Controls.Add(sLabel3);
            Controls.Add(sUserName);
            MinimumSize = new Size(978, 691);
            Name = "signUp";
            Text = "SignUp";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox sPassword;
        private Label sLabel3;
        private TextBox sUserName;
        private Label label;
        private Label sLabel2;
        private TextBox sEmail;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button signButton;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label slabel1;
    }
}