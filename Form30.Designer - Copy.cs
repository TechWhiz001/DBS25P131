namespace DBS25P131
{
    partial class requestStatusform
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            request_id = new DataGridViewTextBoxColumn();
            faculty_id = new DataGridViewTextBoxColumn();
            Facultyname = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            Request_date = new DataGridViewTextBoxColumn();
            supervision_hours = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 187, 120);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 652);
            panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { request_id, faculty_id, Facultyname, email, quantity, Request_date, supervision_hours });
            dataGridView1.Location = new Point(30, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 430);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "Requests_Status";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(19, 16, 16);
            button2.ForeColor = Color.White;
            button2.Location = new Point(30, 579);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 22;
            button2.Text = "Go back";
            button2.UseVisualStyleBackColor = false;
            // 
            // request_id
            // 
            request_id.HeaderText = "request_id";
            request_id.Name = "request_id";
            // 
            // faculty_id
            // 
            faculty_id.HeaderText = "faculty_id";
            faculty_id.Name = "faculty_id";
            // 
            // Facultyname
            // 
            Facultyname.HeaderText = "Name";
            Facultyname.Name = "Facultyname";
            // 
            // email
            // 
            email.HeaderText = "Request Type";
            email.Name = "email";
            // 
            // quantity
            // 
            quantity.HeaderText = "quantity";
            quantity.Name = "quantity";
            // 
            // Request_date
            // 
            Request_date.HeaderText = "Request_date";
            Request_date.Name = "Request_date";
            // 
            // supervision_hours
            // 
            supervision_hours.HeaderText = "Status";
            supervision_hours.Name = "supervision_hours";
            // 
            // requestStatusform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel1);
            Name = "requestStatusform";
            Text = "Form30";
            Load += requestStatus_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private DataGridViewTextBoxColumn request_id;
        private DataGridViewTextBoxColumn faculty_id;
        private DataGridViewTextBoxColumn Facultyname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn Request_date;
        private DataGridViewTextBoxColumn supervision_hours;
    }
}