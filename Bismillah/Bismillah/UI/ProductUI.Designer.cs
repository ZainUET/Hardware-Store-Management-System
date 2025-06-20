namespace Bismillah.UI
{
    partial class ProductUI
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
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dgvProducts = new DataGridView();
            edit = new LinkLabel();
            delete = new LinkLabel();
            back = new LinkLabel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1181, 125);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 119);
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
            label2.Location = new Point(164, 37);
            label2.Name = "label2";
            label2.Size = new Size(845, 51);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.FromArgb(240, 245, 255);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvProducts, 0, 1);
            tableLayoutPanel1.Location = new Point(182, 220);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(932, 331);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(928, 40);
            label1.TabIndex = 1;
            label1.Text = "Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.FromArgb(240, 245, 255);
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(3, 43);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(926, 285);
            dgvProducts.TabIndex = 0;
            // 
            // edit
            // 
            edit.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            edit.Anchor = AnchorStyles.None;
            edit.BackColor = Color.FromArgb(10, 35, 66);
            edit.BorderStyle = BorderStyle.FixedSingle;
            edit.CausesValidation = false;
            edit.Cursor = Cursors.Hand;
            edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            edit.ForeColor = Color.White;
            edit.LinkBehavior = LinkBehavior.NeverUnderline;
            edit.LinkColor = Color.White;
            edit.Location = new Point(260, 573);
            edit.Margin = new Padding(2, 0, 2, 0);
            edit.Name = "edit";
            edit.Size = new Size(152, 39);
            edit.TabIndex = 15;
            edit.TabStop = true;
            edit.Text = "Edit";
            edit.TextAlign = ContentAlignment.MiddleCenter;
            edit.LinkClicked += edit_LinkClicked;
            // 
            // delete
            // 
            delete.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            delete.Anchor = AnchorStyles.None;
            delete.BackColor = Color.FromArgb(10, 35, 66);
            delete.BorderStyle = BorderStyle.FixedSingle;
            delete.CausesValidation = false;
            delete.Cursor = Cursors.Hand;
            delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.LinkBehavior = LinkBehavior.NeverUnderline;
            delete.LinkColor = Color.White;
            delete.Location = new Point(494, 573);
            delete.Margin = new Padding(2, 0, 2, 0);
            delete.Name = "delete";
            delete.Size = new Size(152, 39);
            delete.TabIndex = 16;
            delete.TabStop = true;
            delete.Text = "Delete";
            delete.TextAlign = ContentAlignment.MiddleCenter;
            delete.LinkClicked += delete_LinkClicked;
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
            back.Location = new Point(737, 573);
            back.Margin = new Padding(2, 0, 2, 0);
            back.Name = "back";
            back.Size = new Size(152, 39);
            back.TabIndex = 17;
            back.TabStop = true;
            back.Text = "Back";
            back.TextAlign = ContentAlignment.MiddleCenter;
            back.LinkClicked += back_LinkClicked;
            // 
            // ProductUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 621);
            Controls.Add(back);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "ProductUI";
            Text = "SupplierUI";
            Load += ProductUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvProducts;
        private Label label1;
        private LinkLabel edit;
        private LinkLabel delete;
        private LinkLabel back;
    }
}