namespace DBS25P131
{
    partial class submitRequest
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
            RDdateTimePicker1 = new DateTimePicker();
            QnumericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label1 = new Label();
            RescomboBox1 = new ComboBox();
            button6 = new Button();
            FNtextBox3 = new TextBox();
            FitextBox2 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QnumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(240, 187, 120);
            panel2.Controls.Add(RDdateTimePicker1);
            panel2.Controls.Add(QnumericUpDown1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(RescomboBox1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(FNtextBox3);
            panel2.Controls.Add(FitextBox2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 640);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // RDdateTimePicker1
            // 
            RDdateTimePicker1.Location = new Point(399, 421);
            RDdateTimePicker1.Name = "RDdateTimePicker1";
            RDdateTimePicker1.Size = new Size(255, 25);
            RDdateTimePicker1.TabIndex = 53;
            RDdateTimePicker1.ValueChanged += RDdateTimePicker1_ValueChanged;
            // 
            // QnumericUpDown1
            // 
            QnumericUpDown1.Location = new Point(399, 351);
            QnumericUpDown1.Name = "QnumericUpDown1";
            QnumericUpDown1.Size = new Size(255, 25);
            QnumericUpDown1.TabIndex = 52;
            QnumericUpDown1.ValueChanged += QnumericUpDown1_ValueChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(276, 352);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 51;
            label6.Text = "Quantity";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 34);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 49;
            label1.Text = "Submit Request";
            // 
            // RescomboBox1
            // 
            RescomboBox1.FormattingEnabled = true;
            RescomboBox1.Items.AddRange(new object[] { "Classroom", "Lab", "Stationary" });
            RescomboBox1.Location = new Point(403, 287);
            RescomboBox1.Name = "RescomboBox1";
            RescomboBox1.Size = new Size(260, 25);
            RescomboBox1.TabIndex = 48;
            RescomboBox1.SelectedIndexChanged += RescomboBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.ForeColor = Color.White;
            button6.Location = new Point(579, 510);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 47;
            button6.Text = "Submit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // FNtextBox3
            // 
            FNtextBox3.Location = new Point(403, 214);
            FNtextBox3.Name = "FNtextBox3";
            FNtextBox3.Size = new Size(260, 25);
            FNtextBox3.TabIndex = 43;
            FNtextBox3.TextChanged += FNtextBox3_TextChanged;
            // 
            // FitextBox2
            // 
            FitextBox2.Location = new Point(403, 150);
            FitextBox2.Name = "FitextBox2";
            FitextBox2.Size = new Size(260, 25);
            FitextBox2.TabIndex = 42;
            FitextBox2.TextChanged += FitextBox2_TextChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(273, 289);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 39;
            label8.Text = "Resource";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(276, 421);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 38;
            label5.Text = "Request Date";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(287, 216);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 36;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(285, 152);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 35;
            label2.Text = "Faculty_Id";
            // 
            // submitRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel2);
            Name = "submitRequest";
            Text = "Form29";
            Load += submitRequest_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QnumericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox RescomboBox1;
        private Button button6;
        private TextBox FNtextBox3;
        private TextBox FitextBox2;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private NumericUpDown QnumericUpDown1;
        private DateTimePicker RDdateTimePicker1;
    }
}