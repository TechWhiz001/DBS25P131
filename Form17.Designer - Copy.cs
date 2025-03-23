namespace DBS25P131
{
    partial class ProjectAllocationForm
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
            name = new DataGridViewTextBoxColumn();
            Project_Id = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox2 = new GroupBox();
            DesrichTextBox1 = new RichTextBox();
            Assignbutton = new Button();
            TltextBox3 = new TextBox();
            label8 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 308);
            panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, Project_Id, email });
            dataGridView1.Location = new Point(147, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 194);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // name
            // 
            name.HeaderText = "Title";
            name.Name = "name";
            // 
            // Project_Id
            // 
            Project_Id.HeaderText = "Project_Id";
            Project_Id.Name = "Project_Id";
            // 
            // email
            // 
            email.HeaderText = "Description";
            email.Name = "email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(447, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 0;
            label1.Text = "Projects";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(240, 187, 120);
            groupBox2.Controls.Add(DesrichTextBox1);
            groupBox2.Controls.Add(Assignbutton);
            groupBox2.Controls.Add(TltextBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(2, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(941, 305);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // DesrichTextBox1
            // 
            DesrichTextBox1.Location = new Point(358, 163);
            DesrichTextBox1.Name = "DesrichTextBox1";
            DesrichTextBox1.Size = new Size(260, 35);
            DesrichTextBox1.TabIndex = 40;
            DesrichTextBox1.Text = "";
            DesrichTextBox1.TextChanged += DesrichTextBox1_TextChanged;
            // 
            // Assignbutton
            // 
            Assignbutton.Anchor = AnchorStyles.None;
            Assignbutton.BackColor = Color.FromArgb(19, 16, 16);
            Assignbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Assignbutton.ForeColor = Color.White;
            Assignbutton.Location = new Point(810, 213);
            Assignbutton.Name = "Assignbutton";
            Assignbutton.Size = new Size(76, 34);
            Assignbutton.TabIndex = 39;
            Assignbutton.Text = "Add";
            Assignbutton.UseVisualStyleBackColor = false;
            Assignbutton.Click += Assignbutton_Click;
            // 
            // TltextBox3
            // 
            TltextBox3.Anchor = AnchorStyles.None;
            TltextBox3.Location = new Point(358, 90);
            TltextBox3.Name = "TltextBox3";
            TltextBox3.Size = new Size(260, 25);
            TltextBox3.TabIndex = 37;
            TltextBox3.TextChanged += textBox3_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(237, 163);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 35;
            label8.Text = "Description";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(237, 90);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 34;
            label3.Text = "Title";
            // 
            // ProjectAllocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 620);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            MinimumSize = new Size(959, 659);
            Name = "ProjectAllocationForm";
            Text = "projects";
            Load += ProjectForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox2;
        private Button Assignbutton;
        private TextBox TltextBox3;
        private Label label8;
        private Label label3;
        private RichTextBox DesrichTextBox1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Project_Id;
        private DataGridViewTextBoxColumn email;
    }
}