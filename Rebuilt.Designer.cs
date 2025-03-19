namespace DBS25P131
{
    partial class Rebuilt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rebuilt));
            FirstPagepanel = new Panel();
            SuspendLayout();
            // 
            // FirstPagepanel
            // 
            FirstPagepanel.BackgroundImage = (Image)resources.GetObject("FirstPagepanel.BackgroundImage");
            FirstPagepanel.BackgroundImageLayout = ImageLayout.Stretch;
            FirstPagepanel.Location = new Point(2, 2);
            FirstPagepanel.Name = "FirstPagepanel";
            FirstPagepanel.Size = new Size(963, 586);
            FirstPagepanel.TabIndex = 0;
            FirstPagepanel.Paint += FirstPagepanel_Paint;
            // 
            // Rebuilt
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 589);
            Controls.Add(FirstPagepanel);
            MaximumSize = new Size(978, 628);
            Name = "Rebuilt";
            Text = "Rebuilt";
            ResumeLayout(false);
        }

        #endregion

        private Panel FirstPagepanel;
    }
}