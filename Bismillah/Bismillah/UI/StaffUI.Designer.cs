namespace Bismillah.UI
{
    partial class StaffUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUI));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dgvsupplier = new DataGridView();
            btnedit = new LinkLabel();
            btndelete = new LinkLabel();
            btnback = new LinkLabel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsupplier).BeginInit();
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
            tableLayoutPanel2.Size = new Size(1938, 208);
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
            tableLayoutPanel1.Controls.Add(dgvsupplier, 0, 1);
            tableLayoutPanel1.Location = new Point(306, 246);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1115, 552);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1109, 67);
            label1.TabIndex = 1;
            label1.Text = " Staff";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dgvsupplier
            // 
            dgvsupplier.BackgroundColor = Color.FromArgb(240, 245, 255);
            dgvsupplier.BorderStyle = BorderStyle.None;
            dgvsupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsupplier.Location = new Point(4, 72);
            dgvsupplier.Margin = new Padding(4, 5, 4, 5);
            dgvsupplier.Name = "dgvsupplier";
            dgvsupplier.RowHeadersWidth = 62;
            dgvsupplier.Size = new Size(1107, 475);
            dgvsupplier.TabIndex = 0;
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
            btnedit.Location = new Point(356, 846);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(189, 62);
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
            btndelete.Location = new Point(766, 846);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(189, 60);
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
            btnback.Location = new Point(1170, 839);
            btnback.Name = "btnback";
            btnback.Size = new Size(189, 69);
            btnback.TabIndex = 16;
            btnback.TabStop = true;
            btnback.Text = "Back";
            btnback.TextAlign = ContentAlignment.MiddleCenter;
            btnback.LinkClicked += btnback_LinkClicked;
            // 
            // StaffUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1878, 944);
            Controls.Add(btnback);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "StaffUI";
            Text = "SupplierUI";
            WindowState = FormWindowState.Maximized;
            Load += StaffUI_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvsupplier;
        private LinkLabel btnedit;
        private LinkLabel btnback;
        private LinkLabel btndelete;
        private Label label1;
    }
}