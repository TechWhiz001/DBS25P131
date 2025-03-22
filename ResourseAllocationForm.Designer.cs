namespace DBS25P131.PresentationLayer
{
    partial class ResourseAllocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourseAllocationForm));
            WorkloadPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            WorkloadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // WorkloadPanel
            // 
            WorkloadPanel.BackColor = Color.FromArgb(240, 187, 120);
            WorkloadPanel.Controls.Add(pictureBox1);
            WorkloadPanel.Controls.Add(pictureBox7);
            WorkloadPanel.Controls.Add(label4);
            WorkloadPanel.Controls.Add(pictureBox4);
            WorkloadPanel.Controls.Add(label6);
            WorkloadPanel.Controls.Add(label1);
            WorkloadPanel.Controls.Add(label2);
            WorkloadPanel.Controls.Add(button2);
            WorkloadPanel.Location = new Point(3, 0);
            WorkloadPanel.Name = "WorkloadPanel";
            WorkloadPanel.Size = new Size(939, 617);
            WorkloadPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(736, 715);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 72;
            label1.Text = "Workload Assignment";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 19);
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
            button2.Location = new Point(15, 1093);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Go back";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 339);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(237, 158);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(173, 119);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 75;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(527, 302);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 74;
            label4.Text = "Workload Assignment";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(529, 158);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(173, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 73;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(246, 299);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 76;
            label6.Text = "Faculty Management";
            // 
            // ResourseAllocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 620);
            Controls.Add(WorkloadPanel);
            MinimumSize = new Size(959, 659);
            Name = "ResourseAllocationForm";
            Text = "ResourseAllocationForm";
            WorkloadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel WorkloadPanel;
        private Label label1;
        private Label label2;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label6;
    }
}