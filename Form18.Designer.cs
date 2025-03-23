namespace DBS25P131
{
    partial class RoomAllocationForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            RAssignbutton = new Button();
            label8 = new Label();
            label3 = new Label();
            captextBox1 = new TextBox();
            RtypetextBox1 = new TextBox();
            RntextBox2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 302);
            panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { course_id, name, email, contact });
            dataGridView1.Location = new Point(25, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(909, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // course_id
            // 
            course_id.HeaderText = "Room_id";
            course_id.Name = "course_id";
            // 
            // name
            // 
            name.HeaderText = "Room_name";
            name.Name = "name";
            // 
            // email
            // 
            email.HeaderText = "Room_type";
            email.Name = "email";
            email.Resizable = DataGridViewTriState.True;
            // 
            // contact
            // 
            contact.HeaderText = "Capacity";
            contact.Name = "contact";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 0;
            label1.Text = "Rooms";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(240, 187, 120);
            groupBox1.Controls.Add(RntextBox2);
            groupBox1.Controls.Add(RtypetextBox1);
            groupBox1.Controls.Add(captextBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(RAssignbutton);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(-1, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(963, 348);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rooms Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 300);
            button1.Name = "button1";
            button1.Size = new Size(111, 34);
            button1.TabIndex = 50;
            button1.Text = "Go to Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 176);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 48;
            label4.Text = "Room_type";
            // 
            // RAssignbutton
            // 
            RAssignbutton.Anchor = AnchorStyles.None;
            RAssignbutton.BackColor = Color.FromArgb(19, 16, 16);
            RAssignbutton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RAssignbutton.ForeColor = Color.White;
            RAssignbutton.Location = new Point(816, 192);
            RAssignbutton.Name = "RAssignbutton";
            RAssignbutton.Size = new Size(75, 32);
            RAssignbutton.TabIndex = 47;
            RAssignbutton.Text = "Save";
            RAssignbutton.UseVisualStyleBackColor = false;
            RAssignbutton.Click += RAssignbutton_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(524, 95);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 39;
            label8.Text = "Capacity";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 91);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 38;
            label3.Text = "Room_name";
            // 
            // captextBox1
            // 
            captextBox1.Location = new Point(632, 89);
            captextBox1.Name = "captextBox1";
            captextBox1.Size = new Size(260, 33);
            captextBox1.TabIndex = 129;
            captextBox1.TextChanged += captextBox1_TextChanged;
            // 
            // RtypetextBox1
            // 
            RtypetextBox1.Location = new Point(181, 176);
            RtypetextBox1.Name = "RtypetextBox1";
            RtypetextBox1.Size = new Size(260, 33);
            RtypetextBox1.TabIndex = 130;
            RtypetextBox1.TextChanged += RtypetextBox1_TextChanged;
            // 
            // RntextBox2
            // 
            RntextBox2.Location = new Point(181, 85);
            RntextBox2.Name = "RntextBox2";
            RntextBox2.Size = new Size(260, 33);
            RntextBox2.TabIndex = 131;
            RntextBox2.TextChanged += RntextBox2_TextChanged;
            // 
            // RoomAllocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 691);
            Name = "RoomAllocationForm";
            Text = "rooms";
            Load += RoomAllocationForm_Load;
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
        private GroupBox groupBox1;
        private Label label4;
        private Button RAssignbutton;
        private Label label8;
        private Label label3;
        private Button button1;
        private TextBox RntextBox2;
        private TextBox RtypetextBox1;
        private TextBox captextBox1;
    }
}