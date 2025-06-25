namespace Bismillah.UI
{
    partial class ReceivePurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivePurchaseOrder));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dgvReceivePurchaseOrder = new DataGridView();
            label1 = new Label();
            back = new LinkLabel();
            checkBoxproductfullyreceived = new CheckBox();
            numericUpDownReceivedQuantity = new NumericUpDown();
            btnAllReceived = new Button();
            btnSaveReceipt = new Button();
            btnBack = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceivePurchaseOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReceivedQuantity).BeginInit();
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
            tableLayoutPanel2.Size = new Size(2863, 160);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 150);
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
            label2.Location = new Point(395, 43);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvReceivePurchaseOrder
            // 
            dgvReceivePurchaseOrder.AllowUserToAddRows = false;
            dgvReceivePurchaseOrder.AllowUserToDeleteRows = false;
            dgvReceivePurchaseOrder.AllowUserToResizeColumns = false;
            dgvReceivePurchaseOrder.AllowUserToResizeRows = false;
            dgvReceivePurchaseOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReceivePurchaseOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReceivePurchaseOrder.BackgroundColor = Color.White;
            dgvReceivePurchaseOrder.BorderStyle = BorderStyle.None;
            dgvReceivePurchaseOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceivePurchaseOrder.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvReceivePurchaseOrder.Location = new Point(556, 520);
            dgvReceivePurchaseOrder.Margin = new Padding(4, 5, 4, 5);
            dgvReceivePurchaseOrder.MultiSelect = false;
            dgvReceivePurchaseOrder.Name = "dgvReceivePurchaseOrder";
            dgvReceivePurchaseOrder.ReadOnly = true;
            dgvReceivePurchaseOrder.RowHeadersWidth = 62;
            dgvReceivePurchaseOrder.Size = new Size(860, 545);
            dgvReceivePurchaseOrder.TabIndex = 0;
            dgvReceivePurchaseOrder.SelectionChanged += dgvReceivePurchaseOrder_SelectionChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(574, 195);
            label1.Name = "label1";
            label1.Size = new Size(784, 98);
            label1.TabIndex = 1;
            label1.Text = "Receive Purchase Order";
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
            back.Location = new Point(1551, 950);
            back.Margin = new Padding(1, 0, 1, 0);
            back.Name = "back";
            back.Size = new Size(216, 64);
            back.TabIndex = 17;
            back.TabStop = true;
            back.Text = "Back";
            back.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxproductfullyreceived
            // 
            checkBoxproductfullyreceived.AutoSize = true;
            checkBoxproductfullyreceived.Location = new Point(960, 379);
            checkBoxproductfullyreceived.Name = "checkBoxproductfullyreceived";
            checkBoxproductfullyreceived.Size = new Size(132, 29);
            checkBoxproductfullyreceived.TabIndex = 18;
            checkBoxproductfullyreceived.Text = "All Received";
            checkBoxproductfullyreceived.UseVisualStyleBackColor = true;
            checkBoxproductfullyreceived.CheckedChanged += checkBoxproductfullyreceived_CheckedChanged;
            // 
            // numericUpDownReceivedQuantity
            // 
            numericUpDownReceivedQuantity.Location = new Point(667, 377);
            numericUpDownReceivedQuantity.Name = "numericUpDownReceivedQuantity";
            numericUpDownReceivedQuantity.Size = new Size(180, 31);
            numericUpDownReceivedQuantity.TabIndex = 19;
            // 
            // btnAllReceived
            // 
            btnAllReceived.BackColor = Color.FromArgb(10, 35, 66);
            btnAllReceived.Cursor = Cursors.Hand;
            btnAllReceived.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAllReceived.ForeColor = Color.White;
            btnAllReceived.Location = new Point(667, 454);
            btnAllReceived.Name = "btnAllReceived";
            btnAllReceived.Size = new Size(129, 47);
            btnAllReceived.TabIndex = 23;
            btnAllReceived.Text = "All Received";
            btnAllReceived.UseVisualStyleBackColor = false;
            btnAllReceived.Click += btnAllReceived_Click;
            // 
            // btnSaveReceipt
            // 
            btnSaveReceipt.BackColor = Color.FromArgb(10, 35, 66);
            btnSaveReceipt.Cursor = Cursors.Hand;
            btnSaveReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveReceipt.ForeColor = Color.White;
            btnSaveReceipt.Location = new Point(478, 445);
            btnSaveReceipt.Name = "btnSaveReceipt";
            btnSaveReceipt.Size = new Size(129, 47);
            btnSaveReceipt.TabIndex = 24;
            btnSaveReceipt.Text = "Save";
            btnSaveReceipt.UseVisualStyleBackColor = false;
            btnSaveReceipt.Click += btnSaveReceipt_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(10, 35, 66);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(856, 454);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 47);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ReceivePurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1148);
            Controls.Add(btnBack);
            Controls.Add(btnSaveReceipt);
            Controls.Add(btnAllReceived);
            Controls.Add(numericUpDownReceivedQuantity);
            Controls.Add(checkBoxproductfullyreceived);
            Controls.Add(dgvReceivePurchaseOrder);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ReceivePurchaseOrder";
            Text = " Receive Purchase Order";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceivePurchaseOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReceivedQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvReceivePurchaseOrder;
        private Label label1;
        private LinkLabel back;
        private PictureBox pictureBox2;
        private CheckBox checkBoxproductfullyreceived;
        private NumericUpDown numericUpDownReceivedQuantity;
        private Button btnAllReceived;
        private Button btnSaveReceipt;
        private Button btnBack;
    }
}