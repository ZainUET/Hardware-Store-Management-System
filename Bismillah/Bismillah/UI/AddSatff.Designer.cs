namespace Bismillah.UI
{
    partial class AddSatff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSatff));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new LinkLabel();
            txtCNIC = new TextBox();
            txtSalary = new TextBox();
            txtPassword = new TextBox();
            txtContact = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            cmbRole = new ComboBox();
            btnBack = new LinkLabel();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel2.Size = new Size(1898, 208);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(455, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1247, 74);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 7);
            tableLayoutPanel1.Controls.Add(txtCNIC, 0, 5);
            tableLayoutPanel1.Controls.Add(txtSalary, 0, 4);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(txtContact, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbRole, 0, 6);
            tableLayoutPanel1.Location = new Point(727, 266);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.7607346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.2392654F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.Size = new Size(535, 795);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.BorderStyle = BorderStyle.FixedSingle;
            button1.CausesValidation = false;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.LinkBehavior = LinkBehavior.NeverUnderline;
            button1.LinkColor = Color.White;
            button1.Location = new Point(3, 669);
            button1.Name = "button1";
            button1.Size = new Size(529, 126);
            button1.TabIndex = 13;
            button1.TabStop = true;
            button1.Text = "Save";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(100, 482);
            txtCNIC.Margin = new Padding(100, 25, 25, 25);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.PlaceholderText = "CNIC";
            txtCNIC.Size = new Size(342, 31);
            txtCNIC.TabIndex = 12;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(100, 378);
            txtSalary.Margin = new Padding(100, 25, 25, 25);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "Salary";
            txtSalary.Size = new Size(342, 31);
            txtSalary.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 285);
            txtPassword.Margin = new Padding(100, 25, 25, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(342, 31);
            txtPassword.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(100, 195);
            txtContact.Margin = new Padding(100, 25, 25, 25);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(342, 31);
            txtContact.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(529, 86);
            label1.TabIndex = 0;
            label1.Text = "Add Staff";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 115);
            txtName.Margin = new Padding(100, 25, 25, 25);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(342, 31);
            txtName.TabIndex = 2;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(100, 576);
            cmbRole.Margin = new Padding(100, 25, 25, 25);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(342, 33);
            cmbRole.TabIndex = 9;
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
            btnBack.Location = new Point(1584, 1002);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 59);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddSatff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1144);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "AddSatff";
            Text = "AddSatff";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtContact;
        private TextBox txtName;
        private ComboBox cmbRole;
        private LinkLabel btnBack;
        private TextBox txtCNIC;
        private TextBox txtSalary;
        private TextBox txtPassword;
        private LinkLabel button1;
    }
}