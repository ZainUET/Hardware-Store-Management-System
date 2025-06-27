namespace Bismillah.UI
{
    partial class ProductOrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOrderManagement));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            btnCreateOrder = new Button();
            btnReceiveOrder = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            dgvProductOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductOrders).BeginInit();
            SuspendLayout();
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(276, 37);
            label1.Name = "label1";
            label1.Size = new Size(845, 51);
            label1.TabIndex = 2;
            label1.Text = "Bismillah Sanitary Electric and Hardware Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel3.Size = new Size(1824, 125);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(10, 35, 66);
            label5.Location = new Point(218, 132);
            label5.Name = "label5";
            label5.Size = new Size(904, 53);
            label5.TabIndex = 5;
            label5.Text = "Purchase Order Management";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCreateOrder, 0, 1);
            tableLayoutPanel1.Controls.Add(btnReceiveOrder, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(145, 275);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1097, 341);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 56F);
            label4.Location = new Point(733, 0);
            label4.Name = "label4";
            label4.Size = new Size(263, 81);
            label4.TabIndex = 8;
            label4.Text = "⮜";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = Color.FromArgb(10, 35, 66);
            btnCreateOrder.Cursor = Cursors.Hand;
            btnCreateOrder.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateOrder.ForeColor = SystemColors.ButtonHighlight;
            btnCreateOrder.Location = new Point(3, 84);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(263, 53);
            btnCreateOrder.TabIndex = 0;
            btnCreateOrder.Text = "Create Purchase Order";
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnReceiveOrder
            // 
            btnReceiveOrder.BackColor = Color.FromArgb(10, 35, 66);
            btnReceiveOrder.Cursor = Cursors.Hand;
            btnReceiveOrder.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceiveOrder.ForeColor = SystemColors.ButtonHighlight;
            btnReceiveOrder.Location = new Point(368, 84);
            btnReceiveOrder.Name = "btnReceiveOrder";
            btnReceiveOrder.Size = new Size(263, 53);
            btnReceiveOrder.TabIndex = 1;
            btnReceiveOrder.Text = "Receive Purchase Order";
            btnReceiveOrder.UseVisualStyleBackColor = false;
            btnReceiveOrder.Click += btnReceiveOrder_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(10, 35, 66);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(733, 84);
            button3.Name = "button3";
            button3.Size = new Size(263, 53);
            button3.TabIndex = 2;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 45.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 0);
            label2.Name = "label2";
            label2.Size = new Size(291, 81);
            label2.TabIndex = 6;
            label2.Text = "✏️";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            // dgvProductOrders
            // 
            dgvProductOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductOrders.BackgroundColor = Color.White;
            dgvProductOrders.BorderStyle = BorderStyle.None;
            dgvProductOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductOrders.Location = new Point(305, 450);
            dgvProductOrders.Margin = new Padding(2);
            dgvProductOrders.Name = "dgvProductOrders";
            dgvProductOrders.RowHeadersWidth = 62;
            dgvProductOrders.Size = new Size(650, 205);
            dgvProductOrders.TabIndex = 6;
            // 
            // ProductOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1165, 601);
            Controls.Add(dgvProductOrders);
            Controls.Add(label5);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductOrderManagement";
            Text = "Staff Management";
            WindowState = FormWindowState.Maximized;
            Load += ProductOrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Button btnCreateOrder;
        private Button btnReceiveOrder;
        private Button button3;
        private Label label2;
        private Label label3;
        private DataGridView dgvProductOrders;
    }
}