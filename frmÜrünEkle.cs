using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=SENA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False;");
        bool durum;

        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM urun WHERE barkodno = @barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            int count = (int)komut.ExecuteScalar();
            baglanti.Close();

            if (count > 0 || string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                durum = false;
            }
        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT kategori FROM kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT marka FROM markabilgileri WHERE kategori = @kategori", baglanti);
            komut.Parameters.AddWithValue("@kategori", comboKategori.SelectedItem.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                if (string.IsNullOrWhiteSpace(txtBarkodNo.Text) || string.IsNullOrWhiteSpace(txtÜrünAdı.Text) ||
                    string.IsNullOrWhiteSpace(comboKategori.Text) || string.IsNullOrWhiteSpace(comboMarka.Text) ||
                    string.IsNullOrWhiteSpace(txtMiktarı.Text) || string.IsNullOrWhiteSpace(txtAlışFiyatı.Text) ||
                    string.IsNullOrWhiteSpace(txtSatışFiyatı.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                if (!int.TryParse(txtMiktarı.Text, out int miktar) || !double.TryParse(txtAlışFiyatı.Text, out double alisFiyati) ||
                    !double.TryParse(txtSatışFiyatı.Text, out double satisFiyati))
                {
                    MessageBox.Show("Miktar, Alış Fiyatı ve Satış Fiyatı geçerli bir sayı olmalıdır!");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO urun (barkodno, kategori, marka, urunadi, miktari, alisfiyati, satisfiyati, tarih) " +
                                                  "VALUES (@barkodno, @kategori, @marka, @urunadi, @miktari, @alisfiyati, @satisfiyati, @tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", miktar);
                komut.Parameters.AddWithValue("@alisfiyati", alisFiyati);
                komut.Parameters.AddWithValue("@satisfiyati", satisFiyati);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün eklendi!");

                Temizle(groupBox1);
            }
            else
            {
                MessageBox.Show("Böyle bir Barkod No zaten var!");
            }
        }

        private void BarkodNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BarkodNoTxt.Text))
            {
                Temizle(groupBox1);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno = @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNoTxt.Text);
                SqlDataReader read = komut.ExecuteReader();

                if (read.Read())
                {
                    KategoriTxt.Text = read["kategori"].ToString();
                    MarkaTxt.Text = read["marka"].ToString();
                    llblMiktari.Text = read["miktari"].ToString();
                    ÜrünAdıTxt.Text = read["urunadi"].ToString();
                    AlışFiyatıTxt.Text = read["alisfiyati"].ToString();
                    SatışFiyatıTxt.Text = read["satisfiyati"].ToString();
                }

                baglanti.Close();
            }
            else
            {
                Temizle(groupBox1);
            }
        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MiktarıTxt.Text) || !int.TryParse(MiktarıTxt.Text, out int miktar))
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin!");
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE urun SET miktari = miktari + @miktar WHERE barkodno = @barkodno", baglanti);
            komut.Parameters.AddWithValue("@miktar", miktar);
            komut.Parameters.AddWithValue("@barkodno", BarkodNoTxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            Temizle(groupBox2);
            MessageBox.Show("Ürün miktarı güncellendi!");
        }

        private void Temizle(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }
    }
}
