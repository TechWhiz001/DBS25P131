namespace DBS25P131
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            FacultyProfiles = new Button();
            button5 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(13, 534);
            button2.Name = "button2";
            button2.Size = new Size(174, 34);
            button2.TabIndex = 8;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FacultyProfiles
            // 
            FacultyProfiles.FlatStyle = FlatStyle.Flat;
            FacultyProfiles.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FacultyProfiles.ForeColor = SystemColors.ButtonHighlight;
            FacultyProfiles.Location = new Point(11, 227);
            FacultyProfiles.Name = "FacultyProfiles";
            FacultyProfiles.Size = new Size(174, 34);
            FacultyProfiles.TabIndex = 6;
            FacultyProfiles.Text = "Faculty Profiles\r\n";
            FacultyProfiles.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(11, 329);
            button5.Name = "button5";
            button5.Size = new Size(175, 34);
            button5.TabIndex = 5;
            button5.Text = "Assign Courses";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(12, 428);
            button4.Name = "button4";
            button4.Size = new Size(174, 34);
            button4.TabIndex = 4;
            button4.Text = "Process Faculty Request";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 187, 120);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 42);
            panel2.TabIndex = 31;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(278, 9);
            label6.Name = "label6";
            label6.Size = new Size(431, 23);
            label6.TabIndex = 0;
            label6.Text = "Faculty Workload and Resource Allocation ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 58, 20);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(FacultyProfiles);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 610);
            panel1.TabIndex = 30;
            // 
            // Administrator
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Administrator";
            Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox1;
        private Button FacultyProfiles;
        private Button button5;
        private Button button4;
        private Panel panel2;
        private Label label6;
        private Panel panel1;
    }
}