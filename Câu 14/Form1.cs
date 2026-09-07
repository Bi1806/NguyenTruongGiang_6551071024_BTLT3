using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Demo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Dữ liệu mẫu
            lstLopA.Items.Add("Trương Xuân Quang");
            lstLopA.Items.Add("Vũ Thị Tuyết Minh");

            lstLopB.Items.Add("Lê Duy Tính");
        }


        // ==========================================
        // CẬP NHẬT
        // ==========================================

        private void btnCapNhat_Click(
            object sender,
            EventArgs e)
        {
            string ten = txtTen.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show(
                    "Không được để trống tên sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTen.Focus();
                return;
            }

            if (cboLop.SelectedIndex == 0)
            {
                lstLopA.Items.Add(ten);
            }
            else
            {
                lstLopB.Items.Add(ten);
            }

            txtTen.Clear();
            txtTen.Focus();
        }


        // ==========================================
        // >
        // ==========================================

        private void btnChuyen1_Click(
            object sender,
            EventArgs e)
        {
            ChuyenItem(lstLopA, lstLopB);
        }


        // ==========================================
        // <
        // ==========================================

        private void btnLui1_Click(
            object sender,
            EventArgs e)
        {
            ChuyenItem(lstLopB, lstLopA);
        }


        // ==========================================
        // CHUYỂN CÁC ITEM ĐANG CHỌN
        // ==========================================

        private void ChuyenItem(
            ListBox nguon,
            ListBox dich)
        {
            List<object> danhSach =
                new List<object>();

            foreach (object item in nguon.SelectedItems)
            {
                danhSach.Add(item);
            }

            foreach (object item in danhSach)
            {
                dich.Items.Add(item);
                nguon.Items.Remove(item);
            }
        }


        // ==========================================
        // >>
        // ==========================================

        private void btnChuyenAll_Click(
            object sender,
            EventArgs e)
        {
            while (lstLopA.Items.Count > 0)
            {
                object item = lstLopA.Items[0];

                lstLopB.Items.Add(item);

                lstLopA.Items.RemoveAt(0);
            }
        }


        // ==========================================
        // <<
        // ==========================================

        private void btnLuiAll_Click(
            object sender,
            EventArgs e)
        {
            while (lstLopB.Items.Count > 0)
            {
                object item = lstLopB.Items[0];

                lstLopA.Items.Add(item);

                lstLopB.Items.RemoveAt(0);
            }
        }


        // ==========================================
        // XÓA LỚP A
        // ==========================================

        private void btnXoaA_Click(
            object sender,
            EventArgs e)
        {
            while (lstLopA.SelectedItems.Count > 0)
            {
                lstLopA.Items.Remove(
                    lstLopA.SelectedItems[0]);
            }
        }


        // ==========================================
        // XÓA LỚP B
        // ==========================================

        private void btnXoaB_Click(
            object sender,
            EventArgs e)
        {
            while (lstLopB.SelectedItems.Count > 0)
            {
                lstLopB.Items.Remove(
                    lstLopB.SelectedItems[0]);
            }
        }


        // ==========================================
        // KẾT THÚC
        // ==========================================

        private void btnKetThuc_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}