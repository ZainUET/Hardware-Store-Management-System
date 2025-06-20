namespace Bismillah.UI
{
    partial class AddSupplierUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierUI));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtcomapny = new TextBox();
            cnictxt = new TextBox();
            txtContact = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            button1 = new LinkLabel();
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
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1959, 208);
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
            label2.Location = new Point(272, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(240, 245, 255);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtcomapny, 0, 5);
            tableLayoutPanel1.Controls.Add(cnictxt, 0, 3);
            tableLayoutPanel1.Controls.Add(txtContact, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 6);
            tableLayoutPanel1.Location = new Point(709, 264);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7607346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2392654F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.Size = new Size(536, 668);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txtcomapny
            // 
            txtcomapny.Location = new Point(100, 481);
            txtcomapny.Margin = new Padding(100, 25, 26, 25);
            txtcomapny.Name = "txtcomapny";
            txtcomapny.PlaceholderText = "Company";
            txtcomapny.Size = new Size(343, 31);
            txtcomapny.TabIndex = 12;
            // 


    

            // cnictxt
            // 
            cnictxt.Location = new Point(100, 285);
            cnictxt.Margin = new Padding(100, 25, 26, 25);
            cnictxt.Name = "cnictxt";
            cnictxt.PlaceholderText = "CNIC";
            cnictxt.Size = new Size(343, 31);
            cnictxt.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(100, 195);
            txtContact.Margin = new Padding(100, 25, 26, 25);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(343, 31);
            txtContact.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(529, 87);
            label1.TabIndex = 0;
            label1.Text = "Add Supplier";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 115);
            txtName.Margin = new Padding(100, 25, 26, 25);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(343, 31);
            txtName.TabIndex = 2;
            // 
            // button1
            // 
            button1.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.BorderStyle = BorderStyle.FixedSingle;
            button1.CausesValidation = false;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.LinkBehavior = LinkBehavior.NeverUnderline;
            button1.LinkColor = Color.White;
            button1.Location = new Point(160, 576);
            button1.Name = "button1";
            button1.Size = new Size(216, 64);
            button1.TabIndex = 13;
            button1.TabStop = true;
            button1.Text = "Save";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.LinkClicked += button1_LinkClicked;
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
            btnBack.Location = new Point(1644, 1267);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 59);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddSupplierUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 1013);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "AddSupplierUI";
            Text = "AddSatff";
            WindowState = FormWindowState.Maximized;
            Load += AddSupplierUI_Load;
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
        private TextBox txtcomapny;
        private TextBox cnictxt;
        private LinkLabel button1;
    }
}