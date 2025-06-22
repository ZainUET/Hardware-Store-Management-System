namespace Bismillah
{
    partial class Returns
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Returns));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cmbCustomer = new ComboBox();
            CustomerDetails = new GroupBox();
            lblCustomerContact = new Label();
            lblCustomerCNIC = new Label();
            cmbProducts = new ComboBox();
            Quantity = new NumericUpDown();
            btnadd = new Button();
            dgvProducts = new DataGridView();
            lbltotalitems = new Label();
            lblrefund = new Label();
            btnsubmit = new Button();
            btnPrint = new Button();
            btnClear = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBack = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(-3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1750, 125);
            tableLayoutPanel2.TabIndex = 1;
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
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(554, 12);
            label2.Name = "label2";
            label2.Size = new Size(904, 100);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(27, 32);
            cmbCustomer.Margin = new Padding(2, 2, 2, 2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(202, 23);
            cmbCustomer.TabIndex = 2;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // CustomerDetails
            // 
            CustomerDetails.Controls.Add(lblCustomerContact);
            CustomerDetails.Controls.Add(lblCustomerCNIC);
            CustomerDetails.Controls.Add(cmbCustomer);
            CustomerDetails.Location = new Point(987, 178);
            CustomerDetails.Margin = new Padding(2, 2, 2, 2);
            CustomerDetails.Name = "CustomerDetails";
            CustomerDetails.Padding = new Padding(2, 2, 2, 2);
            CustomerDetails.Size = new Size(255, 127);
            CustomerDetails.TabIndex = 3;
            CustomerDetails.TabStop = false;
            CustomerDetails.Text = "Select Customer:";
            // 
            // lblCustomerContact
            // 
            lblCustomerContact.AutoSize = true;
            lblCustomerContact.Location = new Point(27, 95);
            lblCustomerContact.Margin = new Padding(2, 0, 2, 0);
            lblCustomerContact.Name = "lblCustomerContact";
            lblCustomerContact.Size = new Size(0, 15);
            lblCustomerContact.TabIndex = 4;
            // 
            // lblCustomerCNIC
            // 
            lblCustomerCNIC.AutoSize = true;
            lblCustomerCNIC.Location = new Point(27, 69);
            lblCustomerCNIC.Margin = new Padding(2, 0, 2, 0);
            lblCustomerCNIC.Name = "lblCustomerCNIC";
            lblCustomerCNIC.Size = new Size(0, 15);
            lblCustomerCNIC.TabIndex = 3;
            // 
            // cmbProducts
            // 
            cmbProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(129, 185);
            cmbProducts.Margin = new Padding(2, 2, 2, 2);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(228, 23);
            cmbProducts.TabIndex = 4;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            cmbProducts.KeyUp += cmbProducts_KeyUp;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(385, 185);
            Quantity.Margin = new Padding(2, 2, 2, 2);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(97, 23);
            Quantity.TabIndex = 5;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(10, 35, 66);
            btnadd.Cursor = Cursors.Hand;
            btnadd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(545, 178);
            btnadd.Margin = new Padding(2, 2, 2, 2);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(97, 30);
            btnadd.TabIndex = 23;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(136, 247);
            dgvProducts.Margin = new Padding(2, 2, 2, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(572, 249);
            dgvProducts.TabIndex = 24;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // lbltotalitems
            // 
            lbltotalitems.AutoSize = true;
            lbltotalitems.Location = new Point(1012, 323);
            lbltotalitems.Margin = new Padding(2, 0, 2, 0);
            lbltotalitems.Name = "lbltotalitems";
            lbltotalitems.Size = new Size(0, 15);
            lbltotalitems.TabIndex = 25;
            // 
            // lblrefund
            // 
            lblrefund.AutoSize = true;
            lblrefund.Location = new Point(1012, 355);
            lblrefund.Margin = new Padding(2, 0, 2, 0);
            lblrefund.Name = "lblrefund";
            lblrefund.Size = new Size(0, 15);
            lblrefund.TabIndex = 26;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.FromArgb(10, 35, 66);
            btnsubmit.Cursor = Cursors.Hand;
            btnsubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsubmit.ForeColor = Color.White;
            btnsubmit.Location = new Point(2, 2);
            btnsubmit.Margin = new Padding(2, 2, 2, 2);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(130, 38);
            btnsubmit.TabIndex = 27;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(10, 35, 66);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(153, 2);
            btnPrint.Margin = new Padding(2, 2, 2, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(130, 38);
            btnPrint.TabIndex = 28;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(10, 35, 66);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(2, 47);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 38);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnBack, 1, 1);
            tableLayoutPanel1.Controls.Add(btnsubmit, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 0, 1);
            tableLayoutPanel1.Controls.Add(btnPrint, 1, 0);
            tableLayoutPanel1.Location = new Point(987, 403);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(302, 90);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(10, 35, 66);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(153, 47);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 38);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Returns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 563);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblrefund);
            Controls.Add(lbltotalitems);
            Controls.Add(dgvProducts);
            Controls.Add(btnadd);
            Controls.Add(Quantity);
            Controls.Add(cmbProducts);
            Controls.Add(CustomerDetails);
            Controls.Add(tableLayoutPanel2);
            Name = "Returns";
            Text = "Returns";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CustomerDetails.ResumeLayout(false);
            CustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox cmbCustomer;
        private GroupBox CustomerDetails;
        private Label lblCustomerContact;
        private Label lblCustomerCNIC;
        private ComboBox cmbProducts;
        private NumericUpDown Quantity;
        private Button btnadd;
        private DataGridView dgvProducts;
        private Label lbltotalitems;
        private Label lblrefund;
        private Button btnsubmit;
        private Button btnPrint;
        private Button btnClear;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBack;
    }
}
