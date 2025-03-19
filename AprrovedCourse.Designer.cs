namespace DBS25P131
{
    partial class AprrovedCourse
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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            course_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            designation_id = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, -20);
            panel1.MinimumSize = new Size(999, 590);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 590);
            panel1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(871, 527);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 53;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, email, contact, designation_id });
            dataGridView1.Location = new Point(14, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(965, 179);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 527);
            button1.Name = "button1";
            button1.Size = new Size(93, 32);
            button1.TabIndex = 52;
            button1.Text = "Go to back";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 29);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 0;
            label1.Text = "Courses_Allocation";
            // 
            // course_id
            // 
            course_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            course_id.Frozen = true;
            course_id.HeaderText = "course_id";
            course_id.Name = "course_id";
            course_id.Width = 150;
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
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(14, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(965, 243);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 29);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 67;
            label2.Text = "Course_Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 25);
            textBox1.TabIndex = 66;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Theory", "Lab" });
            comboBox1.Location = new Point(204, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 25);
            comboBox1.TabIndex = 65;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(628, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(260, 25);
            textBox5.TabIndex = 64;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(628, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 25);
            textBox4.TabIndex = 63;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 25);
            textBox2.TabIndex = 61;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(504, 22);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 60;
            label6.Text = "Credit Hours";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 150);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 59;
            label5.Text = "Course Type";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 96);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 58;
            label4.Text = "Course_Name";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(504, 87);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 57;
            label7.Text = "Contact Hours";
            // 
            // AprrovedCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 551);
            Controls.Add(panel1);
            MinimumSize = new Size(999, 590);
            Name = "AprrovedCourse";
            Text = "AprrovedCourse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn designation_id;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
    }
}