namespace DBS25P131
{
    partial class Form8
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
            textBox3 = new TextBox();
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
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(341, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 440);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Assign Final Year Project Supervision";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(120, 386);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 11;
            button2.Text = "Assign";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 33);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(223, 201);
            label4.Name = "label4";
            label4.Size = new Size(149, 23);
            label4.TabIndex = 6;
            label4.Text = " Student Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 284);
            label3.Name = "label3";
            label3.Size = new Size(198, 23);
            label3.TabIndex = 5;
            label3.Text = "Project Status";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(120, 322);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 33);
            comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 113);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 3;
            label2.Text = "Project Title";
            label2.TextAlign = ContentAlignment.BottomCenter;
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
            textBox1.TextChanged += textBox1_TextChanged;
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
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(groupBox1);
            Name = "Form8";
            Text = "Assign Finalproject";
            Load += Form8_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
    }
}