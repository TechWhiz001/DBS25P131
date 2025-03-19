namespace DBS25P131
{
    partial class WorkloadAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkloadAssign));
            button2 = new Button();
            WorkloadPanel = new Panel();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            WorkloadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(15, 546);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Go back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // WorkloadPanel
            // 
            WorkloadPanel.BackColor = Color.FromArgb(240, 187, 120);
            WorkloadPanel.Controls.Add(label1);
            WorkloadPanel.Controls.Add(pictureBox1);
            WorkloadPanel.Controls.Add(pictureBox7);
            WorkloadPanel.Controls.Add(label4);
            WorkloadPanel.Controls.Add(pictureBox4);
            WorkloadPanel.Controls.Add(label6);
            WorkloadPanel.Controls.Add(label2);
            WorkloadPanel.Controls.Add(button2);
            WorkloadPanel.Dock = DockStyle.Fill;
            WorkloadPanel.Location = new Point(0, 0);
            WorkloadPanel.MinimumSize = new Size(762, 590);
            WorkloadPanel.Name = "WorkloadPanel";
            WorkloadPanel.Size = new Size(762, 590);
            WorkloadPanel.TabIndex = 2;
            WorkloadPanel.Paint += panel1_Paint;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(149, 118);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(173, 119);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 69;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(439, 262);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 67;
            label4.Text = "Workload Assignment";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(441, 118);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(173, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 62;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(158, 259);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 70;
            label6.Text = "Faculty Management";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 9);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 58;
            label2.Text = "Worload Assignment";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 443);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 72;
            label1.Text = "Workload Assignment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 299);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // WorkloadAssign
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 590);
            Controls.Add(WorkloadPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(762, 590);
            Name = "WorkloadAssign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkloadAssign";
            WorkloadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Panel WorkloadPanel;
        private Label label2;
        private PictureBox pictureBox7;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label6;
        private Label label1;
        private PictureBox pictureBox1;
    }
}