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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Item_Id = new DataGridViewTextBoxColumn();
            Item_Type = new DataGridViewTextBoxColumn();
            IName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            button6 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(84, 58, 20);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 316);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(302, 8);
            label2.Name = "label2";
            label2.Size = new Size(211, 39);
            label2.TabIndex = 24;
            label2.Text = "Resource_Allocation";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item_Id, Item_Type, IName, Quantity });
            dataGridView1.Location = new Point(25, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(710, 129);
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
            // IName
            // 
            IName.HeaderText = "Name";
            IName.Name = "IName";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(84, 58, 20);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(0, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 266);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resourses Details";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 25);
            textBox2.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 25);
            textBox1.TabIndex = 45;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(547, 29);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(196, 25);
            textBox6.TabIndex = 44;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(417, 31);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 39;
            label5.Text = "Faculty Member";
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 40;
            label1.Text = "Rescourse type\r\n";
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 94);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 41;
            label3.Text = "Resource\r\n";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(19, 16, 16);
            button6.ForeColor = Color.White;
            button6.Location = new Point(668, 204);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 42;
            button6.Text = "Allocate";
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(19, 16, 16);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 206);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 43;
            button1.Text = "Goback";
            button1.UseVisualStyleBackColor = false;
            // 
            // Resource
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 590);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(762, 590);
            Name = "Resource";
            Text = "Form27";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn Item_Id;
        private DataGridViewTextBoxColumn Item_Type;
        private DataGridViewTextBoxColumn IName;
        private DataGridViewTextBoxColumn Quantity;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label5;
        private Label label1;
        private Label label3;
        private Button button6;
        private Button button1;
    }
}