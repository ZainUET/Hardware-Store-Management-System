namespace Bismillah.UI
{
    partial class AddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaff));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtCNIC = new TextBox();
            txtSalary = new TextBox();
            txtPassword = new TextBox();
            txtContact = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            cmbRole = new ComboBox();
            btnsave = new Button();
            btnBack = new LinkLabel();
            button1 = new Button();
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
            tableLayoutPanel2.Size = new Size(2914, 208);
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
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(403, 67);
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
            tableLayoutPanel1.BackColor = Color.FromArgb(240, 245, 255);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(txtCNIC, 0, 5);
            tableLayoutPanel1.Controls.Add(txtSalary, 0, 4);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(txtContact, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtName, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbRole, 0, 6);
            tableLayoutPanel1.Controls.Add(btnsave, 0, 7);
            tableLayoutPanel1.Location = new Point(766, 298);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(536, 687);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(100, 436);
            txtCNIC.Margin = new Padding(100, 25, 26, 25);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.PlaceholderText = "CNIC";
            txtCNIC.Size = new Size(343, 31);
            txtCNIC.TabIndex = 12;
            txtCNIC.KeyPress += txtCNIC_KeyPress_1;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(100, 355);
            txtSalary.Margin = new Padding(100, 25, 26, 25);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "Salary";
            txtSalary.Size = new Size(343, 31);
            txtSalary.TabIndex = 11;
            txtSalary.KeyPress += txtSalary_KeyPress_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 274);
            txtPassword.Margin = new Padding(100, 25, 26, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(343, 31);
            txtPassword.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(100, 193);
            txtContact.Margin = new Padding(100, 25, 26, 25);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(343, 31);
            txtContact.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 35, 66);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(529, 87);
            label1.TabIndex = 0;
            label1.Text = "Add Staff";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 112);
            txtName.Margin = new Padding(100, 25, 26, 25);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(343, 31);
            txtName.TabIndex = 2;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(100, 517);
            cmbRole.Margin = new Padding(100, 25, 26, 25);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(343, 33);
            cmbRole.TabIndex = 9;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.FromArgb(10, 35, 66);
            btnsave.Cursor = Cursors.Hand;
            btnsave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(175, 599);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(186, 63);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click_1;
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
            btnBack.Location = new Point(2599, 1872);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 59);
            btnBack.TabIndex = 5;
            btnBack.TabStop = true;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1434, 1012);
            button1.Name = "button1";
            button1.Size = new Size(186, 63);
            button1.TabIndex = 14;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 978);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "AddStaff";
            Text = "AddSatff";
            WindowState = FormWindowState.Maximized;
            Load += AddStaff_Load;
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
        private Button btnsave;
        private Button button1;
    }
}