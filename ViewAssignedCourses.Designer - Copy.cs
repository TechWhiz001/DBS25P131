namespace DBS25P131
{
    partial class ViewAssignedCourses
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
            facultyCoursePanel = new Panel();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            designation_id = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            Ctype = new ComboBox();
            button6 = new Button();
            cHours = new TextBox();
            Contacthours = new TextBox();
            Cname = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            facultyCoursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // facultyCoursePanel
            // 
            facultyCoursePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            facultyCoursePanel.BackColor = Color.FromArgb(240, 187, 120);
            facultyCoursePanel.Controls.Add(dataGridView1);
            facultyCoursePanel.Controls.Add(label1);
            facultyCoursePanel.Location = new Point(0, 0);
            facultyCoursePanel.Name = "facultyCoursePanel";
            facultyCoursePanel.Size = new Size(943, 302);
            facultyCoursePanel.TabIndex = 28;
            facultyCoursePanel.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, email, contact, designation_id });
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(896, 188);
            dataGridView1.TabIndex = 27;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 0;
            label1.Text = "View Courses";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(84, 58, 20);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(Ctype);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(cHours);
            groupBox1.Controls.Add(Contacthours);
            groupBox1.Controls.Add(Cname);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button3);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(943, 313);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Allocate Courses";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(833, 24);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 103;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // Ctype
            // 
            Ctype.Anchor = AnchorStyles.None;
            Ctype.FormattingEnabled = true;
            Ctype.Items.AddRange(new object[] { "Theory", "Lab" });
            Ctype.Location = new Point(162, 149);
            Ctype.Name = "Ctype";
            Ctype.Size = new Size(260, 33);
            Ctype.TabIndex = 102;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(833, 245);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 101;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = false;
            // 
            // cHours
            // 
            cHours.Anchor = AnchorStyles.None;
            cHours.Location = new Point(618, 77);
            cHours.Name = "cHours";
            cHours.Size = new Size(260, 33);
            cHours.TabIndex = 100;
            // 
            // Contacthours
            // 
            Contacthours.Anchor = AnchorStyles.None;
            Contacthours.Location = new Point(618, 147);
            Contacthours.Name = "Contacthours";
            Contacthours.Size = new Size(260, 33);
            Contacthours.TabIndex = 99;
            Contacthours.TextChanged += Contacthours_TextChanged;
            // 
            // Cname
            // 
            Cname.Anchor = AnchorStyles.None;
            Cname.Location = new Point(162, 75);
            Cname.Name = "Cname";
            Cname.Size = new Size(260, 33);
            Cname.TabIndex = 97;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(673, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 96;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(494, 77);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 95;
            label3.Text = "Credit Hours";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 149);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 94;
            label5.Text = "Course Type";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 77);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 93;
            label7.Text = "Course_Name";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(494, 153);
            label8.Name = "label8";
            label8.Size = new Size(118, 23);
            label8.TabIndex = 92;
            label8.Text = "Contact Hours";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(19, 16, 16);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(40, 245);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 88;
            button3.Text = "Go back";
            button3.UseVisualStyleBackColor = false;
            // 
            // ViewAssignedCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 620);
            Controls.Add(groupBox1);
            Controls.Add(facultyCoursePanel);
            MinimumSize = new Size(959, 659);
            Name = "ViewAssignedCourses";
            Text = "ViewAssignedCourses";
            Load += ViewAssignedCourses_Load;
            facultyCoursePanel.ResumeLayout(false);
            facultyCoursePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel facultyCoursePanel;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn designation_id;
        private GroupBox groupBox1;
        private ComboBox Ctype;
        private Button button6;
        private TextBox cHours;
        private TextBox Contacthours;
        private TextBox Cname;
        private Button button1;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button2;
    }
}