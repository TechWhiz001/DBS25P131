namespace DBS25P131
{
    partial class Projects
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            course_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 187, 120);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 235);
            panel2.TabIndex = 15;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.ForeColor = Color.White;
            button6.Location = new Point(656, 137);
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
            button5.Location = new Point(130, 135);
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
            button4.Location = new Point(321, 137);
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
            button3.Location = new Point(248, 195);
            button3.Name = "button3";
            button3.Size = new Size(86, 34);
            button3.TabIndex = 30;
            button3.Text = "Delate";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(495, 19);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(236, 25);
            textBox6.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 25);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 25);
            textBox2.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(553, 137);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(405, 20);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 21;
            label8.Text = "Description";
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 66);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 16;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 20);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 15;
            label2.Text = "Project_id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 317);
            panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, email });
            dataGridView1.Location = new Point(30, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 194);
            dataGridView1.TabIndex = 0;
            // 
            // course_id
            // 
            course_id.HeaderText = "Project_id";
            course_id.Name = "course_id";
            // 
            // name
            // 
            name.HeaderText = "Title";
            name.Name = "name";
            // 
            // email
            // 
            email.HeaderText = "Description";
            email.Name = "email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 0;
            label1.Text = "Projects";
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 551);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(762, 590);
            Name = "Projects";
            Text = "projects";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button6;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Label label8;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
    }
}