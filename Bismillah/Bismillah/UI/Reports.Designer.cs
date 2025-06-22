namespace Bismillah.UI
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            back = new LinkLabel();
            cmbreport = new ComboBox();
            btnexportexcel = new Button();
            dvgreport = new DataGridView();
            btnExportPDF = new Button();
            label3 = new Label();
            btnBack = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgreport).BeginInit();
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
            tableLayoutPanel2.Size = new Size(2283, 208);
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
            label2.Location = new Point(316, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(584, 222);
            label1.Name = "label1";
            label1.Size = new Size(784, 98);
            label1.TabIndex = 1;
            label1.Text = "Reports";
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
            back.Location = new Point(1779, 1152);
            back.Name = "back";
            back.Size = new Size(216, 64);
            back.TabIndex = 17;
            back.TabStop = true;
            back.Text = "Back";
            back.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbreport
            // 
            cmbreport.Cursor = Cursors.Hand;
            cmbreport.FormattingEnabled = true;
            cmbreport.Location = new Point(286, 445);
            cmbreport.Name = "cmbreport";
            cmbreport.Size = new Size(308, 33);
            cmbreport.TabIndex = 21;
            cmbreport.SelectedIndexChanged += cmbreport_SelectedIndexChanged;
            // 
            // btnexportexcel
            // 
            btnexportexcel.BackColor = Color.FromArgb(10, 35, 66);
            btnexportexcel.Cursor = Cursors.Hand;
            btnexportexcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnexportexcel.ForeColor = Color.White;
            btnexportexcel.Location = new Point(644, 416);
            btnexportexcel.Name = "btnexportexcel";
            btnexportexcel.Size = new Size(186, 63);
            btnexportexcel.TabIndex = 22;
            btnexportexcel.Text = "Export Excel";
            btnexportexcel.UseVisualStyleBackColor = false;
            btnexportexcel.Click += btnexportexcel_Click;
            // 
            // dvgreport
            // 
            dvgreport.AllowUserToAddRows = false;
            dvgreport.AllowUserToDeleteRows = false;
            dvgreport.AllowUserToOrderColumns = true;
            dvgreport.AllowUserToResizeColumns = false;
            dvgreport.AllowUserToResizeRows = false;
            dvgreport.BackgroundColor = Color.White;
            dvgreport.BorderStyle = BorderStyle.None;
            dvgreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgreport.EditMode = DataGridViewEditMode.EditProgrammatically;
            dvgreport.Location = new Point(263, 505);
            dvgreport.MultiSelect = false;
            dvgreport.Name = "dvgreport";
            dvgreport.ReadOnly = true;
            dvgreport.RowHeadersWidth = 62;
            dvgreport.Size = new Size(1123, 552);
            dvgreport.TabIndex = 24;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.FromArgb(10, 35, 66);
            btnExportPDF.Cursor = Cursors.Hand;
            btnExportPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportPDF.ForeColor = Color.White;
            btnExportPDF.Location = new Point(914, 415);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(186, 63);
            btnExportPDF.TabIndex = 25;
            btnExportPDF.Text = "Export Pdf";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(286, 415);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 26;
            label3.Text = "Select a Report:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(10, 35, 66);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1182, 416);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(186, 63);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1714, 1170);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(btnExportPDF);
            Controls.Add(dvgreport);
            Controls.Add(btnexportexcel);
            Controls.Add(cmbreport);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Reports";
            Text = "Reports Generation";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgreport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label1;
        private LinkLabel back;
        private PictureBox pictureBox2;
        private ComboBox cmbreport;
        private Button btnexportexcel;
        private DataGridView dvgreport;
        private Button btnExportPDF;
        private Label label3;
        private Button btnBack;
    }
}