namespace Bismillah.UI
{
    partial class AddProductsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductsUI));
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnBack = new LinkLabel();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtpurchase = new TextBox();
            txtsize = new TextBox();
            comboSupplier = new ComboBox();
            comboCategory = new ComboBox();
            txtName = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnsave = new Button();
            txtquantity = new TextBox();
            button = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.69863F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.30137F));
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel2.Location = new Point(-1, 0);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(2240, 208);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(310, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(298, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1133, 217);
            label1.Name = "label1";
            label1.Size = new Size(529, 87);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnBack.Location = new Point(1926, 1407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 59);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(671, 217);
            label3.Name = "label3";
            label3.Size = new Size(936, 87);
            label3.TabIndex = 6;
            label3.Text = "Add Product";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.BackColor = Color.FromArgb(240, 245, 255);
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(txtpurchase, 0, 6);
            tableLayoutPanel5.Controls.Add(txtsize, 0, 4);
            tableLayoutPanel5.Controls.Add(comboSupplier, 0, 3);
            tableLayoutPanel5.Controls.Add(comboCategory, 0, 2);
            tableLayoutPanel5.Controls.Add(txtName, 0, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(dateTimePicker1, 0, 7);
            tableLayoutPanel5.Controls.Add(btnsave, 0, 8);
            tableLayoutPanel5.Controls.Add(txtquantity, 0, 5);
            tableLayoutPanel5.Location = new Point(736, 287);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 9;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel5.Size = new Size(536, 772);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // txtpurchase
            // 
            txtpurchase.Location = new Point(100, 521);
            txtpurchase.Margin = new Padding(100, 25, 26, 25);
            txtpurchase.Name = "txtpurchase";
            txtpurchase.PlaceholderText = "Unit Price";
            txtpurchase.Size = new Size(343, 31);
            txtpurchase.TabIndex = 19;
            // 
            // txtsize
            // 
            txtsize.Location = new Point(100, 359);
            txtsize.Margin = new Padding(100, 25, 26, 25);
            txtsize.Name = "txtsize";
            txtsize.PlaceholderText = "Size";
            txtsize.Size = new Size(343, 31);
            txtsize.TabIndex = 17;
            // 
            // comboSupplier
            // 
            comboSupplier.FormattingEnabled = true;
            comboSupplier.Location = new Point(100, 276);
            comboSupplier.Margin = new Padding(100, 25, 26, 25);
            comboSupplier.Name = "comboSupplier";
            comboSupplier.Size = new Size(343, 33);
            comboSupplier.TabIndex = 16;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(100, 193);
            comboCategory.Margin = new Padding(100, 25, 26, 25);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(343, 33);
            comboCategory.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 112);
            txtName.Margin = new Padding(100, 25, 26, 25);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(343, 31);
            txtName.TabIndex = 14;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(10, 35, 66);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(529, 87);
            label4.TabIndex = 0;
            label4.Text = "Add Product";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(96, 582);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(343, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.FromArgb(10, 35, 66);
            btnsave.Cursor = Cursors.Hand;
            btnsave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(175, 662);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(186, 66);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(100, 440);
            txtquantity.Margin = new Padding(100, 25, 26, 25);
            txtquantity.Name = "txtquantity";
            txtquantity.PlaceholderText = "Quantity";
            txtquantity.Size = new Size(343, 31);
            txtquantity.TabIndex = 18;
            // 
            // button
            // 
            button.Anchor = AnchorStyles.None;
            button.BackColor = Color.FromArgb(10, 35, 66);
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Location = new Point(1352, 952);
            button.Name = "button";
            button.Size = new Size(186, 63);
            button.TabIndex = 14;
            button.Text = "Back";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // AddProductsUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1711, 1153);
            Controls.Add(button);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProductsUI";
            Text = "Add Product";
            WindowState = FormWindowState.Maximized;
            Load += AddProductsUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private LinkLabel btnBack;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private Button btnsave;
        private TextBox txtpurchase;
        private TextBox txtsize;
        private ComboBox comboSupplier;
        private ComboBox comboCategory;
        private TextBox txtName;
        private DateTimePicker dateTimePicker1;
        private TextBox txtquantity;
        private Button button;
        private PictureBox pictureBox2;
    }
}