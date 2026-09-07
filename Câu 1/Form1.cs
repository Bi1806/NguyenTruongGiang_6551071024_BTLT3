namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtNhapPassword.Clear();
            txtHienthi.Clear();

            txtNhapPassword.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            txtHienthi.Text = txtNhapPassword.Text;
        }
    }
}
