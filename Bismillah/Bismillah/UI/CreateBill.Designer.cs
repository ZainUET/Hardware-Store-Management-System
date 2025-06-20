namespace Bismillah.UI
{
    partial class CreateBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBill));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            grpcustomertype = new GroupBox();
            rdregular = new RadioButton();
            rdWalkin = new RadioButton();
            cmbSelectProducts = new ComboBox();
            numQuantity = new NumericUpDown();
            dvgProductsinBill = new DataGridView();
            cmbCustomer = new ComboBox();
            grpRegularCustomer = new GroupBox();
            customerLoyaltyPoints = new Label();
            customerCNIC = new Label();
            txtdiscount = new TextBox();
            BillDate = new DateTimePicker();
            btnRemove = new Button();
            txtBillNumber = new TextBox();
            lblSubtotal = new Label();
            SubTotal = new Label();
            Total = new Label();
            lblTotal = new Label();
            btnSave = new Button();
            btnPrint = new Button();
            cmbPaymentStatus = new ComboBox();
            btnAddProduct = new Button();
            btnApplyDiscount = new Button();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpcustomertype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductsinBill).BeginInit();
            grpRegularCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.69863F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.30137F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(1, 0);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(2406, 208);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(333, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpcustomertype
            // 
            grpcustomertype.Controls.Add(rdregular);
            grpcustomertype.Controls.Add(rdWalkin);
            grpcustomertype.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpcustomertype.Location = new Point(1500, 217);
            grpcustomertype.Name = "grpcustomertype";
            grpcustomertype.Size = new Size(203, 150);
            grpcustomertype.TabIndex = 5;
            grpcustomertype.TabStop = false;
            grpcustomertype.Text = "Customer Type:";
            // 
            // rdregular
            // 
            rdregular.AutoSize = true;
            rdregular.Location = new Point(36, 38);
            rdregular.Name = "rdregular";
            rdregular.Size = new Size(110, 32);
            rdregular.TabIndex = 1;
            rdregular.TabStop = true;
            rdregular.Text = "Regular";
            rdregular.UseVisualStyleBackColor = true;
            rdregular.CheckedChanged += rdregular_CheckedChanged;
            // 
            // rdWalkin
            // 
            rdWalkin.AutoSize = true;
            rdWalkin.Location = new Point(36, 78);
            rdWalkin.Name = "rdWalkin";
            rdWalkin.Size = new Size(108, 32);
            rdWalkin.TabIndex = 0;
            rdWalkin.TabStop = true;
            rdWalkin.Text = "Walk In";
            rdWalkin.UseVisualStyleBackColor = true;
            //rdWalkin.CheckedChanged += rdWalkin_CheckedChanged;
            // 
            // cmbSelectProducts
            // 
            cmbSelectProducts.FormattingEnabled = true;
            cmbSelectProducts.Location = new Point(49, 372);
            cmbSelectProducts.Name = "cmbSelectProducts";
            cmbSelectProducts.Size = new Size(450, 33);
            cmbSelectProducts.TabIndex = 6;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(549, 372);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(124, 31);
            numQuantity.TabIndex = 7;
            // 
            // dvgProductsinBill
            // 
            dvgProductsinBill.AllowUserToAddRows = false;
            dvgProductsinBill.AllowUserToDeleteRows = false;
            dvgProductsinBill.AllowUserToResizeColumns = false;
            dvgProductsinBill.AllowUserToResizeRows = false;
            dvgProductsinBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgProductsinBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dvgProductsinBill.BackgroundColor = Color.White;
            dvgProductsinBill.BorderStyle = BorderStyle.None;
            dvgProductsinBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductsinBill.Location = new Point(51, 452);
            dvgProductsinBill.Name = "dvgProductsinBill";
            dvgProductsinBill.ReadOnly = true;
            dvgProductsinBill.RowHeadersWidth = 62;
            dvgProductsinBill.Size = new Size(960, 625);
            dvgProductsinBill.TabIndex = 8;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(41, 58);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(315, 36);
            cmbCustomer.TabIndex = 9;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // grpRegularCustomer
            // 
            grpRegularCustomer.Controls.Add(customerLoyaltyPoints);
            grpRegularCustomer.Controls.Add(customerCNIC);
            grpRegularCustomer.Controls.Add(cmbCustomer);
            grpRegularCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRegularCustomer.Location = new Point(1500, 382);
            grpRegularCustomer.Name = "grpRegularCustomer";
            grpRegularCustomer.Size = new Size(381, 220);
            grpRegularCustomer.TabIndex = 10;
            grpRegularCustomer.TabStop = false;
            grpRegularCustomer.Text = "Regular Customers";
            grpRegularCustomer.Visible = false;
            // 
            // customerLoyaltyPoints
            // 
            customerLoyaltyPoints.AutoSize = true;
            customerLoyaltyPoints.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customerLoyaltyPoints.Location = new Point(106, 155);
            customerLoyaltyPoints.Name = "customerLoyaltyPoints";
            customerLoyaltyPoints.Size = new Size(0, 28);
            customerLoyaltyPoints.TabIndex = 11;
            // 
            // customerCNIC
            // 
            customerCNIC.AutoSize = true;
            customerCNIC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customerCNIC.Location = new Point(106, 107);
            customerCNIC.Name = "customerCNIC";
            customerCNIC.Size = new Size(0, 28);
            customerCNIC.TabIndex = 10;
            // 
            // txtdiscount
            // 
            txtdiscount.Location = new Point(1500, 722);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.PlaceholderText = "Discount";
            txtdiscount.Size = new Size(150, 31);
            txtdiscount.TabIndex = 11;
            // 
            // BillDate
            // 
            BillDate.CustomFormat = "";
            BillDate.Format = DateTimePickerFormat.Short;
            BillDate.Location = new Point(49, 273);
            BillDate.Name = "BillDate";
            BillDate.Size = new Size(147, 31);
            BillDate.TabIndex = 12;
            BillDate.Value = new DateTime(2025, 6, 14, 13, 17, 21, 0);
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.White;
            btnRemove.Location = new Point(873, 367);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(129, 37);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtBillNumber
            // 
            txtBillNumber.Location = new Point(240, 277);
            txtBillNumber.Name = "txtBillNumber";
            txtBillNumber.Size = new Size(150, 31);
            txtBillNumber.TabIndex = 14;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 12F);
            lblSubtotal.Location = new Point(1661, 663);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 32);
            lblSubtotal.TabIndex = 15;
            // 
            // SubTotal
            // 
            SubTotal.AutoSize = true;
            SubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SubTotal.Location = new Point(1500, 663);
            SubTotal.Name = "SubTotal";
            SubTotal.Size = new Size(120, 32);
            SubTotal.TabIndex = 16;
            SubTotal.Text = "SubTotal:";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Total.Location = new Point(1500, 785);
            Total.Name = "Total";
            Total.Size = new Size(77, 32);
            Total.TabIndex = 17;
            Total.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(1604, 785);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1509, 960);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 33);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1704, 960);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(111, 33);
            btnPrint.TabIndex = 20;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            //btnPrint.Click += btnPrint_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(1500, 893);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(331, 33);
            cmbPaymentStatus.TabIndex = 21;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.White;
            btnAddProduct.Location = new Point(709, 367);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(129, 37);
            btnAddProduct.TabIndex = 22;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BackColor = Color.White;
            btnApplyDiscount.Location = new Point(1676, 722);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(129, 32);
            btnApplyDiscount.TabIndex = 23;
            btnApplyDiscount.Text = "Apply";
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(1500, 843);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 24;
            label1.Text = "Payment:";
            // 
            // CreateBill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1878, 944);
            Controls.Add(label1);
            Controls.Add(btnApplyDiscount);
            Controls.Add(btnAddProduct);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(btnPrint);
            Controls.Add(btnSave);
            Controls.Add(lblTotal);
            Controls.Add(Total);
            Controls.Add(SubTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(txtBillNumber);
            Controls.Add(btnRemove);
            Controls.Add(BillDate);
            Controls.Add(txtdiscount);
            Controls.Add(grpRegularCustomer);
            Controls.Add(dvgProductsinBill);
            Controls.Add(numQuantity);
            Controls.Add(cmbSelectProducts);
            Controls.Add(grpcustomertype);
            Controls.Add(tableLayoutPanel2);
            Name = "CreateBill";
            Text = "CreateBill";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpcustomertype.ResumeLayout(false);
            grpcustomertype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductsinBill).EndInit();
            grpRegularCustomer.ResumeLayout(false);
            grpRegularCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox grpcustomertype;
        private RadioButton rdregular;
        private RadioButton rdWalkin;
        private ComboBox cmbSelectProducts;
        private NumericUpDown numQuantity;
        private DataGridView dvgProductsinBill;
        private ComboBox cmbCustomer;
        private GroupBox grpRegularCustomer;
        private Label customerLoyaltyPoints;
        private Label customerCNIC;
        private TextBox txtdiscount;
        private DateTimePicker BillDate;
        private Button btnRemove;
        private TextBox txtBillNumber;
        private Label lblSubtotal;
        private Label SubTotal;
        private Label Total;
        private Label lblTotal;
        private Button btnSave;
        private Button btnPrint;
        private ComboBox cmbPaymentStatus;
        private Button btnAddProduct;
        private Button btnApplyDiscount;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}