namespace DBS25P131
{
    partial class HeadDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadDepartment));
            label6 = new Label();
            Resources = new Button();
            Workload = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Requests = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            Logout = new Button();
            dashworkpanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 13);
            label6.Name = "label6";
            label6.Size = new Size(431, 23);
            label6.TabIndex = 0;
            label6.Text = "Faculty Workload and Resource Allocation ";
            label6.Click += label6_Click;
            // 
            // Resources
            // 
            Resources.FlatStyle = FlatStyle.Flat;
            Resources.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resources.ForeColor = SystemColors.ButtonHighlight;
            Resources.Location = new Point(13, 404);
            Resources.Name = "Resources";
            Resources.Size = new Size(175, 34);
            Resources.TabIndex = 2;
            Resources.Text = "Resources";
            Resources.UseVisualStyleBackColor = true;
            Resources.Click += Resources_Click;
            // 
            // Workload
            // 
            Workload.FlatStyle = FlatStyle.Flat;
            Workload.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Workload.ForeColor = SystemColors.ButtonHighlight;
            Workload.Location = new Point(13, 210);
            Workload.Name = "Workload";
            Workload.Size = new Size(174, 34);
            Workload.TabIndex = 6;
            Workload.Text = "Workload Assigment";
            Workload.UseVisualStyleBackColor = true;
            Workload.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 187, 120);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 62);
            panel2.TabIndex = 19;
            // 
            // Requests
            // 
            Requests.FlatStyle = FlatStyle.Flat;
            Requests.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Requests.ForeColor = SystemColors.ButtonHighlight;
            Requests.Location = new Point(13, 306);
            Requests.Name = "Requests";
            Requests.Size = new Size(174, 34);
            Requests.TabIndex = 1;
            Requests.Text = "Requests";
            Requests.UseVisualStyleBackColor = true;
            Requests.Click += Requests_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 58, 20);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(Workload);
            panel1.Controls.Add(Resources);
            panel1.Controls.Add(Requests);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 590);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Location = new Point(197, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 607);
            panel3.TabIndex = 20;
            // 
            // Logout
            // 
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.ButtonHighlight;
            Logout.Location = new Point(11, 515);
            Logout.Name = "Logout";
            Logout.Size = new Size(174, 34);
            Logout.TabIndex = 7;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            // 
            // dashworkpanel
            // 
            dashworkpanel.BackgroundImage = (Image)resources.GetObject("dashworkpanel.BackgroundImage");
            dashworkpanel.BackgroundImageLayout = ImageLayout.Stretch;
            dashworkpanel.Dock = DockStyle.Fill;
            dashworkpanel.Location = new Point(200, 62);
            dashworkpanel.Name = "dashworkpanel";
            dashworkpanel.Size = new Size(762, 590);
            dashworkpanel.TabIndex = 20;
            dashworkpanel.Paint += panel4_Paint;
            // 
            // HeadDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(dashworkpanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimumSize = new Size(978, 691);
            Name = "HeadDepartment";
            Text = "HeadDepart";
            Load += Form23_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Button Resources;
        private Button Workload;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button Requests;
        private Panel panel1;
        private Button Logout;
        private Panel panel3;
        private Panel dashworkpanel;
    }
}