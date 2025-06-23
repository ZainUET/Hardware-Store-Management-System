namespace Bismillah.UI
{
    partial class ViewPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPayments));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            cmbCustomers = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvPayments = new DataGridView();
            btnback = new Button();
            cmbwalkin = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
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
            tableLayoutPanel2.Location = new Point(1, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1690, 125);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 107);
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
            label2.Location = new Point(234, 37);
            label2.Name = "label2";
            label2.Size = new Size(845, 51);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(427, 129);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(549, 59);
            label1.TabIndex = 20;
            label1.Text = "Payments";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCustomers
            // 
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(416, 244);
            cmbCustomers.Margin = new Padding(2, 2, 2, 2);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(220, 23);
            cmbCustomers.TabIndex = 22;
            cmbCustomers.SelectedIndexChanged += cmbCustomers_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvPayments, 0, 1);
            tableLayoutPanel1.Location = new Point(388, 268);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(608, 291);
            tableLayoutPanel1.TabIndex = 21;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeColumns = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPayments.Location = new Point(3, 8);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersWidth = 62;
            dgvPayments.Size = new Size(602, 249);
            dgvPayments.TabIndex = 0;
            // 
            // btnback
            // 
            btnback.BackColor = Color.FromArgb(10, 35, 66);
            btnback.Cursor = Cursors.Hand;
            btnback.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(899, 556);
            btnback.Margin = new Padding(2, 2, 2, 2);
            btnback.Name = "btnback";
            btnback.Size = new Size(97, 30);
            btnback.TabIndex = 24;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // cmbwalkin
            // 
            cmbwalkin.FormattingEnabled = true;
            cmbwalkin.Location = new Point(756, 244);
            cmbwalkin.Margin = new Padding(1, 1, 1, 1);
            cmbwalkin.Name = "cmbwalkin";
            cmbwalkin.Size = new Size(203, 23);
            cmbwalkin.TabIndex = 25;
            cmbwalkin.SelectedIndexChanged += cmbwalkin_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(416, 228);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 26;
            label3.Text = "Customers:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(755, 228);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 27;
            label4.Text = "Type:";
            // 
            // ViewPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(959, 449);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbwalkin);
            Controls.Add(btnback);
            Controls.Add(label1);
            Controls.Add(cmbCustomers);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewPayments";
            Text = "ViewPayments";
            Load += ViewPayments_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private ComboBox cmbCustomers;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvPayments;
        private Button btnback;
        private ComboBox cmbwalkin;
        private Label label3;
        private Label label4;
    }
}