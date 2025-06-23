namespace Bismillah.UI
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            label6 = new Label();
            button4 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 2, 1);
            tableLayoutPanel1.Location = new Point(64, 297);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Size = new Size(955, 296);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 84);
            button1.Name = "button1";
            button1.Size = new Size(263, 53);
            button1.TabIndex = 0;
            button1.Text = "Add Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 35, 66);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(321, 84);
            button2.Name = "button2";
            button2.Size = new Size(263, 53);
            button2.TabIndex = 1;
            button2.Text = "Edit/Delete Product";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 45.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(321, 0);
            label2.Name = "label2";
            label2.Size = new Size(302, 81);
            label2.TabIndex = 6;
            label2.Text = "✏️";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 56F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(279, 81);
            label3.TabIndex = 7;
            label3.Text = "✚";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(10, 35, 66);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(321, 226);
            button3.Name = "button3";
            button3.Size = new Size(263, 53);
            button3.TabIndex = 2;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 56F);
            label4.Location = new Point(321, 140);
            label4.Name = "label4";
            label4.Size = new Size(263, 81);
            label4.TabIndex = 8;
            label4.Text = "⮜";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 45.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(639, 0);
            label6.Name = "label6";
            label6.Size = new Size(284, 81);
            label6.TabIndex = 10;
            label6.Text = "👀";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 35, 66);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(639, 84);
            button4.Name = "button4";
            button4.Size = new Size(263, 53);
            button4.TabIndex = 9;
            button4.Text = "View Products";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Location = new Point(1, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1263, 125);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(10, 35, 66);
            label5.Location = new Point(43, 149);
            label5.Name = "label5";
            label5.Size = new Size(904, 53);
            label5.TabIndex = 5;
            label5.Text = "Product Management";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(192, 37);
            label1.Name = "label1";
            label1.Size = new Size(845, 51);
            label1.TabIndex = 2;
            label1.Text = "Bismillah Sanitary Electric and Hardware Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 550);
            Controls.Add(label5);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductManagement";
            Text = "Product Management";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button button4;
        private Label label6;
        private Label label1;
    }
}