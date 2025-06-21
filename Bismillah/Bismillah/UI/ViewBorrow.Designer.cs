namespace Bismillah.UI
{
    partial class ViewBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBorrow));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvBorrow = new DataGridView();
            label1 = new Label();
            back = new LinkLabel();
            cmbCustomers = new ComboBox();
            btnsave = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).BeginInit();
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
            tableLayoutPanel2.Size = new Size(1598, 125);
            tableLayoutPanel2.TabIndex = 4;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 107);
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
            label2.Location = new Point(221, 37);
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
            tableLayoutPanel1.Controls.Add(dgvBorrow, 0, 1);
            tableLayoutPanel1.Location = new Point(247, 265);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(738, 331);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // dgvBorrow
            // 
            dgvBorrow.AllowUserToAddRows = false;
            dgvBorrow.AllowUserToDeleteRows = false;
            dgvBorrow.AllowUserToResizeColumns = false;
            dgvBorrow.AllowUserToResizeRows = false;
            dgvBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBorrow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBorrow.BackgroundColor = Color.FromArgb(240, 245, 255);
            dgvBorrow.BorderStyle = BorderStyle.None;
            dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrow.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBorrow.Location = new Point(3, 8);
            dgvBorrow.MultiSelect = false;
            dgvBorrow.Name = "dgvBorrow";
            dgvBorrow.ReadOnly = true;
            dgvBorrow.RowHeadersWidth = 62;
            dgvBorrow.Size = new Size(732, 320);
            dgvBorrow.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(409, 133);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(549, 59);
            label1.TabIndex = 1;
            label1.Text = "Borrow";
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
            back.Location = new Point(1245, 691);
            back.Margin = new Padding(2, 0, 2, 0);
            back.Name = "back";
            back.Size = new Size(152, 39);
            back.TabIndex = 17;
            back.TabStop = true;
            back.Text = "Back";
            back.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCustomers
            // 
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(377, 218);
            cmbCustomers.Margin = new Padding(2);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(232, 23);
            cmbCustomers.TabIndex = 19;
            cmbCustomers.SelectedIndexChanged += cmbCustomers_SelectedIndexChanged;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.FromArgb(10, 35, 66);
            btnsave.Cursor = Cursors.Hand;
            btnsave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(954, 647);
            btnsave.Margin = new Padding(2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(130, 38);
            btnsave.TabIndex = 20;
            btnsave.Text = "Back";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // ViewBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 707);
            Controls.Add(btnsave);
            Controls.Add(cmbCustomers);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "ViewBorrow";
            Text = "Edit/Delete Product";
            WindowState = FormWindowState.Maximized;
            Load += ViewBorrow_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvBorrow;
        private Label label1;
        private LinkLabel back;
        private PictureBox pictureBox2;
        private ComboBox cmbCustomers;
        private Button btnsave;
    }
}