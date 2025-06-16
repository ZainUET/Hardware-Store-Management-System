namespace Bismillah.UI
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBatch = new ComboBox();
            txtpurchase = new TextBox();
            comboSupplier = new ComboBox();
            txtsize = new TextBox();
            txtName = new TextBox();
            comboCategory = new ComboBox();
            txtquantity = new TextBox();
            txtsale = new TextBox();
            label1 = new Label();
            button1 = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            btnBack = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1566, 125);
            tableLayoutPanel2.TabIndex = 3;
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
            label2.Location = new Point(217, 37);
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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(comboBatch, 1, 3);
            tableLayoutPanel1.Controls.Add(txtpurchase, 0, 7);
            tableLayoutPanel1.Controls.Add(comboSupplier, 0, 3);
            tableLayoutPanel1.Controls.Add(txtsize, 0, 5);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(comboCategory, 1, 1);
            tableLayoutPanel1.Controls.Add(txtquantity, 1, 5);
            tableLayoutPanel1.Controls.Add(txtsale, 1, 7);
            tableLayoutPanel1.Location = new Point(2, 60);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(655, 209);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // comboBatch
            // 
            comboBatch.FormattingEnabled = true;
            comboBatch.Location = new Point(397, 68);
            comboBatch.Margin = new Padding(70, 15, 18, 15);
            comboBatch.Name = "comboBatch";
            comboBatch.Size = new Size(240, 23);
            comboBatch.TabIndex = 16;
            // 
            // txtpurchase
            // 
            txtpurchase.Location = new Point(70, 174);
            txtpurchase.Margin = new Padding(70, 15, 18, 15);
            txtpurchase.Name = "txtpurchase";
            txtpurchase.PlaceholderText = "Purchase Price";
            txtpurchase.Size = new Size(239, 23);
            txtpurchase.TabIndex = 18;
            // 
            // comboSupplier
            // 
            comboSupplier.FormattingEnabled = true;
            comboSupplier.Location = new Point(70, 68);
            comboSupplier.Margin = new Padding(70, 15, 18, 15);
            comboSupplier.Name = "comboSupplier";
            comboSupplier.Size = new Size(239, 23);
            comboSupplier.TabIndex = 15;
            // 
            // txtsize
            // 
            txtsize.Location = new Point(70, 121);
            txtsize.Margin = new Padding(70, 15, 18, 15);
            txtsize.Name = "txtsize";
            txtsize.PlaceholderText = "Size";
            txtsize.Size = new Size(239, 23);
            txtsize.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 15);
            txtName.Margin = new Padding(70, 15, 18, 15);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 2;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(397, 15);
            comboCategory.Margin = new Padding(70, 15, 18, 15);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(240, 23);
            comboCategory.TabIndex = 14;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(397, 121);
            txtquantity.Margin = new Padding(70, 15, 18, 15);
            txtquantity.Name = "txtquantity";
            txtquantity.PlaceholderText = "Quantity";
            txtquantity.Size = new Size(240, 23);
            txtquantity.TabIndex = 17;
            // 
            // txtsale
            // 
            txtsale.Location = new Point(397, 174);
            txtsale.Margin = new Padding(70, 15, 18, 15);
            txtsale.Name = "txtsale";
            txtsale.PlaceholderText = "Selling Price";
            txtsale.Size = new Size(240, 23);
            txtsale.TabIndex = 19;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(793, 130);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 52);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.CausesValidation = false;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.LinkBehavior = LinkBehavior.NeverUnderline;
            button1.LinkColor = Color.White;
            button1.Location = new Point(328, 0);
            button1.Margin = new Padding(2, 0, 2, 0);
            button1.Name = "button1";
            button1.Size = new Size(323, 55);
            button1.TabIndex = 13;
            button1.TabStop = true;
            button1.Text = "Save";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.LinkClicked += button1_LinkClicked_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(42, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 23);
            dateTimePicker1.TabIndex = 20;
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
            btnBack.Location = new Point(1346, 798);
            btnBack.Margin = new Padding(2, 0, 2, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 36);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Location = new Point(259, 235);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5127525F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 64.3216F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1656456F));
            tableLayoutPanel3.Size = new Size(659, 332);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(655, 52);
            label3.TabIndex = 6;
            label3.Text = "Add Product";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button1, 1, 0);
            tableLayoutPanel4.Controls.Add(dateTimePicker1, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 274);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(653, 55);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1196, 646);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AddProduct";
            Text = "AddSatff";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox txtsale;
        private TextBox txtName;
        private LinkLabel btnBack;
        private TextBox txtsize;
        private LinkLabel button1;
        private ComboBox comboBatch;
        private ComboBox comboSupplier;
        private ComboBox comboCategory;
        private TextBox txtpurchase;
        private TextBox txtquantity;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
    }
}