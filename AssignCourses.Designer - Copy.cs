namespace DBS25P131
{
    partial class AssignCourses
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
            groupBox1 = new GroupBox();
            AssignCourseButton = new Button();
            fNameComboBox = new ComboBox();
            CncomboBox4 = new ComboBox();
            fIdtextBox3 = new TextBox();
            label8 = new Label();
            yearcomboBox2 = new ComboBox();
            cIdetextBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            termcomboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            Ctypecombobox = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(240, 187, 120);
            groupBox1.Controls.Add(AssignCourseButton);
            groupBox1.Controls.Add(fNameComboBox);
            groupBox1.Controls.Add(CncomboBox4);
            groupBox1.Controls.Add(fIdtextBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(yearcomboBox2);
            groupBox1.Controls.Add(cIdetextBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(termcomboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Ctypecombobox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(944, 623);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Assignment";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // AssignCourseButton
            // 
            AssignCourseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AssignCourseButton.BackColor = Color.FromArgb(19, 16, 16);
            AssignCourseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AssignCourseButton.ForeColor = Color.White;
            AssignCourseButton.Location = new Point(827, 349);
            AssignCourseButton.Name = "AssignCourseButton";
            AssignCourseButton.Size = new Size(75, 32);
            AssignCourseButton.TabIndex = 121;
            AssignCourseButton.Text = "Assign ";
            AssignCourseButton.UseVisualStyleBackColor = false;
            AssignCourseButton.Click += AssignCourseButton_Click;
            // 
            // fNameComboBox
            // 
            fNameComboBox.Anchor = AnchorStyles.None;
            fNameComboBox.FormattingEnabled = true;
            fNameComboBox.Location = new Point(198, 253);
            fNameComboBox.Name = "fNameComboBox";
            fNameComboBox.Size = new Size(260, 33);
            fNameComboBox.TabIndex = 120;
            fNameComboBox.SelectedIndexChanged += fNameComboBox_SelectedIndexChanged;
            // 
            // CncomboBox4
            // 
            CncomboBox4.Anchor = AnchorStyles.None;
            CncomboBox4.FormattingEnabled = true;
            CncomboBox4.Location = new Point(198, 107);
            CncomboBox4.Name = "CncomboBox4";
            CncomboBox4.Size = new Size(260, 33);
            CncomboBox4.TabIndex = 119;
            CncomboBox4.SelectedIndexChanged += CncomboBox4_SelectedIndexChanged;
            // 
            // fIdtextBox3
            // 
            fIdtextBox3.Anchor = AnchorStyles.None;
            fIdtextBox3.Location = new Point(198, 336);
            fIdtextBox3.Name = "fIdtextBox3";
            fIdtextBox3.Size = new Size(260, 33);
            fIdtextBox3.TabIndex = 117;
            fIdtextBox3.TextChanged += fIdtextBox3_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(76, 338);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 115;
            label8.Text = "Faculty Id";
            // 
            // yearcomboBox2
            // 
            yearcomboBox2.Anchor = AnchorStyles.None;
            yearcomboBox2.FormattingEnabled = true;
            yearcomboBox2.Location = new Point(642, 179);
            yearcomboBox2.Name = "yearcomboBox2";
            yearcomboBox2.Size = new Size(260, 33);
            yearcomboBox2.TabIndex = 114;
            yearcomboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cIdetextBox2
            // 
            cIdetextBox2.Anchor = AnchorStyles.None;
            cIdetextBox2.Location = new Point(198, 177);
            cIdetextBox2.Name = "cIdetextBox2";
            cIdetextBox2.Size = new Size(260, 33);
            cIdetextBox2.TabIndex = 113;
            cIdetextBox2.TextChanged += cIdetextBox2_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(520, 179);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 112;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 177);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 111;
            label4.Text = "Course Id";
            label4.Click += label4_Click;
            // 
            // termcomboBox1
            // 
            termcomboBox1.Anchor = AnchorStyles.None;
            termcomboBox1.FormattingEnabled = true;
            termcomboBox1.Location = new Point(642, 251);
            termcomboBox1.Name = "termcomboBox1";
            termcomboBox1.Size = new Size(260, 33);
            termcomboBox1.TabIndex = 110;
            termcomboBox1.SelectedIndexChanged += termcomboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 253);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 108;
            label1.Text = "Term";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 253);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 107;
            label2.Text = "Faculty Name";
            // 
            // Ctypecombobox
            // 
            Ctypecombobox.Anchor = AnchorStyles.None;
            Ctypecombobox.FormattingEnabled = true;
            Ctypecombobox.Location = new Point(642, 107);
            Ctypecombobox.Name = "Ctypecombobox";
            Ctypecombobox.Size = new Size(260, 33);
            Ctypecombobox.TabIndex = 106;
            Ctypecombobox.SelectedIndexChanged += Ctypecombobox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(520, 107);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 104;
            label5.Text = "Course Type";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(76, 107);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 103;
            label7.Text = "Course_Name";
            // 
            // AssignCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 620);
            Controls.Add(groupBox1);
            MaximumSize = new Size(959, 659);
            Name = "AssignCourses";
            Text = "AssignCourses";
            Load += AssignCourses_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox yearcomboBox2;
        private TextBox cIdetextBox2;
        private Label label3;
        private Label label4;
        private ComboBox termcomboBox1;
        private Label label1;
        private Label label2;
        private ComboBox Ctypecombobox;
        private Label label5;
        private Label label7;
        private TextBox fIdtextBox3;
        private Label label8;
        private ComboBox CncomboBox4;
        private ComboBox fNameComboBox;
        private Button AssignCourseButton;
    }
}