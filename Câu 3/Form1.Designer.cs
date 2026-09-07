namespace Demo3
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
            lblHo = new Label();
            lblTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnExit = new Button();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // lblHo
            // 
            lblHo.AutoSize = true;
            lblHo.Location = new Point(180, 71);
            lblHo.Name = "lblHo";
            lblHo.Size = new Size(54, 20);
            lblHo.TabIndex = 0;
            lblHo.Text = "Họ Lót";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(180, 135);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(32, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(251, 71);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(196, 27);
            txtHo.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(251, 135);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(196, 27);
            txtTen.TabIndex = 3;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(140, 225);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 29);
            btnHo.TabIndex = 4;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(282, 225);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 5;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(443, 225);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(94, 29);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHovaTen_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(251, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát Chương Trình";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.ActiveCaption;
            lblHoTen.Location = new Point(2, 9);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(798, 40);
            lblHoTen.TabIndex = 8;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoTen);
            Controls.Add(btnExit);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblTen);
            Controls.Add(lblHo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHo;
        private Label lblTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnExit;
        private Label lblHoTen;
    }
}
