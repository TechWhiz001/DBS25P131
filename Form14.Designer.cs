namespace DBS25P131
{
    partial class Process_faculty_requests
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
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            supervision_hours = new DataGridViewTextBoxColumn();
            Request_date = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(36, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 366);
            panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, email, contact, supervision_hours, Request_date });
            dataGridView1.Location = new Point(34, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 312);
            dataGridView1.TabIndex = 0;
            // 
            // course_id
            // 
            course_id.HeaderText = "Request_id";
            course_id.Name = "course_id";
            // 
            // name
            // 
            name.HeaderText = "Faculty_id";
            name.Name = "name";
            // 
            // email
            // 
            email.HeaderText = "Item_id";
            email.Name = "email";
            // 
            // contact
            // 
            contact.HeaderText = "Quantity";
            contact.Name = "contact";
            // 
            // supervision_hours
            // 
            supervision_hours.HeaderText = "Status_id";
            supervision_hours.Name = "supervision_hours";
            // 
            // Request_date
            // 
            Request_date.HeaderText = "Request_date";
            Request_date.Name = "Request_date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 30);
            label1.TabIndex = 0;
            label1.Text = "Process_Faculty_Requests";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(84, 58, 20);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(36, 389);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(891, 251);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(461, 160);
            label6.Name = "label6";
            label6.Size = new Size(140, 23);
            label6.TabIndex = 49;
            label6.Text = "Request_id";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(607, 158);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(260, 25);
            textBox5.TabIndex = 48;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 160);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 47;
            label4.Text = "Item_id";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(179, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 25);
            textBox4.TabIndex = 46;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(607, 67);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 25);
            textBox6.TabIndex = 45;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 25);
            textBox3.TabIndex = 44;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 25);
            textBox2.TabIndex = 43;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(607, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 25);
            textBox1.TabIndex = 42;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(461, 65);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 41;
            label8.Text = "Quantity";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(461, 110);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 40;
            label5.Text = "Status_id";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 112);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 39;
            label3.Text = "Faculty_id";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 67);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 38;
            label2.Text = "Request_id";
            // 
            // Process_faculty_requests
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 691);
            Name = "Process_faculty_requests";
            Text = "faculty_requests";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn supervision_hours;
        private DataGridViewTextBoxColumn Request_date;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}