namespace DBS25P131
{
    partial class Form2
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
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(284, 480);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(212, 17);
            linkLabel2.TabIndex = 21;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Don't have an account yet? Sign up";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(444, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 17);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(479, 434);
            button1.Name = "button1";
            button1.Size = new Size(77, 31);
            button1.TabIndex = 19;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Department Head", "Faculty Members", "Administrative Staff" });
            comboBox1.Location = new Point(235, 386);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 25);
            comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 351);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 17;
            label4.Text = "Role";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(235, 309);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '.';
            textBox3.Size = new Size(321, 25);
            textBox3.TabIndex = 16;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(235, 271);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(235, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 25);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 115);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // label
            // 
            label.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(347, 53);
            label.Name = "label";
            label.Size = new Size(149, 45);
            label.TabIndex = 12;
            label.Text = "Sign up";
            label.Click += label_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 196);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 22;
            label2.Text = "Email Address";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 25);
            textBox2.TabIndex = 23;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label label;
        private Label label2;
        private TextBox textBox2;
    }
}