using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp44
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AhmetCivan\Documents\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");



       

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || TelefonTb.Text == "" || OdemeTb.Text == "" || YasTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");


            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into UyeTbl values('" + AdSoyadTb.Text + "','" + TelefonTb.Text + "','" + CinsiyetCb.SelectedItem.ToString() + "','" + YasTb.Text + "','" + OdemeTb.Text + "','" + ZamanlamaCb.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Eklendi");
                    baglanti.Close();
                    AdSoyadTb.Text = "";
                    TelefonTb.Text = "";
                    OdemeTb.Text = "";
                    YasTb.Text = "";
                    CinsiyetCb.Text = "";
                    ZamanlamaCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            OdemeTb.Text = "";
            YasTb.Text = "";
            CinsiyetCb.Text = "";
            ZamanlamaCb.Text = "";


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();


        }

        private void AdSoyadTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter harf değilse ve boşluk değilse
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Geçersiz yap
            }
        }

        private void TelefonTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter rakam değilse ve Backspace değilse
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Geçersiz yap
            }
        }

        private void YasTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter rakam değilse ve Backspace değilse
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Geçersiz yap
            }
        }

        private void OdemeTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter rakam değilse ve Backspace değilse
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Geçersiz yap
            }
        }

        private void CinsiyetCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Tüm girişleri engell
        }

        private void ZamanlamaCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Tüm girişleri engell
        }
    }
}
