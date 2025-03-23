namespace DBS25P131
{
    partial class semestersAllocationForm
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
            comboBox1 = new ComboBox();
            button5 = new Button();
            label8 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            course_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Spring", "Summer", "Fall" });
            comboBox1.Location = new Point(351, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 33);
            comboBox1.TabIndex = 34;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(19, 16, 16);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(535, 241);
            button5.Name = "button5";
            button5.Size = new Size(76, 34);
            button5.TabIndex = 32;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(235, 145);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 21;
            label8.Text = "Year";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 79);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 16;
            label3.Text = "Term";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 300);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, email });
            dataGridView1.Location = new Point(30, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // course_id
            // 
            course_id.HeaderText = "Semester_id";
            course_id.Name = "course_id";
            // 
            // name
            // 
            name.HeaderText = "Term";
            name.Name = "name";
            name.Resizable = DataGridViewTriState.True;
            // 
            // email
            // 
            email.HeaderText = "Year";
            email.Name = "email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "Semesters";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(240, 187, 120);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(962, 349);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Semester Details";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Spring", "Summer", "Fall" });
            comboBox2.Location = new Point(351, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(260, 33);
            comboBox2.TabIndex = 35;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // semestersAllocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 691);
            Name = "semestersAllocationForm";
            Text = "semestersForm";
            Load += Form19_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Label label8;
        private Label label3;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn course_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
    }
}