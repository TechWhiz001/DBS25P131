namespace DBS25P131.PresentationLayer
{
    partial class RoomAllocation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Allocation_ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Faculty_Name = new DataGridViewTextBoxColumn();
            Room_id = new DataGridViewTextBoxColumn();
            Room_Name = new DataGridViewTextBoxColumn();
            Room_Type = new DataGridViewTextBoxColumn();
            Term = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            Reserved_Hour = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            RtypetextBox3 = new TextBox();
            rhoursetextBox2 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            RItextBox1 = new TextBox();
            AssignButton = new Button();
            FNcomboBox1 = new ComboBox();
            button1 = new Button();
            label9 = new Label();
            RnameCombobox = new ComboBox();
            FItextBox5 = new TextBox();
            TermcomboBox2 = new ComboBox();
            label3 = new Label();
            YearcomboBox1 = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
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
            panel1.Location = new Point(-10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 284);
            panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Allocation_ID, name, Faculty_Name, Room_id, Room_Name, Room_Type, Term, year, Reserved_Hour, Update, Delete });
            dataGridView1.Location = new Point(13, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(938, 220);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Allocation_ID
            // 
            Allocation_ID.HeaderText = "Allocation_ID";
            Allocation_ID.Name = "Allocation_ID";
            // 
            // name
            // 
            name.HeaderText = "Faculty_id";
            name.Name = "name";
            // 
            // Faculty_Name
            // 
            Faculty_Name.HeaderText = "Faculty_Name";
            Faculty_Name.Name = "Faculty_Name";
            // 
            // Room_id
            // 
            Room_id.HeaderText = "Room_id";
            Room_id.Name = "Room_id";
            // 
            // Room_Name
            // 
            Room_Name.HeaderText = "Room_Name";
            Room_Name.Name = "Room_Name";
            // 
            // Room_Type
            // 
            Room_Type.HeaderText = "Room_Type";
            Room_Type.Name = "Room_Type";
            // 
            // Term
            // 
            Term.HeaderText = "Term";
            Term.Name = "Term";
            // 
            // year
            // 
            year.HeaderText = "Year";
            year.Name = "year";
            // 
            // Reserved_Hour
            // 
            Reserved_Hour.HeaderText = "Reserved_Hour";
            Reserved_Hour.Name = "Reserved_Hour";
            // 
            // Update
            // 
            Update.HeaderText = "Update";
            Update.Name = "Update";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(437, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 0;
            label1.Text = "Rooms";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(240, 187, 120);
            groupBox1.Controls.Add(RtypetextBox3);
            groupBox1.Controls.Add(rhoursetextBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(RItextBox1);
            groupBox1.Controls.Add(AssignButton);
            groupBox1.Controls.Add(FNcomboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(RnameCombobox);
            groupBox1.Controls.Add(FItextBox5);
            groupBox1.Controls.Add(TermcomboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(YearcomboBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(-10, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(963, 335);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rooms Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // RtypetextBox3
            // 
            RtypetextBox3.Anchor = AnchorStyles.None;
            RtypetextBox3.Location = new Point(177, 184);
            RtypetextBox3.Name = "RtypetextBox3";
            RtypetextBox3.Size = new Size(260, 33);
            RtypetextBox3.TabIndex = 134;
            RtypetextBox3.TextChanged += RtypetextBox3_TextChanged;
            // 
            // rhoursetextBox2
            // 
            rhoursetextBox2.Anchor = AnchorStyles.None;
            rhoursetextBox2.Location = new Point(642, 188);
            rhoursetextBox2.Name = "rhoursetextBox2";
            rhoursetextBox2.Size = new Size(260, 33);
            rhoursetextBox2.TabIndex = 133;
            rhoursetextBox2.TextChanged += rhoursetextBox2_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 194);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 131;
            label5.Text = "Room Type";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(492, 190);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 129;
            label2.Text = "Reserved_hour";
            label2.Click += label2_Click;
            // 
            // RItextBox1
            // 
            RItextBox1.Location = new Point(644, 49);
            RItextBox1.Name = "RItextBox1";
            RItextBox1.Size = new Size(260, 33);
            RItextBox1.TabIndex = 128;
            RItextBox1.TextChanged += RItextBox1_TextChanged;
            // 
            // AssignButton
            // 
            AssignButton.Anchor = AnchorStyles.None;
            AssignButton.BackColor = Color.FromArgb(19, 16, 16);
            AssignButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AssignButton.ForeColor = Color.White;
            AssignButton.Location = new Point(829, 243);
            AssignButton.Name = "AssignButton";
            AssignButton.Size = new Size(75, 32);
            AssignButton.TabIndex = 55;
            AssignButton.Text = "Add";
            AssignButton.UseVisualStyleBackColor = false;
            AssignButton.Click += AssignButton_Click;
            // 
            // FNcomboBox1
            // 
            FNcomboBox1.Anchor = AnchorStyles.None;
            FNcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            FNcomboBox1.FormattingEnabled = true;
            FNcomboBox1.Location = new Point(177, 47);
            FNcomboBox1.Name = "FNcomboBox1";
            FNcomboBox1.Size = new Size(260, 33);
            FNcomboBox1.TabIndex = 127;
            FNcomboBox1.SelectedIndexChanged += FNcomboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 535);
            button1.Name = "button1";
            button1.Size = new Size(111, 34);
            button1.TabIndex = 50;
            button1.Text = "Go to Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 94);
            label9.Name = "label9";
            label9.Size = new Size(106, 23);
            label9.TabIndex = 126;
            label9.Text = "Faculty_Id";
            // 
            // RnameCombobox
            // 
            RnameCombobox.Anchor = AnchorStyles.None;
            RnameCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            RnameCombobox.FormattingEnabled = true;
            RnameCombobox.Location = new Point(177, 137);
            RnameCombobox.Name = "RnameCombobox";
            RnameCombobox.Size = new Size(260, 33);
            RnameCombobox.TabIndex = 122;
            RnameCombobox.SelectedIndexChanged += RnameCombobox_SelectedIndexChanged;
            // 
            // FItextBox5
            // 
            FItextBox5.Location = new Point(177, 94);
            FItextBox5.Name = "FItextBox5";
            FItextBox5.Size = new Size(260, 33);
            FItextBox5.TabIndex = 125;
            FItextBox5.TextChanged += FItextBox5_TextChanged;
            // 
            // TermcomboBox2
            // 
            TermcomboBox2.Anchor = AnchorStyles.None;
            TermcomboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            TermcomboBox2.FormattingEnabled = true;
            TermcomboBox2.Location = new Point(644, 139);
            TermcomboBox2.Name = "TermcomboBox2";
            TermcomboBox2.Size = new Size(260, 33);
            TermcomboBox2.TabIndex = 124;
            TermcomboBox2.SelectedIndexChanged += TermcomboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 49);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 115;
            label3.Text = "Faculty_Name";
            // 
            // YearcomboBox1
            // 
            YearcomboBox1.Anchor = AnchorStyles.None;
            YearcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            YearcomboBox1.FormattingEnabled = true;
            YearcomboBox1.Location = new Point(644, 98);
            YearcomboBox1.Name = "YearcomboBox1";
            YearcomboBox1.Size = new Size(260, 33);
            YearcomboBox1.TabIndex = 123;
            YearcomboBox1.SelectedIndexChanged += YearcomboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 137);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 121;
            label8.Text = "Room_Name";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(489, 49);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 118;
            label4.Text = "Room_id";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(489, 100);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 120;
            label7.Text = "Year";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(489, 141);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 119;
            label6.Text = "Term";
            // 
            // RoomAllocation
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 620);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "RoomAllocation";
            Text = "RoomAllocation";
            Load += RoomAllocation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button AssignButton;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox RItextBox1;
        private ComboBox FNcomboBox1;
        private Label label9;
        private ComboBox RnameCombobox;
        private TextBox FItextBox5;
        private ComboBox TermcomboBox2;
        private Label label3;
        private ComboBox YearcomboBox1;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label5;
        private DataGridViewTextBoxColumn Allocation_ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Faculty_Name;
        private DataGridViewTextBoxColumn Room_id;
        private DataGridViewTextBoxColumn Room_Name;
        private DataGridViewTextBoxColumn Room_Type;
        private DataGridViewTextBoxColumn Term;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn Reserved_Hour;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Delete;
        private TextBox rhoursetextBox2;
        private TextBox RtypetextBox3;
    }
}