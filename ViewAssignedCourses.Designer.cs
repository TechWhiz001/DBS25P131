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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            course_id = new DataGridViewTextBoxColumn();
            Faculty_Id = new DataGridViewTextBoxColumn();
            Faculty_Name = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            designation_id = new DataGridViewTextBoxColumn();
            Term = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 650);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, Faculty_Id, Faculty_Name, name, email, contact, designation_id, Term, Year });
            dataGridView1.Location = new Point(9, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(930, 362);
            dataGridView1.TabIndex = 27;
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
            // Term
            // 
            Term.HeaderText = "Term";
            Term.Name = "Term";
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.Name = "Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 35);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 0;
            label1.Text = "Faculty_Courses";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(817, 598);
            button6.Name = "button6";
            button6.Size = new Size(113, 32);
            button6.TabIndex = 51;
            button6.Text = "Assign Schedule";
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(9, 598);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 52;
            button1.Text = "Approved";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(665, 598);
            button2.Name = "button2";
            button2.Size = new Size(116, 32);
            button2.TabIndex = 53;
            button2.Text = "Allocate Room";
            button2.UseVisualStyleBackColor = false;
            // 
            // ViewAssignedCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel1);
            Name = "ViewAssignedCourses";
            Text = "ViewAssignedCourses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn Faculty_Id;
        private DataGridViewTextBoxColumn Faculty_Name;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn designation_id;
        private DataGridViewTextBoxColumn Term;
        private DataGridViewTextBoxColumn Year;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button6;
    }
}