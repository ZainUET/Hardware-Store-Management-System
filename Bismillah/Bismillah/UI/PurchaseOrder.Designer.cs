namespace Bismillah.UI
{
    partial class PurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            cmbSuppliers = new ComboBox();
            txtSupplierContact = new TextBox();
            cmbProducts = new ComboBox();
            nudQuantity = new NumericUpDown();
            btnAddItem = new Button();
            dgvOrderItems = new DataGridView();
            lblSubtotal = new Label();
            lblTotal = new Label();
            txtSubtotal = new TextBox();
            txtTotal = new TextBox();
            btnSave = new Button();
            btnPrint = new Button();
            btnClear = new Button();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel3.Size = new Size(1157, 125);
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
            label5.Location = new Point(-42, 129);
            label5.Name = "label5";
            label5.Size = new Size(904, 53);
            label5.TabIndex = 5;
            label5.Text = "Purchase Order";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(27, 20);
            cmbSuppliers.Margin = new Padding(2);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(180, 25);
            cmbSuppliers.TabIndex = 6;
            cmbSuppliers.SelectedIndexChanged += cmbSuppliers_SelectedIndexChanged;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Location = new Point(27, 57);
            txtSupplierContact.Margin = new Padding(2);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.PlaceholderText = "CNIC";
            txtSupplierContact.Size = new Size(180, 25);
            txtSupplierContact.TabIndex = 7;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(111, 256);
            cmbProducts.Margin = new Padding(2);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(238, 23);
            cmbProducts.TabIndex = 8;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(396, 254);
            nudQuantity.Margin = new Padding(2);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(82, 23);
            nudQuantity.TabIndex = 9;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(10, 35, 66);
            btnAddItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(549, 250);
            btnAddItem.Margin = new Padding(2);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(109, 26);
            btnAddItem.TabIndex = 11;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.BackgroundColor = Color.White;
            dgvOrderItems.BorderStyle = BorderStyle.None;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(98, 284);
            dgvOrderItems.Margin = new Padding(2);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(701, 361);
            dgvOrderItems.TabIndex = 12;
            dgvOrderItems.CellContentClick += dgvOrderItems_CellContentClick;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotal.Location = new Point(985, 416);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(69, 19);
            lblSubtotal.TabIndex = 13;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(985, 461);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 19);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(1057, 416);
            txtSubtotal.Margin = new Padding(2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(131, 23);
            txtSubtotal.TabIndex = 16;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1057, 461);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(131, 23);
            txtTotal.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(10, 35, 66);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(2, 2);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 32);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(10, 35, 66);
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(131, 2);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(103, 32);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(10, 35, 66);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(2, 47);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 32);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear ";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(10, 35, 66);
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(131, 47);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 32);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSuppliers);
            groupBox1.Controls.Add(txtSupplierContact);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(983, 197);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(228, 90);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Supplier:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnPrint, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClose, 1, 1);
            tableLayoutPanel1.Controls.Add(btnClear, 0, 1);
            tableLayoutPanel1.Location = new Point(983, 537);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(259, 90);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(111, 238);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 28;
            label2.Text = "Select Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(396, 236);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 29;
            label3.Text = "Quantity:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(176, 37);
            label1.Name = "label1";
            label1.Size = new Size(845, 51);
            label1.TabIndex = 2;
            label1.Text = "Bismillah Sanitary Electric and Hardware Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 579);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(txtTotal);
            Controls.Add(txtSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(dgvOrderItems);
            Controls.Add(btnAddItem);
            Controls.Add(nudQuantity);
            Controls.Add(cmbProducts);
            Controls.Add(label5);
            Controls.Add(tableLayoutPanel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PurchaseOrder";
            Text = "Purchase Order";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox2;
        private Label label5;
        private ComboBox cmbSuppliers;
        private TextBox txtSupplierContact;
        private ComboBox cmbProducts;
        private NumericUpDown nudQuantity;
        private Button btnAddItem;
        private DataGridView dgvOrderItems;
        private Label lblSubtotal;
        private Label lblTotal;
        private TextBox txtSubtotal;
        private TextBox txtTotal;
        private Button btnSave;
        private Button btnPrint;
        private Button btnClear;
        private Button btnClose;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}