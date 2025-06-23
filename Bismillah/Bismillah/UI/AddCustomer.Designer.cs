namespace Bismillah.UI
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnBack = new LinkLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtaddress = new TextBox();
            cnictxt = new TextBox();
            txtContact = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            btnsave = new Button();
            button = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel2.Location = new Point(-1, 0);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(2407, 208);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 198);
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
            label2.Location = new Point(333, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(10, 35, 66);
            btnBack.BorderStyle = BorderStyle.FixedSingle;
            btnBack.CausesValidation = false;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.LinkBehavior = LinkBehavior.NeverUnderline;
            btnBack.LinkColor = Color.White;
            btnBack.Location = new Point(2092, 1267);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 59);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.BackColor = Color.FromArgb(240, 245, 255);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(txtaddress, 0, 4);
            tableLayoutPanel3.Controls.Add(cnictxt, 0, 3);
            tableLayoutPanel3.Controls.Add(txtContact, 0, 2);
            tableLayoutPanel3.Controls.Add(txtName, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(btnsave, 0, 7);
            tableLayoutPanel3.Location = new Point(635, 343);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(536, 518);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(100, 355);
            txtaddress.Margin = new Padding(100, 25, 26, 25);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Address";
            txtaddress.Size = new Size(343, 31);
            txtaddress.TabIndex = 17;
            // 
            // cnictxt
            // 
            cnictxt.Location = new Point(100, 274);
            cnictxt.Margin = new Padding(100, 25, 26, 25);
            cnictxt.Name = "cnictxt";
            cnictxt.PlaceholderText = "CNIC";
            cnictxt.Size = new Size(343, 31);
            cnictxt.TabIndex = 16;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(100, 193);
            txtContact.Margin = new Padding(100, 25, 26, 25);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(343, 31);
            txtContact.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 112);
            txtName.Margin = new Padding(100, 25, 26, 25);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(343, 31);
            txtName.TabIndex = 14;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(10, 35, 66);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(529, 87);
            label3.TabIndex = 0;
            label3.Text = "Add Customer";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.FromArgb(10, 35, 66);
            btnsave.Cursor = Cursors.Hand;
            btnsave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(175, 433);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(186, 63);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // button
            // 
            button.Anchor = AnchorStyles.None;
            button.BackColor = Color.FromArgb(10, 35, 66);
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Location = new Point(1365, 776);
            button.Name = "button";
            button.Size = new Size(186, 63);
            button.TabIndex = 15;
            button.Text = "Back";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1878, 1013);
            Controls.Add(button);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCustomer";
            Text = "Add Customer";
            WindowState = FormWindowState.Maximized;
            Load += AddCustomer_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private LinkLabel btnBack;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Button btnsave;
        private TextBox txtaddress;
        private TextBox cnictxt;
        private TextBox txtContact;
        private TextBox txtName;
        private Button button;
    }
}