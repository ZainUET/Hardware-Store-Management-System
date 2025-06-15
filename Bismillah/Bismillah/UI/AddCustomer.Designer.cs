namespace Bismillah.UI
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new LinkLabel();
            txtpoints = new TextBox();
            txtaddress = new TextBox();
            cnictxt = new TextBox();
            txtContact = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            cmbregular = new ComboBox();
            btnBack = new LinkLabel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1371, 125);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 119);
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
            label2.Location = new Point(190, 37);
            label2.Name = "label2";
            label2.Size = new Size(845, 51);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 7);
            tableLayoutPanel1.Controls.Add(txtpoints, 0, 5);
            tableLayoutPanel1.Controls.Add(txtaddress, 0, 4);
            tableLayoutPanel1.Controls.Add(cnictxt, 0, 3);
            tableLayoutPanel1.Controls.Add(txtContact, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbregular, 0, 6);
            tableLayoutPanel1.Location = new Point(509, 160);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7607346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2392654F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Size = new Size(375, 486);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.BorderStyle = BorderStyle.FixedSingle;
            button1.CausesValidation = false;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.LinkBehavior = LinkBehavior.NeverUnderline;
            button1.LinkColor = Color.White;
            button1.Location = new Point(2, 410);
            button1.Margin = new Padding(2, 0, 2, 0);
            button1.Name = "button1";
            button1.Size = new Size(371, 76);
            button1.TabIndex = 13;
            button1.TabStop = true;
            button1.Text = "Save";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.LinkClicked += button1_LinkClicked;
            // 
            // txtpoints
            // 
            txtpoints.Location = new Point(70, 298);
            txtpoints.Margin = new Padding(70, 15, 18, 15);
            txtpoints.Name = "txtpoints";
            txtpoints.PlaceholderText = "Loyalty Points";
            txtpoints.Size = new Size(241, 23);
            txtpoints.TabIndex = 12;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(70, 236);
            txtaddress.Margin = new Padding(70, 15, 18, 15);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Address";
            txtaddress.Size = new Size(241, 23);
            txtaddress.TabIndex = 11;
            // 
            // cnictxt
            // 
            cnictxt.Location = new Point(70, 180);
            cnictxt.Margin = new Padding(70, 15, 18, 15);
            cnictxt.Name = "cnictxt";
            cnictxt.PlaceholderText = "CNIC";
            cnictxt.Size = new Size(241, 23);
            cnictxt.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(70, 126);
            txtContact.Margin = new Padding(70, 15, 18, 15);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(241, 23);
            txtContact.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 52);
            label1.TabIndex = 0;
            label1.Text = "Add Customer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 74);
            txtName.Margin = new Padding(70, 15, 18, 15);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(241, 23);
            txtName.TabIndex = 2;
            // 
            // cmbregular
            // 
            cmbregular.FormattingEnabled = true;
            cmbregular.Items.AddRange(new object[] { "Yes", "No" });
            cmbregular.Location = new Point(70, 354);
            cmbregular.Margin = new Padding(70, 15, 18, 15);
            cmbregular.Name = "cmbregular";
            cmbregular.Size = new Size(241, 23);
            cmbregular.TabIndex = 9;
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
            btnBack.Location = new Point(1151, 760);
            btnBack.Margin = new Padding(2, 0, 2, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 36);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 608);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(2);
            Name = "AddCustomer";
            Text = "AddSatff";
            Load += AddCustomer_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtContact;
        private TextBox txtName;
        private ComboBox cmbregular;
        private LinkLabel btnBack;
        private TextBox txtpoints;
        private TextBox txtaddress;
        private TextBox cnictxt;
        private LinkLabel button1;
    }
}