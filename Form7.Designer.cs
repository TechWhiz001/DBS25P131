namespace DBS25P131
{
    partial class Form7
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
            button2 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(359, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 502);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Assign Course to Faculty";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(120, 465);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 11;
            button2.Text = "Assign";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(196, 379);
            label5.Name = "label5";
            label5.Size = new Size(198, 23);
            label5.TabIndex = 9;
            label5.Text = "Faculty Member";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 325);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 33);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 415);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 33);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(229, 201);
            label4.Name = "label4";
            label4.Size = new Size(176, 23);
            label4.TabIndex = 6;
            label4.Text = "Semester";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(196, 286);
            label3.Name = "label3";
            label3.Size = new Size(198, 23);
            label3.TabIndex = 5;
            label3.Text = "Faculty Member";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(120, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 33);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 118);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 3;
            label2.Text = "Courses\r\n";
            label2.TextAlign = ContentAlignment.BottomCenter;
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(120, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 33);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 33);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 29);
            label1.Name = "label1";
            label1.Size = new Size(198, 23);
            label1.TabIndex = 0;
            label1.Text = "Faculty Member";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(groupBox1);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignCourses";
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private Button button2;
        private Label label5;
    }
}