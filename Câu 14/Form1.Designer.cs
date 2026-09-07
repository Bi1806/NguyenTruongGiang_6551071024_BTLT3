namespace Demo5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ==========================================
        // KHAI BÁO CONTROL
        // ==========================================

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLop;

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboLop;

        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnChuyen1;
        private System.Windows.Forms.Button btnChuyenAll;
        private System.Windows.Forms.Button btnLui1;
        private System.Windows.Forms.Button btnLuiAll;
        private System.Windows.Forms.Button btnXoaA;
        private System.Windows.Forms.Button btnXoaB;
        private System.Windows.Forms.Button btnKetThuc;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ==========================================
            // KHỞI TẠO CONTROL
            // ==========================================

            this.lblTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();

            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();

            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();

            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnChuyen1 = new System.Windows.Forms.Button();
            this.btnChuyenAll = new System.Windows.Forms.Button();
            this.btnLui1 = new System.Windows.Forms.Button();
            this.btnLuiAll = new System.Windows.Forms.Button();

            this.btnXoaA = new System.Windows.Forms.Button();
            this.btnXoaB = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();


            // ==========================================
            // SUSPEND LAYOUT
            // ==========================================

            this.SuspendLayout();


            // ==========================================
            // LABEL TÊN
            // ==========================================

            this.lblTen.AutoSize = true;

            this.lblTen.Location =
                new System.Drawing.Point(30, 30);

            this.lblTen.Name = "lblTen";

            this.lblTen.Size =
                new System.Drawing.Size(48, 20);

            this.lblTen.TabIndex = 0;

            this.lblTen.Text = "Tên SV:";


            // ==========================================
            // TEXTBOX
            // ==========================================

            this.txtTen.Location =
                new System.Drawing.Point(90, 27);

            this.txtTen.Name = "txtTen";

            this.txtTen.Size =
                new System.Drawing.Size(220, 27);

            this.txtTen.TabIndex = 1;


            // ==========================================
            // LABEL LỚP
            // ==========================================

            this.lblLop.AutoSize = true;

            this.lblLop.Location =
                new System.Drawing.Point(325, 30);

            this.lblLop.Name = "lblLop";

            this.lblLop.Size =
                new System.Drawing.Size(31, 20);

            this.lblLop.TabIndex = 2;

            this.lblLop.Text = "Lớp:";


            // ==========================================
            // COMBOBOX
            // ==========================================

            this.cboLop.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboLop.FormattingEnabled = true;

            this.cboLop.Items.AddRange(
                new object[]
                {
                    "Lớp A",
                    "Lớp B"
                });

            this.cboLop.Location =
                new System.Drawing.Point(365, 27);

            this.cboLop.Name = "cboLop";

            this.cboLop.Size =
                new System.Drawing.Size(100, 28);

            this.cboLop.TabIndex = 3;

            this.cboLop.SelectedIndex = 0;


            // ==========================================
            // BUTTON CẬP NHẬT
            // ==========================================

            this.btnCapNhat.Location =
                new System.Drawing.Point(490, 25);

            this.btnCapNhat.Name =
                "btnCapNhat";

            this.btnCapNhat.Size =
                new System.Drawing.Size(100, 30);

            this.btnCapNhat.TabIndex = 4;

            this.btnCapNhat.Text =
                "Cập nhật";

            this.btnCapNhat.UseVisualStyleBackColor =
                true;

            this.btnCapNhat.Click +=
                new System.EventHandler(
                    this.btnCapNhat_Click);


            // ==========================================
            // LISTBOX LỚP A
            // ==========================================

            this.lstLopA.FormattingEnabled = true;

            this.lstLopA.ItemHeight = 20;

            this.lstLopA.Location =
                new System.Drawing.Point(30, 90);

            this.lstLopA.Name =
                "lstLopA";

            this.lstLopA.SelectionMode =
                System.Windows.Forms.SelectionMode.MultiExtended;

            this.lstLopA.Size =
                new System.Drawing.Size(230, 184);

            this.lstLopA.TabIndex = 5;


            // ==========================================
            // LISTBOX LỚP B
            // ==========================================

            this.lstLopB.FormattingEnabled = true;

            this.lstLopB.ItemHeight = 20;

            this.lstLopB.Location =
                new System.Drawing.Point(360, 90);

            this.lstLopB.Name =
                "lstLopB";

            this.lstLopB.SelectionMode =
                System.Windows.Forms.SelectionMode.MultiExtended;

            this.lstLopB.Size =
                new System.Drawing.Size(230, 184);

            this.lstLopB.TabIndex = 10;


            // ==========================================
            // BUTTON >
            // ==========================================

            this.btnChuyen1.Location =
                new System.Drawing.Point(285, 100);

            this.btnChuyen1.Name =
                "btnChuyen1";

            this.btnChuyen1.Size =
                new System.Drawing.Size(50, 35);

            this.btnChuyen1.TabIndex = 6;

            this.btnChuyen1.Text = ">";

            this.btnChuyen1.UseVisualStyleBackColor =
                true;

            this.btnChuyen1.Click +=
                new System.EventHandler(
                    this.btnChuyen1_Click);


            // ==========================================
            // BUTTON >>
            // ==========================================

            this.btnChuyenAll.Location =
                new System.Drawing.Point(285, 145);

            this.btnChuyenAll.Name =
                "btnChuyenAll";

            this.btnChuyenAll.Size =
                new System.Drawing.Size(50, 35);

            this.btnChuyenAll.TabIndex = 7;

            this.btnChuyenAll.Text = ">>";

            this.btnChuyenAll.UseVisualStyleBackColor =
                true;

            this.btnChuyenAll.Click +=
                new System.EventHandler(
                    this.btnChuyenAll_Click);


            // ==========================================
            // BUTTON <
            // ==========================================

            this.btnLui1.Location =
                new System.Drawing.Point(285, 190);

            this.btnLui1.Name =
                "btnLui1";

            this.btnLui1.Size =
                new System.Drawing.Size(50, 35);

            this.btnLui1.TabIndex = 8;

            this.btnLui1.Text = "<";

            this.btnLui1.UseVisualStyleBackColor =
                true;

            this.btnLui1.Click +=
                new System.EventHandler(
                    this.btnLui1_Click);


            // ==========================================
            // BUTTON <<
            // ==========================================

            this.btnLuiAll.Location =
                new System.Drawing.Point(285, 235);

            this.btnLuiAll.Name =
                "btnLuiAll";

            this.btnLuiAll.Size =
                new System.Drawing.Size(50, 35);

            this.btnLuiAll.TabIndex = 9;

            this.btnLuiAll.Text = "<<";

            this.btnLuiAll.UseVisualStyleBackColor =
                true;

            this.btnLuiAll.Click +=
                new System.EventHandler(
                    this.btnLuiAll_Click);


            // ==========================================
            // BUTTON XÓA A
            // ==========================================

            this.btnXoaA.Location =
                new System.Drawing.Point(30, 310);

            this.btnXoaA.Name =
                "btnXoaA";

            this.btnXoaA.Size =
                new System.Drawing.Size(110, 35);

            this.btnXoaA.TabIndex = 11;

            this.btnXoaA.Text =
                "Xóa Lớp A";

            this.btnXoaA.UseVisualStyleBackColor =
                true;

            this.btnXoaA.Click +=
                new System.EventHandler(
                    this.btnXoaA_Click);


            // ==========================================
            // BUTTON KẾT THÚC
            // ==========================================

            this.btnKetThuc.Location =
                new System.Drawing.Point(270, 310);

            this.btnKetThuc.Name =
                "btnKetThuc";

            this.btnKetThuc.Size =
                new System.Drawing.Size(110, 35);

            this.btnKetThuc.TabIndex = 12;

            this.btnKetThuc.Text =
                "Kết thúc";

            this.btnKetThuc.UseVisualStyleBackColor =
                true;

            this.btnKetThuc.Click +=
                new System.EventHandler(
                    this.btnKetThuc_Click);


            // ==========================================
            // BUTTON XÓA B
            // ==========================================

            this.btnXoaB.Location =
                new System.Drawing.Point(480, 310);

            this.btnXoaB.Name =
                "btnXoaB";

            this.btnXoaB.Size =
                new System.Drawing.Size(110, 35);

            this.btnXoaB.TabIndex = 13;

            this.btnXoaB.Text =
                "Xóa Lớp B";

            this.btnXoaB.UseVisualStyleBackColor =
                true;

            this.btnXoaB.Click +=
                new System.EventHandler(
                    this.btnXoaB_Click);


            // ==========================================
            // FORM
            // ==========================================

            this.AcceptButton = this.btnCapNhat;

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(630, 380);

            this.Controls.Add(this.btnXoaB);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoaA);

            this.Controls.Add(this.btnLuiAll);
            this.Controls.Add(this.btnLui1);
            this.Controls.Add(this.btnChuyenAll);
            this.Controls.Add(this.btnChuyen1);

            this.Controls.Add(this.lstLopB);
            this.Controls.Add(this.lstLopA);

            this.Controls.Add(this.btnCapNhat);

            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblLop);

            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);

            this.Name = "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý sinh viên lớp A - lớp B";

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}