namespace DBS25P131
{
    partial class Form12
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
            course_id = new DataGridViewTextBoxColumn();
            Faculty_Id = new DataGridViewTextBoxColumn();
            Faculty_Name = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            designation_id = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(28, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 599);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, Faculty_Id, Faculty_Name, name, email, contact, designation_id });
            dataGridView1.Location = new Point(42, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(792, 439);
            dataGridView1.TabIndex = 0;
            // 
            // course_id
            // 
            course_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            course_id.Frozen = true;
            course_id.HeaderText = "course_id";
            course_id.Name = "course_id";
            course_id.Width = 150;
            // 
            // Faculty_Id
            // 
            Faculty_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Faculty_Id.Frozen = true;
            Faculty_Id.HeaderText = "Faculty_Id";
            Faculty_Id.Name = "Faculty_Id";
            // 
            // Faculty_Name
            // 
            Faculty_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Faculty_Name.Frozen = true;
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
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 691);
            Name = "Form12";
            Text = "faculty_courses";
            Load += Form12_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn Faculty_Id;
        private DataGridViewTextBoxColumn Faculty_Name;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn designation_id;
    }
}