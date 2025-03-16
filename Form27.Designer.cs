namespace DBS25P131
{
    partial class Resource
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
            button1 = new Button();
            button6 = new Button();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Item_Id = new DataGridViewTextBoxColumn();
            Item_Type = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 58, 20);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(30, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 335);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 35;
            button1.Text = "Goback";
            button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.ForeColor = Color.White;
            button6.Location = new Point(780, 191);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 34;
            button6.Text = "Allocate";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 113);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 23;
            label3.Text = "Resource\r\n";
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 48);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 21;
            label1.Text = "Rescourse type\r\n";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(471, 48);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 20;
            label5.Text = "Faculty Member";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(84, 58, 20);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(30, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 247);
            panel2.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item_Id, Item_Type, Name, Quantity });
            dataGridView1.Location = new Point(25, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(841, 184);
            dataGridView1.TabIndex = 0;
            // 
            // Item_Id
            // 
            Item_Id.HeaderText = "Item_Id";
            Item_Id.Name = "Item_Id";
            // 
            // Item_Type
            // 
            Item_Type.HeaderText = "Item_Type";
            Item_Type.Name = "Item_Type";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(341, 12);
            label2.Name = "label2";
            label2.Size = new Size(211, 39);
            label2.TabIndex = 24;
            label2.Text = "Resource_Allocation";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(606, 46);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(260, 25);
            textBox6.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 25);
            textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 25);
            textBox2.TabIndex = 38;
            // 
            // Resource
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 652);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Resource";
            Text = "Form27";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label3;
        private Label label1;
        private Button button6;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private DataGridViewTextBoxColumn Item_Id;
        private DataGridViewTextBoxColumn Item_Type;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
    }
}