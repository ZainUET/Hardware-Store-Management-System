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
            cmbSelectProducts = new ComboBox();
            numQuantity = new NumericUpDown();
            dvgProductsinBill = new DataGridView();
            cmbCustomer = new ComboBox();
            grpRegularCustomer = new GroupBox();
            customerLoyaltyPoints = new Label();
            customerCNIC = new Label();
            grpcustomers = new GroupBox();
            contacttxt = new TextBox();
            nametxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtdiscount = new TextBox();
            BillDate = new DateTimePicker();
            btnRemove = new Button();
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
            printPreviewDialog1 = new PrintPreviewDialog();
            rdWalkin = new RadioButton();
            rdregular = new RadioButton();
            grpcustomertype = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductsinBill).BeginInit();
            grpRegularCustomer.SuspendLayout();
            grpcustomers.SuspendLayout();
            grpcustomertype.SuspendLayout();
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
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(2373, 125);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 119);
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
            label2.Location = new Point(328, 37);
            label2.Name = "label2";
            label2.Size = new Size(845, 51);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSelectProducts
            // 
            cmbSelectProducts.FormattingEnabled = true;
            cmbSelectProducts.Location = new Point(34, 223);
            cmbSelectProducts.Margin = new Padding(2);
            cmbSelectProducts.Name = "cmbSelectProducts";
            cmbSelectProducts.Size = new Size(316, 23);
            cmbSelectProducts.TabIndex = 6;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(384, 223);
            numQuantity.Margin = new Padding(2);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(87, 23);
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
            dvgProductsinBill.Location = new Point(36, 271);
            dvgProductsinBill.Margin = new Padding(2);
            dvgProductsinBill.Name = "dvgProductsinBill";
            dvgProductsinBill.ReadOnly = true;
            dvgProductsinBill.RowHeadersWidth = 62;
            dvgProductsinBill.Size = new Size(844, 375);
            dvgProductsinBill.TabIndex = 8;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(29, 35);
            cmbCustomer.Margin = new Padding(2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(222, 25);
            cmbCustomer.TabIndex = 9;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // grpRegularCustomer
            // 
            grpRegularCustomer.Controls.Add(customerLoyaltyPoints);
            grpRegularCustomer.Controls.Add(customerCNIC);
            grpRegularCustomer.Controls.Add(cmbCustomer);
            grpRegularCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRegularCustomer.Location = new Point(1050, 229);
            grpRegularCustomer.Margin = new Padding(2);
            grpRegularCustomer.Name = "grpRegularCustomer";
            grpRegularCustomer.Padding = new Padding(2);
            grpRegularCustomer.Size = new Size(267, 132);
            grpRegularCustomer.TabIndex = 10;
            grpRegularCustomer.TabStop = false;
            grpRegularCustomer.Text = "Regular Customers";
            grpRegularCustomer.Visible = false;
            grpRegularCustomer.Enter += grpRegularCustomer_Enter;
            // 
            // customerLoyaltyPoints
            // 
            customerLoyaltyPoints.AutoSize = true;
            customerLoyaltyPoints.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customerLoyaltyPoints.Location = new Point(74, 93);
            customerLoyaltyPoints.Margin = new Padding(2, 0, 2, 0);
            customerLoyaltyPoints.Name = "customerLoyaltyPoints";
            customerLoyaltyPoints.Size = new Size(0, 19);
            customerLoyaltyPoints.TabIndex = 11;
            // 
            // customerCNIC
            // 
            customerCNIC.AutoSize = true;
            customerCNIC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customerCNIC.Location = new Point(74, 64);
            customerCNIC.Margin = new Padding(2, 0, 2, 0);
            customerCNIC.Name = "customerCNIC";
            customerCNIC.Size = new Size(0, 19);
            customerCNIC.TabIndex = 10;
            // 
            // grpcustomers
            // 
            grpcustomers.Controls.Add(contacttxt);
            grpcustomers.Controls.Add(nametxt);
            grpcustomers.Controls.Add(label3);
            grpcustomers.Controls.Add(label4);
            grpcustomers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpcustomers.Location = new Point(798, 238);
            grpcustomers.Margin = new Padding(2);
            grpcustomers.Name = "grpcustomers";
            grpcustomers.Padding = new Padding(2);
            grpcustomers.Size = new Size(248, 123);
            grpcustomers.TabIndex = 25;
            grpcustomers.TabStop = false;
            grpcustomers.Text = "Customer Details";
            // 
            // contacttxt
            // 
            contacttxt.Location = new Point(31, 92);
            contacttxt.Name = "contacttxt";
            contacttxt.PlaceholderText = "Contact";
            contacttxt.Size = new Size(208, 25);
            contacttxt.TabIndex = 13;
            contacttxt.KeyPress += contacttxt_KeyPress;
            contacttxt.Leave += contacttxt_Leave;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(31, 35);
            nametxt.Name = "nametxt";
            nametxt.PlaceholderText = "Name";
            nametxt.Size = new Size(208, 25);
            nametxt.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(73, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(73, 63);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 10;
            // 
            // txtdiscount
            // 
            txtdiscount.Location = new Point(1050, 433);
            txtdiscount.Margin = new Padding(2);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.PlaceholderText = "Discount";
            txtdiscount.Size = new Size(106, 23);
            txtdiscount.TabIndex = 11;
            // 
            // BillDate
            // 
            BillDate.CustomFormat = "";
            BillDate.Format = DateTimePickerFormat.Short;
            BillDate.Location = new Point(1135, 145);
            BillDate.Margin = new Padding(2);
            BillDate.Name = "BillDate";
            BillDate.Size = new Size(102, 23);
            BillDate.TabIndex = 12;
            BillDate.Value = new DateTime(2025, 6, 14, 13, 17, 21, 0);
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(10, 35, 66);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(611, 220);
            btnRemove.Margin = new Padding(2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(90, 28);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 12F);
            lblSubtotal.Location = new Point(1163, 398);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 21);
            lblSubtotal.TabIndex = 15;
            // 
            // SubTotal
            // 
            SubTotal.AutoSize = true;
            SubTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SubTotal.Location = new Point(1050, 398);
            SubTotal.Margin = new Padding(2, 0, 2, 0);
            SubTotal.Name = "SubTotal";
            SubTotal.Size = new Size(81, 21);
            SubTotal.TabIndex = 16;
            SubTotal.Text = "SubTotal:";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Total.Location = new Point(1050, 471);
            Total.Margin = new Padding(2, 0, 2, 0);
            Total.Name = "Total";
            Total.Size = new Size(52, 21);
            Total.TabIndex = 17;
            Total.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(1123, 471);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 21);
            lblTotal.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(10, 35, 66);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1050, 542);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 30);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(10, 35, 66);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1193, 542);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(89, 30);
            btnPrint.TabIndex = 20;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(1050, 518);
            cmbPaymentStatus.Margin = new Padding(2);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(233, 23);
            cmbPaymentStatus.TabIndex = 21;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(10, 35, 66);
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(496, 220);
            btnAddProduct.Margin = new Padding(2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(90, 28);
            btnAddProduct.TabIndex = 22;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BackColor = Color.FromArgb(10, 35, 66);
            btnApplyDiscount.Cursor = Cursors.Hand;
            btnApplyDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApplyDiscount.ForeColor = Color.White;
            btnApplyDiscount.Location = new Point(1173, 428);
            btnApplyDiscount.Margin = new Padding(2);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(90, 24);
            btnApplyDiscount.TabIndex = 23;
            btnApplyDiscount.Text = "Apply";
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(1050, 497);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 24;
            label1.Text = "Payment:";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // rdWalkin
            // 
            rdWalkin.AutoSize = true;
            rdWalkin.Location = new Point(25, 47);
            rdWalkin.Margin = new Padding(2);
            rdWalkin.Name = "rdWalkin";
            rdWalkin.Size = new Size(76, 23);
            rdWalkin.TabIndex = 0;
            rdWalkin.TabStop = true;
            rdWalkin.Text = "Walk In";
            rdWalkin.UseVisualStyleBackColor = true;
            rdWalkin.CheckedChanged += rdWalkin_CheckedChanged;
            // 
            // rdregular
            // 
            rdregular.AutoSize = true;
            rdregular.Location = new Point(25, 23);
            rdregular.Margin = new Padding(2);
            rdregular.Name = "rdregular";
            rdregular.Size = new Size(79, 23);
            rdregular.TabIndex = 1;
            rdregular.TabStop = true;
            rdregular.Text = "Regular";
            rdregular.UseVisualStyleBackColor = true;
            rdregular.CheckedChanged += rdregular_CheckedChanged;
            // 
            // grpcustomertype
            // 
            grpcustomertype.Controls.Add(rdregular);
            grpcustomertype.Controls.Add(rdWalkin);
            grpcustomertype.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpcustomertype.Location = new Point(808, 130);
            grpcustomertype.Margin = new Padding(2);
            grpcustomertype.Name = "grpcustomertype";
            grpcustomertype.Padding = new Padding(2);
            grpcustomertype.Size = new Size(142, 90);
            grpcustomertype.TabIndex = 5;
            grpcustomertype.TabStop = false;
            grpcustomertype.Text = "Customer Type:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1119, 578);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 26;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(1091, 145);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 27;
            label5.Text = "Date:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(10, 35, 66);
            label6.Location = new Point(186, 134);
            label6.Name = "label6";
            label6.Size = new Size(137, 51);
            label6.TabIndex = 28;
            label6.Text = "Billing";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1307, 649);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(grpcustomers);
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
            Controls.Add(btnRemove);
            Controls.Add(BillDate);
            Controls.Add(txtdiscount);
            Controls.Add(grpRegularCustomer);
            Controls.Add(dvgProductsinBill);
            Controls.Add(numQuantity);
            Controls.Add(cmbSelectProducts);
            Controls.Add(grpcustomertype);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "CreateBill";
            Text = "CreateBill";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProductsinBill).EndInit();
            grpRegularCustomer.ResumeLayout(false);
            grpRegularCustomer.PerformLayout();
            grpcustomers.ResumeLayout(false);
            grpcustomers.PerformLayout();
            grpcustomertype.ResumeLayout(false);
            grpcustomertype.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
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
        private PrintPreviewDialog printPreviewDialog1;
        private RadioButton rdWalkin;
        private RadioButton rdregular;
        private GroupBox grpcustomertype;
        private GroupBox grpcustomers;
        private TextBox nametxt;
        private Label label3;
        private Label label4;
        private TextBox contacttxt;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}