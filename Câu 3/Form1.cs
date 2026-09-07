namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHovaTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }
    }
}
