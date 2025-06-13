namespace Bismillah
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            paastextBox = new TextBox();
            nametextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(paastextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(nametextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(306, 141);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.7647057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.1764717F));
            tableLayoutPanel1.Size = new Size(445, 355);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // paastextBox
            // 
            paastextBox.Anchor = AnchorStyles.None;
            paastextBox.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paastextBox.Location = new Point(62, 224);
            paastextBox.Name = "paastextBox";
            paastextBox.PlaceholderText = "Password:";
            paastextBox.Size = new Size(320, 24);
            paastextBox.TabIndex = 2;
            // 
            // nametextBox
            // 
            nametextBox.Anchor = AnchorStyles.None;
            nametextBox.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nametextBox.Location = new Point(62, 141);
            nametextBox.Name = "nametextBox";
            nametextBox.PlaceholderText = "CNIC:";
            nametextBox.Size = new Size(320, 24);
            nametextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(10, 35, 66);
            button1.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(153, 292);
            button1.Name = "button1";
            button1.Size = new Size(138, 49);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(10, 35, 66);
            label1.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(439, 80);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(10, 35, 66);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(-3, -4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1070, 100);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(215, 0);
            label2.Name = "label2";
            label2.Size = new Size(799, 100);
            label2.TabIndex = 1;
            label2.Text = "Bismillah Sanitary Electric and Hardware Store";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 493);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox nametextBox;
        private Label label2;
        private TextBox paastextBox;
        private Button button1;
    }
}
