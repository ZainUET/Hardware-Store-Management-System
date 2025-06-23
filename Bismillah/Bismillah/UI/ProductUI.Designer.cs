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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUI));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dgvProducts = new DataGridView();
            edit = new LinkLabel();
            delete = new LinkLabel();
            back = new LinkLabel();
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
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1938, 208);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 178);
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
            label2.Location = new Point(269, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
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
            tableLayoutPanel1.Location = new Point(504, 298);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1331, 552);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1325, 67);
            label1.TabIndex = 1;
            label1.Text = "Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.FromArgb(240, 245, 255);
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(4, 72);
            dgvProducts.Margin = new Padding(4, 5, 4, 5);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1323, 475);
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
            edit.Location = new Point(135, 380);
            edit.Name = "edit";
            edit.Size = new Size(216, 64);
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
            delete.Location = new Point(135, 553);
            delete.Name = "delete";
            delete.Size = new Size(216, 64);
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
            back.Location = new Point(135, 737);
            back.Name = "back";
            back.Size = new Size(216, 64);
            back.TabIndex = 17;
            back.TabStop = true;
            back.Text = "Back";
            back.TextAlign = ContentAlignment.MiddleCenter;
            back.LinkClicked += back_LinkClicked;
            // 
            // ProductUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1878, 1035);
            Controls.Add(back);
            Controls.Add(delete);
            Controls.Add(edit);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductUI";
            Text = "Edit/Delete Product";
            WindowState = FormWindowState.Maximized;
            Load += ProductUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvProducts;
        private Label label1;
        private LinkLabel edit;
        private LinkLabel delete;
        private LinkLabel back;
        private PictureBox pictureBox2;
    }
}