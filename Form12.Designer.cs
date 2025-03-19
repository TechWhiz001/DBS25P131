namespace DBS25P131
{
    partial class AssignCourse
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
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Faculty_Id = new DataGridViewTextBoxColumn();
            Faculty_Name = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            designation_id = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            Ctype = new ComboBox();
            button6 = new Button();
            cHours = new TextBox();
            Contacthours = new TextBox();
            fName = new TextBox();
            Cname = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            label8 = new Label();
            fId = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(358, 1);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 0;
            label1.Text = "Faculty_Courses";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 283);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Faculty_Id, Faculty_Name, name, email, contact, designation_id });
            dataGridView1.Location = new Point(8, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(932, 214);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // Faculty_Id
            // 
            Faculty_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Faculty_Id.HeaderText = "Faculty_Id";
            Faculty_Id.Name = "Faculty_Id";
            // 
            // Faculty_Name
            // 
            Faculty_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Faculty_Name.HeaderText = "Faculty_Name";
            Faculty_Name.Name = "Faculty_Name";
            // 
            // name
            // 
            name.HeaderText = "course_name";
            name.Name = "name";
            // 
            // email
            // 
            email.HeaderText = "course_type";
            email.Name = "email";
            // 
            // contact
            // 
            contact.HeaderText = "credit_hours";
            contact.Name = "contact";
            // 
            // designation_id
            // 
            designation_id.HeaderText = "contact_hours";
            designation_id.Name = "designation_id";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(84, 58, 20);
            groupBox1.Controls.Add(Ctype);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(cHours);
            groupBox1.Controls.Add(Contacthours);
            groupBox1.Controls.Add(fName);
            groupBox1.Controls.Add(Cname);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(fId);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(957, 364);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Assign Courses";
            // 
            // Ctype
            // 
            Ctype.FormattingEnabled = true;
            Ctype.Items.AddRange(new object[] { "Theory", "Lab" });
            Ctype.Location = new Point(573, 77);
            Ctype.Name = "Ctype";
            Ctype.Size = new Size(260, 33);
            Ctype.TabIndex = 51;
            Ctype.SelectedIndexChanged += Ctype_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(813, 297);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 50;
            button6.Text = "Approved";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // cHours
            // 
            cHours.Location = new Point(573, 142);
            cHours.Name = "cHours";
            cHours.Size = new Size(260, 33);
            cHours.TabIndex = 46;
            cHours.TextChanged += cHours_TextChanged;
            // 
            // Contacthours
            // 
            Contacthours.Location = new Point(573, 205);
            Contacthours.Name = "Contacthours";
            Contacthours.Size = new Size(260, 33);
            Contacthours.TabIndex = 45;
            Contacthours.TextChanged += ContactHours_TextChanged;
            // 
            // fName
            // 
            fName.Location = new Point(138, 195);
            fName.Name = "fName";
            fName.Size = new Size(260, 33);
            fName.TabIndex = 44;
            fName.TextChanged += fName_TextChanged;
            // 
            // Cname
            // 
            Cname.Location = new Point(138, 81);
            Cname.Name = "Cname";
            Cname.Size = new Size(260, 33);
            Cname.TabIndex = 43;
            Cname.TextChanged += Cname_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(671, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 42;
            button1.Text = "Reject";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(438, 148);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 41;
            label6.Text = "Credit Hours";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(438, 87);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 40;
            label5.Text = "Course Type";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 91);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 39;
            label4.Text = "Course_Name";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(438, 211);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 38;
            label7.Text = "Contact Hours";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 205);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 37;
            label3.Text = "Faculty_Name";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 151);
            label8.Name = "label8";
            label8.Size = new Size(99, 24);
            label8.TabIndex = 36;
            label8.Text = "Faculty_id";
            // 
            // fId
            // 
            fId.Location = new Point(138, 142);
            fId.Name = "fId";
            fId.Size = new Size(260, 33);
            fId.TabIndex = 35;
            fId.TextChanged += textBox7_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(6, 324);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 23;
            button2.Text = "Go back";
            button2.UseVisualStyleBackColor = false;
            // 
            // AssignCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 691);
            Name = "AssignCourse";
            Text = "AssignCourse";
            Load += Form12_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox Ctype;
        private Button button6;
        private TextBox cHours;
        private TextBox Contacthours;
        private TextBox fName;
        private TextBox Cname;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label3;
        private Label label8;
        private TextBox fId;
        private Button button2;
        private DataGridViewTextBoxColumn Faculty_Id;
        private DataGridViewTextBoxColumn Faculty_Name;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn designation_id;
    }
}