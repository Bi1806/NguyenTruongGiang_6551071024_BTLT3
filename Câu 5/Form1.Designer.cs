namespace Demo4
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
            lblTen = new Label();
            txtNhapTen = new TextBox();
            radRed = new RadioButton();
            chkBold = new CheckBox();
            label1 = new Label();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            label2 = new Label();
            chkUnderline = new CheckBox();
            label3 = new Label();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            chkItalic = new CheckBox();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.BackColor = SystemColors.ActiveCaptionText;
            lblTen.ForeColor = Color.Lime;
            lblTen.Location = new Point(135, 44);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(73, 20);
            lblTen.TabIndex = 0;
            lblTen.Text = "Nhập tên:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(214, 44);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(256, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.BackColor = SystemColors.ActiveCaption;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(135, 136);
            radRed.Name = "radRed";
            radRed.Size = new Size(56, 24);
            radRed.TabIndex = 2;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = false;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.BackColor = Color.FromArgb(255, 192, 128);
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.FromArgb(0, 0, 192);
            chkBold.Location = new Point(413, 136);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 3;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = false;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(121, 88);
            label1.Name = "label1";
            label1.Size = new Size(193, 218);
            label1.TabIndex = 4;
            label1.Text = "Color";
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.BackColor = SystemColors.ActiveCaption;
            radGreen.ForeColor = Color.Lime;
            radGreen.Location = new Point(135, 181);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(69, 24);
            radGreen.TabIndex = 5;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = false;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.BackColor = SystemColors.ActiveCaption;
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(135, 226);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(59, 24);
            radBlue.TabIndex = 6;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = false;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.BackColor = SystemColors.ActiveCaption;
            radBlack.ForeColor = SystemColors.ActiveCaptionText;
            radBlack.Location = new Point(135, 270);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(65, 24);
            radBlack.TabIndex = 7;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = false;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(384, 91);
            label2.Name = "label2";
            label2.Size = new Size(193, 221);
            label2.TabIndex = 8;
            label2.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.BackColor = Color.FromArgb(255, 192, 128);
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            chkUnderline.ForeColor = Color.FromArgb(0, 0, 192);
            chkUnderline.Location = new Point(413, 227);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(103, 24);
            chkUnderline.TabIndex = 10;
            chkUnderline.Text = "Gạch chân";
            chkUnderline.UseVisualStyleBackColor = false;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(121, 324);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 11;
            label3.Text = "Lập Trình Bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BackColor = SystemColors.ControlDark;
            lblLapTrinh.ForeColor = Color.Lime;
            lblLapTrinh.Location = new Point(245, 324);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(169, 20);
            lblLapTrinh.TabIndex = 12;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(420, 315);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 34);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.BackColor = Color.FromArgb(255, 192, 128);
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkItalic.ForeColor = Color.FromArgb(0, 0, 192);
            chkItalic.Location = new Point(413, 182);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(133, 24);
            chkItalic.TabIndex = 9;
            chkItalic.Text = "Nghiêng italic";
            chkItalic.UseVisualStyleBackColor = false;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(label3);
            Controls.Add(chkUnderline);
            Controls.Add(chkItalic);
            Controls.Add(radBlack);
            Controls.Add(radBlue);
            Controls.Add(radGreen);
            Controls.Add(chkBold);
            Controls.Add(radRed);
            Controls.Add(txtNhapTen);
            Controls.Add(lblTen);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTen;
        private TextBox txtNhapTen;
        private RadioButton radRed;
        private CheckBox chkBold;
        private Label label1;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private Label label2;
        private CheckBox chkUnderline;
        private Label label3;
        private Label lblLapTrinh;
        private Button btnThoat;
        private CheckBox chkItalic;
    }
}
