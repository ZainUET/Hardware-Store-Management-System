namespace Bismillah.UI
{
    partial class ViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvProducts = new DataGridView();
            label1 = new Label();
            back = new LinkLabel();
            cmbCategories = new ComboBox();
            cmbproducts = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.69863F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.30137F));
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(2004, 96);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(276, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(845, 51);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvProducts, 0, 1);
            tableLayoutPanel1.Location = new Point(389, 271);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(608, 338);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProducts.Location = new Point(3, 8);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(602, 327);
            dgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(402, 117);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(549, 59);
            label1.TabIndex = 1;
            label1.Text = "Products";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            back.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            back.Anchor = AnchorStyles.None;
            back.BackColor = Color.FromArgb(10, 35, 66);
            back.BorderStyle = BorderStyle.FixedSingle;
            back.CausesValidation = false;
            back.Cursor = Cursors.Hand;
            back.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            back.ForeColor = Color.White;
            back.LinkBehavior = LinkBehavior.NeverUnderline;
            back.LinkColor = Color.White;
            back.Location = new Point(1076, 509);
            back.Margin = new Padding(1, 0, 1, 0);
            back.Name = "back";
            back.Size = new Size(152, 39);
            back.TabIndex = 17;
            back.TabStop = true;
            back.Text = "Back";
            back.TextAlign = ContentAlignment.MiddleCenter;
            back.LinkClicked += back_LinkClicked;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(771, 203);
            cmbCategories.Margin = new Padding(1);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(180, 23);
            cmbCategories.TabIndex = 18;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged_1;
            // 
            // cmbproducts
            // 
            cmbproducts.FormattingEnabled = true;
            cmbproducts.Location = new Point(389, 203);
            cmbproducts.Margin = new Padding(1);
            cmbproducts.Name = "cmbproducts";
            cmbproducts.Size = new Size(232, 23);
            cmbproducts.TabIndex = 19;
            cmbproducts.TextChanged += cmbproducts_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(389, 188);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 20;
            label3.Text = "Products:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(771, 188);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 21;
            label4.Text = "Categories:";
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 689);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbproducts);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Controls.Add(back);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewProduct";
            Text = "Edit/Delete Product";
            WindowState = FormWindowState.Maximized;
            Load += ProductUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvProducts;
        private Label label1;
        private LinkLabel back;
        private PictureBox pictureBox2;
        private ComboBox cmbCategories;
        private ComboBox cmbproducts;
        private Label label3;
        private Label label4;
    }
}