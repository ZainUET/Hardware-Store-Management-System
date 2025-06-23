namespace Bismillah.UI
{
    partial class AddBorrowedUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnSave;

        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutPanel;

        private TextBox txtQty;
        private TextBox txtPrice;
        private CheckBox chkPaid;

        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvBorrowed;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBorrowedUI));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnBack = new LinkLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbPaymentStatus = new ComboBox();
            comboBox2 = new ComboBox();
            cmbcustomers = new ComboBox();
            label1 = new Label();
            txtaddress = new TextBox();
            txtpoints = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnsave = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            dgvBorrowed = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).BeginInit();
            tableLayoutPanel4.SuspendLayout();
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
            tableLayoutPanel2.Location = new Point(-1, 0);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(2319, 208);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 198);
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
            label2.Location = new Point(321, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(10, 35, 66);
            btnBack.BorderStyle = BorderStyle.FixedSingle;
            btnBack.CausesValidation = false;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.LinkBehavior = LinkBehavior.NeverUnderline;
            btnBack.LinkColor = Color.White;
            btnBack.Location = new Point(2004, 1395);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 59);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(240, 245, 255);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cmbPaymentStatus, 0, 5);
            tableLayoutPanel1.Controls.Add(comboBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(cmbcustomers, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtaddress, 0, 3);
            tableLayoutPanel1.Controls.Add(txtpoints, 0, 4);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 0, 6);
            tableLayoutPanel1.Controls.Add(btnsave, 0, 7);
            tableLayoutPanel1.Location = new Point(16, 437);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(536, 648);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.ForeColor = SystemColors.WindowFrame;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Yes", "No" });
            cmbPaymentStatus.Location = new Point(70, 279);
            cmbPaymentStatus.Margin = new Padding(70, 15, 18, 15);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(241, 23);
            cmbPaymentStatus.TabIndex = 20;
            cmbPaymentStatus.Text = "Select Payment  Status";
            // 
            // comboBox2
            // 
            comboBox2.ForeColor = SystemColors.WindowFrame;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Yes", "No" });
            comboBox2.Location = new Point(100, 195);
            comboBox2.Margin = new Padding(100, 25, 26, 25);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(343, 33);
            comboBox2.TabIndex = 15;
            comboBox2.Text = "Select Products";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbcustomers
            // 
            cmbcustomers.ForeColor = SystemColors.WindowFrame;
            cmbcustomers.FormattingEnabled = true;
            cmbcustomers.Items.AddRange(new object[] { "Yes", "No" });
            cmbcustomers.Location = new Point(100, 112);
            cmbcustomers.Margin = new Padding(100, 25, 26, 25);
            cmbcustomers.Name = "cmbcustomers";
            cmbcustomers.Size = new Size(343, 33);
            cmbcustomers.TabIndex = 14;
            cmbcustomers.Text = "Select Customers";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(529, 87);
            label1.TabIndex = 0;
            label1.Text = "Borrow Products";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(100, 278);
            txtaddress.Margin = new Padding(100, 25, 26, 25);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Enter quantity";
            txtaddress.Size = new Size(343, 31);
            txtaddress.TabIndex = 11;
            // 
            // txtpoints
            // 
            txtpoints.Location = new Point(100, 359);
            txtpoints.Margin = new Padding(100, 25, 26, 25);
            txtpoints.Name = "txtpoints";
            txtpoints.PlaceholderText = "Unit price";
            txtpoints.ReadOnly = true;
            txtpoints.Size = new Size(241, 23);
            txtpoints.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(94, 503);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(348, 31);
            dateTimePicker1.TabIndex = 18;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.FromArgb(10, 35, 66);
            btnsave.Cursor = Cursors.Hand;
            btnsave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(175, 562);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(186, 63);
            btnsave.TabIndex = 19;
            btnsave.Text = "Borrow";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.BackColor = Color.FromArgb(240, 245, 255);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvBorrowed, 0, 1);
            tableLayoutPanel3.Location = new Point(651, 470);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1049, 552);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(10, 35, 66);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(1043, 67);
            label3.TabIndex = 1;
            label3.Text = "Borrowed";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvBorrowed
            // 
            dgvBorrowed.BackgroundColor = Color.FromArgb(240, 245, 255);
            dgvBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowed.Location = new Point(4, 72);
            dgvBorrowed.Margin = new Padding(4, 5, 4, 5);
            dgvBorrowed.Name = "dgvBorrowed";
            dgvBorrowed.RowHeadersWidth = 62;
            dgvBorrowed.Size = new Size(1040, 475);
            dgvBorrowed.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.Controls.Add(button1, 0, 0);
            tableLayoutPanel4.Location = new Point(1529, 1057);
            tableLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel4.Size = new Size(171, 65);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(165, 58);
            button1.TabIndex = 20;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddBorrowedUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1790, 1142);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBorrowedUI";
            Text = "AddSatff";
            Load += BorrowedUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowed).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtContact;
        private TextBox txtName;
        private LinkLabel btnBack;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox2;
        private ComboBox cmbcustomers;
        private TextBox txtpoints;
        private TextBox txtaddress;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnsave;
        private Button button1;
        private ComboBox cmbPaymentStatus;
    }
}