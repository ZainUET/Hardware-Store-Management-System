namespace Bismillah.UI
{
    partial class E_DBorrowUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_DBorrowUI));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvborrowed = new DataGridView();
            label1 = new Label();
            btnedit = new LinkLabel();
            btndelete = new LinkLabel();
            btnback = new LinkLabel();
            cmbCustomer = new ComboBox();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvborrowed).BeginInit();
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
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1530, 125);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            label2.Location = new Point(212, 37);
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
            tableLayoutPanel1.Controls.Add(dgvborrowed, 0, 1);
            tableLayoutPanel1.Location = new Point(337, 241);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(846, 331);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // dgvborrowed
            // 
            dgvborrowed.BackgroundColor = Color.FromArgb(240, 245, 255);
            dgvborrowed.BorderStyle = BorderStyle.None;
            dgvborrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvborrowed.Location = new Point(3, 8);
            dgvborrowed.Name = "dgvborrowed";
            dgvborrowed.RowHeadersWidth = 62;
            dgvborrowed.Size = new Size(840, 315);
            dgvborrowed.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(289, 136);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(842, 40);
            label1.TabIndex = 1;
            label1.Text = "Borrowed";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnedit
            // 
            btnedit.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            btnedit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnedit.BackColor = Color.FromArgb(10, 35, 66);
            btnedit.BorderStyle = BorderStyle.FixedSingle;
            btnedit.CausesValidation = false;
            btnedit.Cursor = Cursors.Hand;
            btnedit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnedit.ForeColor = Color.White;
            btnedit.LinkBehavior = LinkBehavior.NeverUnderline;
            btnedit.LinkColor = Color.White;
            btnedit.Location = new Point(2, 25);
            btnedit.Margin = new Padding(2, 0, 2, 0);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(129, 41);
            btnedit.TabIndex = 14;
            btnedit.TabStop = true;
            btnedit.Text = "Edit";
            btnedit.TextAlign = ContentAlignment.MiddleCenter;
            btnedit.LinkClicked += btnedit_LinkClicked;
            // 
            // btndelete
            // 
            btndelete.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            btndelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btndelete.BackColor = Color.FromArgb(10, 35, 66);
            btndelete.BorderStyle = BorderStyle.FixedSingle;
            btndelete.CausesValidation = false;
            btndelete.Cursor = Cursors.Hand;
            btndelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btndelete.ForeColor = Color.White;
            btndelete.LinkBehavior = LinkBehavior.NeverUnderline;
            btndelete.LinkColor = Color.White;
            btndelete.Location = new Point(2, 92);
            btndelete.Margin = new Padding(2, 0, 2, 0);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(129, 40);
            btndelete.TabIndex = 15;
            btndelete.TabStop = true;
            btndelete.Text = "Delete";
            btndelete.TextAlign = ContentAlignment.MiddleCenter;
            btndelete.LinkClicked += btndelete_LinkClicked;
            // 
            // btnback
            // 
            btnback.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            btnback.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnback.BackColor = Color.FromArgb(10, 35, 66);
            btnback.BorderStyle = BorderStyle.FixedSingle;
            btnback.CausesValidation = false;
            btnback.Cursor = Cursors.Hand;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnback.ForeColor = Color.White;
            btnback.LinkBehavior = LinkBehavior.NeverUnderline;
            btnback.LinkColor = Color.White;
            btnback.Location = new Point(249, 583);
            btnback.Margin = new Padding(2, 0, 2, 0);
            btnback.Name = "btnback";
            btnback.Size = new Size(133, 42);
            btnback.TabIndex = 16;
            btnback.TabStop = true;
            btnback.Text = "Back";
            btnback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(2, 2);
            cmbCustomer.Margin = new Padding(2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(196, 23);
            cmbCustomer.TabIndex = 17;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(10, 35, 66);
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel1.BackColor = Color.FromArgb(10, 35, 66);
            linkLabel1.BorderStyle = BorderStyle.FixedSingle;
            linkLabel1.CausesValidation = false;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(2, 159);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 40);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnedit, 0, 0);
            tableLayoutPanel3.Controls.Add(linkLabel1, 0, 2);
            tableLayoutPanel3.Controls.Add(btndelete, 0, 1);
            tableLayoutPanel3.Location = new Point(175, 341);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(133, 199);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(cmbCustomer, 0, 0);
            tableLayoutPanel4.Location = new Point(375, 203);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(200, 32);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // E_DBorrowUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 543);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label1);
            Controls.Add(btnback);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "E_DBorrowUI";
            Text = "Edit/Delete Borrow";
            Load += E_DBorrowUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvborrowed).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvborrowed;
        private LinkLabel btnedit;
        private LinkLabel btnback;
        private LinkLabel btndelete;
        private Label label1;
        private ComboBox cmbCustomer;
        private LinkLabel linkLabel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}