namespace Bismillah.UI
{
    partial class frmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilling));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblTitle = new Label();
            dtpBillDate = new DateTimePicker();
            txtBillNumber = new TextBox();
            gbCustomerType = new GroupBox();
            rbRegular = new RadioButton();
            rbWalkIn = new RadioButton();
            cmbCustomers = new ComboBox();
            btnNewCustomer = new Button();
            lblCustomerName = new Label();
            lblLoyaltyPoints = new Label();
            lblContact = new Label();
            dgvBillItems = new DataGridView();
            btnRemoveItem = new Button();
            numQuantity = new NumericUpDown();
            lblSubTotal = new Label();
            txtDiscount = new TextBox();
            lblTax = new Label();
            lblTotal = new Label();
            cmbPaymentStatus = new ComboBox();
            btnSaveBill = new Button();
            btnPrint = new Button();
            cmbproducts = new ComboBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbCustomerType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
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
            tableLayoutPanel2.Location = new Point(-1, -1);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1898, 208);
            tableLayoutPanel2.TabIndex = 2;
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
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(455, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(743, 230);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(434, 74);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Create New Bill";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpBillDate
            // 
            dtpBillDate.Format = DateTimePickerFormat.Short;
            dtpBillDate.Location = new Point(22, 259);
            dtpBillDate.MaxDate = new DateTime(2300, 6, 13, 0, 0, 0, 0);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(156, 31);
            dtpBillDate.TabIndex = 4;
            dtpBillDate.Value = new DateTime(2025, 6, 13, 0, 0, 0, 0);
            // 
            // txtBillNumber
            // 
            txtBillNumber.Location = new Point(245, 259);
            txtBillNumber.Name = "txtBillNumber";
            txtBillNumber.Size = new Size(150, 31);
            txtBillNumber.TabIndex = 5;
            // 
            // gbCustomerType
            // 
            gbCustomerType.Controls.Add(rbRegular);
            gbCustomerType.Controls.Add(rbWalkIn);
            gbCustomerType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbCustomerType.Location = new Point(1586, 230);
            gbCustomerType.Name = "gbCustomerType";
            gbCustomerType.Size = new Size(300, 166);
            gbCustomerType.TabIndex = 6;
            gbCustomerType.TabStop = false;
            gbCustomerType.Text = "Select Customer Type:";
            // 
            // rbRegular
            // 
            rbRegular.AutoSize = true;
            rbRegular.Cursor = Cursors.Hand;
            rbRegular.Location = new Point(80, 109);
            rbRegular.Name = "rbRegular";
            rbRegular.Size = new Size(116, 32);
            rbRegular.TabIndex = 1;
            rbRegular.TabStop = true;
            rbRegular.Text = "Regular ";
            rbRegular.UseVisualStyleBackColor = true;
            rbRegular.CheckedChanged += rbRegular_CheckedChanged;
            // 
            // rbWalkIn
            // 
            rbWalkIn.AutoSize = true;
            rbWalkIn.Cursor = Cursors.Hand;
            rbWalkIn.Location = new Point(80, 50);
            rbWalkIn.Name = "rbWalkIn";
            rbWalkIn.Size = new Size(114, 32);
            rbWalkIn.TabIndex = 0;
            rbWalkIn.TabStop = true;
            rbWalkIn.Text = "Walk In ";
            rbWalkIn.UseVisualStyleBackColor = true;
            rbWalkIn.CheckedChanged += rbWalkIn_CheckedChanged;
            // 
            // cmbCustomers
            // 
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(1589, 483);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(297, 33);
            cmbCustomers.TabIndex = 7;
            cmbCustomers.SelectedIndexChanged += cmbCustomers_SelectedIndexChanged;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(1589, 421);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(297, 34);
            btnNewCustomer.TabIndex = 8;
            btnNewCustomer.Text = "Add New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click_1;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(1612, 544);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(59, 25);
            lblCustomerName.TabIndex = 9;
            lblCustomerName.Text = "label1";
            // 
            // lblLoyaltyPoints
            // 
            lblLoyaltyPoints.AutoSize = true;
            lblLoyaltyPoints.Location = new Point(1612, 657);
            lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            lblLoyaltyPoints.Size = new Size(59, 25);
            lblLoyaltyPoints.TabIndex = 10;
            lblLoyaltyPoints.Text = "label3";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(1612, 599);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(59, 25);
            lblContact.TabIndex = 11;
            lblContact.Text = "label4";
            // 
            // dgvBillItems
            // 
            dgvBillItems.AllowUserToAddRows = false;
            dgvBillItems.AllowUserToDeleteRows = false;
            dgvBillItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBillItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBillItems.BackgroundColor = Color.White;
            dgvBillItems.BorderStyle = BorderStyle.None;
            dgvBillItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillItems.Cursor = Cursors.Hand;
            dgvBillItems.GridColor = SystemColors.Control;
            dgvBillItems.Location = new Point(36, 412);
            dgvBillItems.Name = "dgvBillItems";
            dgvBillItems.ReadOnly = true;
            dgvBillItems.RowHeadersWidth = 62;
            dgvBillItems.Size = new Size(1062, 686);
            dgvBillItems.TabIndex = 17;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.White;
            btnRemoveItem.Location = new Point(600, 352);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(104, 34);
            btnRemoveItem.TabIndex = 18;
            btnRemoveItem.Text = "Remove";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(454, 355);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(108, 31);
            numQuantity.TabIndex = 19;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(1642, 729);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(0, 25);
            lblSubTotal.TabIndex = 20;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(1589, 767);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.PlaceholderText = "Discount";
            txtDiscount.Size = new Size(150, 31);
            txtDiscount.TabIndex = 21;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(1612, 843);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(0, 25);
            lblTax.TabIndex = 22;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1612, 900);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 23;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(1589, 987);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(259, 33);
            cmbPaymentStatus.TabIndex = 24;
            // 
            // btnSaveBill
            // 
            btnSaveBill.Location = new Point(1589, 1064);
            btnSaveBill.Name = "btnSaveBill";
            btnSaveBill.Size = new Size(112, 34);
            btnSaveBill.TabIndex = 25;
            btnSaveBill.Text = "Save Bill";
            btnSaveBill.UseVisualStyleBackColor = true;
            btnSaveBill.Click += btnSaveBill_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1736, 1064);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 26;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // cmbproducts
            // 
            cmbproducts.FormattingEnabled = true;
            cmbproducts.Location = new Point(36, 354);
            cmbproducts.Name = "cmbproducts";
            cmbproducts.Size = new Size(393, 33);
            cmbproducts.TabIndex = 27;
            
            this.cmbproducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbproducts_KeyDown_1);
            this.numQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numQuantity_KeyDown_1);


            // 
            // frmBilling
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1144);
            Controls.Add(cmbproducts);
            Controls.Add(btnPrint);
            Controls.Add(btnSaveBill);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(txtDiscount);
            Controls.Add(lblSubTotal);
            Controls.Add(numQuantity);
            Controls.Add(btnRemoveItem);
            Controls.Add(dgvBillItems);
            Controls.Add(lblContact);
            Controls.Add(lblLoyaltyPoints);
            Controls.Add(lblCustomerName);
            Controls.Add(btnNewCustomer);
            Controls.Add(cmbCustomers);
            Controls.Add(gbCustomerType);
            Controls.Add(txtBillNumber);
            Controls.Add(dtpBillDate);
            Controls.Add(lblTitle);
            Controls.Add(tableLayoutPanel2);
            Name = "frmBilling";
            Text = "frmBilling";
            Load += frmBilling_Load_1;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbCustomerType.ResumeLayout(false);
            gbCustomerType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblTitle;
        private DateTimePicker dtpBillDate;
        private TextBox txtBillNumber;
        private GroupBox gbCustomerType;
        private RadioButton rbRegular;
        private RadioButton rbWalkIn;
        private ComboBox cmbCustomers;
        private Button btnNewCustomer;
        private Label lblCustomerName;
        private Label lblLoyaltyPoints;
        private Label lblContact;
        private DataGridView dgvBillItems;
        private Button btnRemoveItem;
        private NumericUpDown numQuantity;
        private Label lblSubTotal;
        private TextBox txtDiscount;
        private Label lblTax;
        private Label lblTotal;
        private ComboBox cmbPaymentStatus;
        private Button btnSaveBill;
        private Button btnPrint;
        private ComboBox cmbproducts;
    }
}