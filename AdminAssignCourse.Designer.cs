namespace DBS25P131
{
    partial class AdminAssignCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAssignCourse));
            CoursesPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            button2 = new Button();
            CoursesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // CoursesPanel
            // 
            CoursesPanel.BackColor = Color.FromArgb(240, 187, 120);
            CoursesPanel.Controls.Add(pictureBox1);
            CoursesPanel.Controls.Add(label1);
            CoursesPanel.Controls.Add(pictureBox7);
            CoursesPanel.Controls.Add(label4);
            CoursesPanel.Controls.Add(pictureBox4);
            CoursesPanel.Controls.Add(label6);
            CoursesPanel.Controls.Add(label2);
            CoursesPanel.Controls.Add(button2);
            CoursesPanel.Dock = DockStyle.Fill;
            CoursesPanel.Location = new Point(0, 0);
            CoursesPanel.Name = "CoursesPanel";
            CoursesPanel.Size = new Size(746, 551);
            CoursesPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 481);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 72;
            label1.Text = "Faculty Management";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(137, 112);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(173, 139);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 69;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(424, 273);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 67;
            label4.Text = "Workload Assignment";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(429, 112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(173, 139);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 62;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(143, 270);
            label6.Name = "label6";
            label6.Size = new Size(167, 28);
            label6.TabIndex = 70;
            label6.Text = "Faculty Management";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 40);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 58;
            label2.Text = "Worload Assignment";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(15, 997);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Go back";
            button2.UseVisualStyleBackColor = false;
            // 
            // AdminAssignCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 551);
            Controls.Add(CoursesPanel);
            Name = "AdminAssignCourse";
            Text = "AdminAssignCourse";
            CoursesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CoursesPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox7;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label2;
        private Button button2;
    }
}