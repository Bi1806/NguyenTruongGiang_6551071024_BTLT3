namespace Demo1
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
            lblPassWord = new Label();
            lblHienthi = new Label();
            txtNhapPassword = new TextBox();
            txtHienthi = new TextBox();
            btnTiep = new Button();
            btnDong = new Button();
            btnHienthi = new Button();
            SuspendLayout();
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassWord.Location = new Point(197, 65);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(122, 20);
            lblPassWord.TabIndex = 0;
            lblPassWord.Text = "Nhập password:";
            // 
            // lblHienthi
            // 
            lblHienthi.AutoSize = true;
            lblHienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHienthi.Location = new Point(248, 159);
            lblHienthi.Name = "lblHienthi";
            lblHienthi.Size = new Size(68, 20);
            lblHienthi.TabIndex = 1;
            lblHienthi.Text = "Hiển thị:";
            // 
            // txtNhapPassword
            // 
            txtNhapPassword.Location = new Point(315, 62);
            txtNhapPassword.Name = "txtNhapPassword";
            txtNhapPassword.PasswordChar = '*';
            txtNhapPassword.Size = new Size(202, 27);
            txtNhapPassword.TabIndex = 2;
            // 
            // txtHienthi
            // 
            txtHienthi.Font = new Font("Segoe UI", 9F);
            txtHienthi.Location = new Point(315, 159);
            txtHienthi.Name = "txtHienthi";
            txtHienthi.Size = new Size(202, 27);
            txtHienthi.TabIndex = 3;
            // 
            // btnTiep
            // 
            btnTiep.BackColor = SystemColors.ControlLight;
            btnTiep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTiep.Location = new Point(334, 272);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(102, 29);
            btnTiep.TabIndex = 5;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = false;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = SystemColors.ControlLight;
            btnDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDong.Location = new Point(516, 272);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(105, 29);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnHienthi
            // 
            btnHienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHienthi.Location = new Point(177, 272);
            btnHienthi.Name = "btnHienthi";
            btnHienthi.Size = new Size(94, 29);
            btnHienthi.TabIndex = 7;
            btnHienthi.Text = "Hiển Thị";
            btnHienthi.UseVisualStyleBackColor = true;
            btnHienthi.Click += btnHienthi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHienthi);
            Controls.Add(btnDong);
            Controls.Add(btnTiep);
            Controls.Add(txtHienthi);
            Controls.Add(txtNhapPassword);
            Controls.Add(lblHienthi);
            Controls.Add(lblPassWord);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassWord;
        private Label lblHienthi;
        private TextBox txtNhapPassword;
        private TextBox txtHienthi;
        private Button btnTiep;
        private Button btnDong;
        private Button btnHienthi;
    }
}
