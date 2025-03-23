namespace DBS25P131
{
    partial class facultyProfilesForm
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
            panel2 = new Panel();
            label4 = new Label();
            textBox4 = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            course_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            supervision_hours = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 187, 120);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(36, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 315);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 114);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 35;
            label4.Text = "Room_id";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 25);
            textBox4.TabIndex = 34;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.ForeColor = Color.White;
            button6.Location = new Point(746, 180);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 33;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(19, 16, 16);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(127, 180);
            button5.Name = "button5";
            button5.Size = new Size(76, 34);
            button5.TabIndex = 32;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(19, 16, 16);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(283, 180);
            button4.Name = "button4";
            button4.Size = new Size(95, 34);
            button4.TabIndex = 31;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(19, 16, 16);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(202, 241);
            button3.Name = "button3";
            button3.Size = new Size(86, 34);
            button3.TabIndex = 30;
            button3.Text = "Delate";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(587, 20);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 25);
            textBox6.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 25);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 25);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(587, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 25);
            textBox1.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(600, 180);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(441, 19);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 21;
            label8.Text = "Reserved_hours";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(441, 64);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 19;
            label5.Text = "Status_id";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 66);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 16;
            label3.Text = "Faculty_id";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 15;
            label2.Text = "Allocation_id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(36, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 283);
            panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, email, contact, supervision_hours });
            dataGridView1.Location = new Point(30, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 220);
            dataGridView1.TabIndex = 0;
            // 
            // course_id
            // 
            course_id.HeaderText = "Allocation_id";
            course_id.Name = "course_id";
            // 
            // name
            // 
            name.HeaderText = "Faculty_id";
            name.Name = "name";
            // 
            // email
            // 
            email.HeaderText = "Room_id";
            email.Name = "email";
            // 
            // contact
            // 
            contact.HeaderText = "Reserved_hours";
            contact.Name = "contact";
            // 
            // supervision_hours
            // 
            supervision_hours.HeaderText = "Semester_id";
            supervision_hours.Name = "supervision_hours";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "Faculty_Requests";
            // 
            // facultyProfilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 691);
            Name = "facultyProfilesForm";
            Text = "faculty_requests";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private TextBox textBox4;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn supervision_hours;
        private Label label1;
    }
}