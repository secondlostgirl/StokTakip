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
    public partial class frmÜrünListele : Form
    {
        public frmÜrünListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SENA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False;");
        DataSet daset = new DataSet();
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);

            SqlDataReader read = komut.ExecuteReader(); // Değişken oluşturuldu
            while (read.Read()) // .Read() metodunu çağırmalısın
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            read.Close(); // Okuma işlemi bitince kapat
            baglanti.Close(); // Bağlantıyı kapatmayı unutma!


        }
        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];

            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            BarkodNoTxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            KategoriTxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            MarkaTxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıTxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            MiktarıTxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlışFiyatıTxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatışFiyatıTxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNoTxt.Text);
            komut.Parameters.AddWithValue("@urunadi", ÜrünAdıTxt.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(MiktarıTxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(AlışFiyatıTxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(SatışFiyatıTxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Güncelleme Yapıldı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNoTxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNoTxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı");
                daset.Tables["urun"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("Barkodno yazılı değil");
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void BarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM urun WHERE barkodno LIKE @barkodno", baglanti);
            adtr.SelectCommand.Parameters.AddWithValue("@barkodno", "%" + BarkodNoAra.Text + "%");
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
