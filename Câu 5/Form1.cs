namespace Demo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
            lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
            //câu lệnh dựa trên toán tử logic Xor 
            //0 Xor 1=1
            //1 Xor 1=0


        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtNhapTen.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtNhapTen.ForeColor = Color.Black;
        }


        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
         lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {

            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
         lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
