namespace DBS25P131
{
    partial class requestStatus
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            course_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Facultyname = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Request_date = new DataGridViewTextBoxColumn();
            supervision_hours = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 652);
            panel1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(708, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 25);
            comboBox1.TabIndex = 35;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.ForeColor = Color.White;
            button1.Location = new Point(627, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 34;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, Facultyname, email, Request_date, supervision_hours });
            dataGridView1.Location = new Point(30, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 430);
            dataGridView1.TabIndex = 0;
            // 
            // course_id
            // 
            course_id.HeaderText = "Request_id";
            course_id.Name = "course_id";
            // 
            // name
            // 
            name.HeaderText = "User_id";
            name.Name = "name";
            // 
            // Facultyname
            // 
            Facultyname.HeaderText = "Name";
            Facultyname.Name = "Facultyname";
            // 
            // email
            // 
            email.HeaderText = "Request Type";
            email.Name = "email";
            // 
            // Request_date
            // 
            Request_date.HeaderText = "Request_date";
            Request_date.Name = "Request_date";
            // 
            // supervision_hours
            // 
            supervision_hours.HeaderText = "Status";
            supervision_hours.Name = "supervision_hours";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "Requests_Status";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(30, 579);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Go back";
            button2.UseVisualStyleBackColor = false;
            // 
            // requestStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel1);
            Name = "requestStatus";
            Text = "Form30";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Facultyname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Request_date;
        private DataGridViewTextBoxColumn supervision_hours;
    }
}