using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp44
{
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AhmetCivan\Documents\FitnessDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();

        }
        int key = 0;
        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(UyeDGV.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTb.Text = UyeDGV.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = UyeDGV.SelectedRows[0].Cells[2].Value.ToString();
            CinsiyetCb.Text = UyeDGV.SelectedRows[0].Cells[3].Value.ToString();
            YasTb.Text = UyeDGV.SelectedRows[0].Cells[4].Value.ToString();
            OdemeTb.Text = UyeDGV.SelectedRows[0].Cells[5].Value.ToString();
            ZamanlamaCb.Text = UyeDGV.SelectedRows[0].Cells[6].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = " ";
            TelefonTb.Text = " ";
            CinsiyetCb.Text = " ";
            YasTb.Text = " ";
            OdemeTb.Text = " ";
            ZamanlamaCb.Text = " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void buttob3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTbl where UID=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Silindi");
                    baglanti.Close();
                    uyeler();


                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || AdSoyadTb.Text == "" || TelefonTb.Text == "" || CinsiyetCb.Text == "" || YasTb.Text == "" || OdemeTb.Text == "" || ZamanlamaCb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTbl set UAdSoyad='" + AdSoyadTb.Text + "',UTelefon='" + TelefonTb.Text + "',UCinsiyet='" + CinsiyetCb.Text + "',UYas='" + YasTb.Text + "',UOdeme='" + OdemeTb.Text + "',UZamanlama='" + ZamanlamaCb.Text + "'where UId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }

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

        private void CinsiyetCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Tüm girişleri engell
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

        private void ZamanlamaCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Tüm girişleri engel
        }
    }
}
