using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void kategorigetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
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
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());

            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
            komut.Parameters.AddWithValue("@marka", comboMarka.Text);
            komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlışFiyatı.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi");
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }

                }
            }
        }

        private void BarkodNoTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
        }
    }
}
