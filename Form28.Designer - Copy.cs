namespace DBS25P131
{
    partial class facultyMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facultyMember));
            label6 = new Label();
            pictureBox1 = new PictureBox();
            Workload = new Button();
            Resources = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            Requests = new Button();
            panel1 = new Panel();
            Logout = new Button();
            dashfacultypanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(312, 9);
            label6.Name = "label6";
            label6.Size = new Size(431, 23);
            label6.TabIndex = 0;
            label6.Text = "Faculty Workload and Resource Allocation ";
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
            // Workload
            // 
            Workload.FlatStyle = FlatStyle.Flat;
            Workload.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Workload.ForeColor = SystemColors.ButtonHighlight;
            Workload.Location = new Point(13, 210);
            Workload.Name = "Workload";
            Workload.Size = new Size(174, 34);
            Workload.TabIndex = 6;
            Workload.Text = "View Courses";
            Workload.UseVisualStyleBackColor = true;
            Workload.Click += Workload_Click;
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
            Resources.Text = "Request Status";
            Resources.UseVisualStyleBackColor = true;
            Resources.Click += Resources_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 187, 120);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 42);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Location = new Point(196, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(769, 617);
            panel3.TabIndex = 0;
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
            Requests.Text = "Resource Requests";
            Requests.UseVisualStyleBackColor = true;
            Requests.Click += Requests_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 58, 20);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(Workload);
            panel1.Controls.Add(Resources);
            panel1.Controls.Add(Requests);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 679);
            panel1.TabIndex = 20;
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
            // dashfacultypanel
            // 
            dashfacultypanel.Dock = DockStyle.Fill;
            dashfacultypanel.Location = new Point(200, 42);
            dashfacultypanel.Name = "dashfacultypanel";
            dashfacultypanel.Size = new Size(959, 679);
            dashfacultypanel.TabIndex = 22;
            dashfacultypanel.Paint += dashworkpanel_Paint;
            // 
            // facultyMember
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 721);
            Controls.Add(dashfacultypanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximumSize = new Size(1175, 760);
            Name = "facultyMember";
            Text = "Form28";
            Load += facultyMember_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private PictureBox pictureBox1;
        private Button Workload;
        private Button Resources;
        private Panel panel2;
        private Button Requests;
        private Panel panel1;
        private Button Logout;
        private Panel panel3;
        private Panel dashfacultypanel;
    }
}