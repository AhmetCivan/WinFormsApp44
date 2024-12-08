namespace WinFormsApp44
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            KullanýcýTb.Text = "";
            SifreTb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KullanýcýTb.Text == "" || SifreTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else if (KullanýcýTb.Text == "Admin" && SifreTb.Text == "1905")
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý ya da Þifre");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
