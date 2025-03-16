namespace DBS25P131
{
    partial class WorkloadAssign
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
            button4 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            faculty_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Designation_Id = new DataGridViewTextBoxColumn();
            Research = new DataGridViewTextBoxColumn();
            research_area = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(19, 16, 16);
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(810, 351);
            button4.Name = "button4";
            button4.Size = new Size(95, 34);
            button4.TabIndex = 31;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(21, 353);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Go back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(12, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 411);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 21);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 58;
            label2.Text = "Worload Assignment";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { faculty_id, name, Designation_Id, Research, research_area });
            dataGridView1.Location = new Point(21, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(884, 241);
            dataGridView1.TabIndex = 59;
            // 
            // faculty_id
            // 
            faculty_id.HeaderText = "faculty_id";
            faculty_id.Name = "faculty_id";
            // 
            // name
            // 
            name.HeaderText = "Faculty name";
            name.Name = "name";
            // 
            // Designation_Id
            // 
            Designation_Id.HeaderText = "Designation_id";
            Designation_Id.Name = "Designation_Id";
            // 
            // Research
            // 
            Research.HeaderText = "Research_Area";
            Research.Name = "Research";
            // 
            // research_area
            // 
            research_area.HeaderText = "Total workload";
            research_area.Name = "research_area";
            // 
            // WorkloadAssign
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 691);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(978, 691);
            Name = "WorkloadAssign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkloadAssign";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button2;
        private Panel panel1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn faculty_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Designation_Id;
        private DataGridViewTextBoxColumn Research;
        private DataGridViewTextBoxColumn research_area;
    }
}