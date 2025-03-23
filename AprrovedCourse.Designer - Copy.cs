namespace DBS25P131
{
    partial class CourseAllocatiomForm
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
            groupBox1 = new GroupBox();
            AAddbutton = new Button();
            acomboboxtype = new ComboBox();
            achours = new TextBox();
            acontacthours = new TextBox();
            acname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            designation_id = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AAddbutton);
            groupBox1.Controls.Add(acomboboxtype);
            groupBox1.Controls.Add(achours);
            groupBox1.Controls.Add(acontacthours);
            groupBox1.Controls.Add(acname);
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
            // AAddbutton
            // 
            AAddbutton.BackColor = Color.FromArgb(19, 16, 16);
            AAddbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AAddbutton.ForeColor = Color.White;
            AAddbutton.Location = new Point(839, 186);
            AAddbutton.Name = "AAddbutton";
            AAddbutton.Size = new Size(76, 34);
            AAddbutton.TabIndex = 57;
            AAddbutton.Text = "Add";
            AAddbutton.UseVisualStyleBackColor = false;
            AAddbutton.Click += AAddbutton_Click;
            // 
            // acomboboxtype
            // 
            acomboboxtype.FormattingEnabled = true;
            acomboboxtype.Items.AddRange(new object[] { "Theory", "Lab" });
            acomboboxtype.Location = new Point(196, 89);
            acomboboxtype.Name = "acomboboxtype";
            acomboboxtype.Size = new Size(260, 25);
            acomboboxtype.TabIndex = 65;
            // 
            // achours
            // 
            achours.Location = new Point(628, 20);
            achours.Name = "achours";
            achours.Size = new Size(260, 25);
            achours.TabIndex = 64;
            // 
            // acontacthours
            // 
            acontacthours.Location = new Point(628, 87);
            acontacthours.Name = "acontacthours";
            acontacthours.Size = new Size(260, 25);
            acontacthours.TabIndex = 63;
            // 
            // acname
            // 
            acname.Location = new Point(196, 26);
            acname.Name = "acname";
            acname.Size = new Size(260, 25);
            acname.TabIndex = 61;
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
            label5.Location = new Point(61, 89);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 59;
            label5.Text = "Course Type";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 35);
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
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, email, contact, designation_id, Update, Delete });
            dataGridView1.Location = new Point(14, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(965, 179);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // Update
            // 
            Update.HeaderText = "Update";
            Update.Name = "Update";
            Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.UseColumnTextForButtonValue = true;
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
            button1.Click += button1_Click;
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
            // CourseAllocatiomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 573);
            Controls.Add(panel1);
            MinimumSize = new Size(999, 590);
            Name = "CourseAllocatiomForm";
            Text = "AprrovedCourse";
            Load += AprrovedCourse_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox acomboboxtype;
        private TextBox achours;
        private TextBox acontacthours;
        private TextBox acname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Button AAddbutton;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn designation_id;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
    }
}