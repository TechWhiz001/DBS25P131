namespace DBS25P131
{
    partial class FacultyRequest
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
            button6 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            course_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Facultyname = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Request_date = new DataGridViewTextBoxColumn();
            supervision_hours = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.ForeColor = Color.White;
            button6.Location = new Point(779, 579);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 33;
            button6.Text = "Approve";
            button6.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(36, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 628);
            panel1.TabIndex = 10;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(19, 16, 16);
            button5.ForeColor = Color.White;
            button5.Location = new Point(686, 579);
            button5.Name = "button5";
            button5.Size = new Size(75, 32);
            button5.TabIndex = 38;
            button5.Text = "Reject";
            button5.UseVisualStyleBackColor = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, Facultyname, email, Quantity, Request_date, supervision_hours });
            dataGridView1.Location = new Point(30, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(845, 254);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 18);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "Faculty_Requests";
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
            // Facultyname
            // 
            Facultyname.HeaderText = "Faculty Name";
            Facultyname.Name = "Facultyname";
            // 
            // email
            // 
            email.HeaderText = "Request Type";
            email.Name = "email";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(30, 403);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 170);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resource Details";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(564, 37);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 29);
            textBox6.TabIndex = 65;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 29);
            textBox1.TabIndex = 66;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 29);
            textBox2.TabIndex = 67;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(444, 41);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 57;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 92);
            label3.Name = "label3";
            label3.Size = new Size(134, 24);
            label3.TabIndex = 58;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 37);
            label4.Name = "label4";
            label4.Size = new Size(134, 24);
            label4.TabIndex = 59;
            label4.Text = "Resource_Type";
            // 
            // FacultyRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel1);
            Name = "FacultyRequest";
            Text = "Form25";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button5;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Facultyname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Request_date;
        private DataGridViewTextBoxColumn supervision_hours;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}