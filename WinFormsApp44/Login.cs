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
            Kullan�c�Tb.Text = "";
            SifreTb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Kullan�c�Tb.Text == "" || SifreTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else if (Kullan�c�Tb.Text == "Admin" && SifreTb.Text == "1905")
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatal� Kullan�c� Ad� ya da �ifre");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
