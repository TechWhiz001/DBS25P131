namespace DBS25P131
{
    partial class Form6
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
            label1 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            name = new DataGridViewTextBoxColumn();
            designation_id = new DataGridViewTextBoxColumn();
            research_area = new DataGridViewTextBoxColumn();
            total_teaching_hours = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 283);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, designation_id, research_area, total_teaching_hours });
            dataGridView1.Location = new Point(31, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 0;
            label1.Text = "Faculty Management";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 187, 120);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox7);
            panel2.Location = new Point(12, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 315);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.ForeColor = Color.White;
            button6.Location = new Point(728, 149);
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
            textBox6.Location = new Point(543, 21);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 25);
            textBox6.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(543, 76);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(260, 25);
            textBox5.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 25);
            textBox1.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(543, 149);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(4, 80);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 21;
            label8.Text = "Designation ID";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(419, 78);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 20;
            label6.Text = "Teaching Hours";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(408, 21);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 19;
            label5.Text = "Research Area";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 15;
            label2.Text = "Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(127, 21);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(260, 25);
            textBox7.TabIndex = 14;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.Name = "name";
            // 
            // designation_id
            // 
            designation_id.HeaderText = "designation_id";
            designation_id.Name = "designation_id";
            // 
            // research_area
            // 
            research_area.HeaderText = "research_area";
            research_area.Name = "research_area";
            // 
            // total_teaching_hours
            // 
            total_teaching_hours.HeaderText = "total_teaching_hours";
            total_teaching_hours.Name = "total_teaching_hours";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 703);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(922, 703);
            Name = "Form6";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button button2;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button6;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn designation_id;
        private DataGridViewTextBoxColumn research_area;
        private DataGridViewTextBoxColumn total_teaching_hours;
    }
}