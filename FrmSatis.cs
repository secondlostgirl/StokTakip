using System.Data;
using System.Data.SqlClient;

namespace StokTakip
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SENA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;TrustServerCertificate=True");

        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmM��teriEkle ekle = new frmM��teriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmM��teriListele listele = new frmM��teriListele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm�r�nEkle ekle = new frm�r�nEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm�r�nListele listele = new frm�r�nListele();
            listele.ShowDialog();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                aaa.Text = "";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM m��teri WHERE tc = @tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);

            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from urun where barkodno like'" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt�r�nAd�.Text = read["urunadi"].ToString();
                txtSat�Fiyat�.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {

                        if (item != txtMiktari)
                        {
                            item.Text = "";

                        }
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih,telefon) values (@tc,@adsoyad,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih,@telefon)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@urunadi", txt�r�nAd�.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSat�Fiyat�.Text));
            komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            Temizle();
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSat�Fiyat�.Text)).ToString();
            }
            catch
            {
            }

        }

        private void txtSat�Fiyat�_TextChanged(object sender, EventArgs e)
        {

            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSat�Fiyat�.Text)).ToString();
            }
            catch
            {

            }
        }
    }
}
