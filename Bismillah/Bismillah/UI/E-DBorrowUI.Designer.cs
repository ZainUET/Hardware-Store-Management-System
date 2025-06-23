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
            cmbCustomer = new ComboBox();
            label1 = new Label();
            btnedit = new LinkLabel();
            btndelete = new LinkLabel();
            btnback = new LinkLabel();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvborrowed).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(2955, 208);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 198);
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
            label2.Location = new Point(408, 67);
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
            tableLayoutPanel1.Controls.Add(dgvborrowed, 0, 1);
            tableLayoutPanel1.Location = new Point(470, 381);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1293, 505);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // dgvborrowed
            // 
            dgvborrowed.BackgroundColor = Color.FromArgb(240, 245, 255);
            dgvborrowed.BorderStyle = BorderStyle.None;
            dgvborrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvborrowed.Location = new Point(4, 13);
            dgvborrowed.Margin = new Padding(4, 5, 4, 5);
            dgvborrowed.Name = "dgvborrowed";
            dgvborrowed.RowHeadersWidth = 62;
            dgvborrowed.Size = new Size(1284, 437);
            dgvborrowed.TabIndex = 0;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(577, 340);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(278, 33);
            cmbCustomer.TabIndex = 17;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(413, 227);
            label1.Name = "label1";
            label1.Size = new Size(1203, 67);
            label1.TabIndex = 1;
            label1.Text = "Borrowed";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
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
            btnedit.Location = new Point(4, 47);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(183, 67);
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
            btndelete.Location = new Point(4, 163);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(183, 65);
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
            btnback.Location = new Point(1125, 1172);
            btnback.Name = "btnback";
            btnback.Size = new Size(189, 69);
            btnback.TabIndex = 16;
            btnback.TabStop = true;
            btnback.Text = "Back";
            btnback.TextAlign = ContentAlignment.MiddleCenter;
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
            linkLabel1.Location = new Point(4, 277);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(183, 65);
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
            tableLayoutPanel3.Location = new Point(213, 440);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(190, 342);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(577, 315);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 20;
            label3.Text = "Select a Customer:";
            // 
            // E_DBorrowUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1878, 948);
            Controls.Add(label3);
            Controls.Add(cmbCustomer);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label1);
            Controls.Add(btnback);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "E_DBorrowUI";
            Text = "Edit/Delete Borrow";
            WindowState = FormWindowState.Maximized;
            Load += E_DBorrowUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvborrowed).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label label3;
    }
}