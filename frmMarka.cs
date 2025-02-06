﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace StokTakip
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SENA\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False;");


        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kategori"].ToString() &&  textBox1.Text == read["marka"].ToString() || comboBox1.Text == "" || textBox1.Text=="")
                {

                    durum = false;

                }
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri (kategori,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi");
               
               
            }
            else
            {
                MessageBox.Show("Bu isimle birkategori ve marka bulunmakta");
            }
            textBox1.Text = "";
            comboBox1.Text = "";
        }
        private void kategorigetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());

            }
            baglanti.Close();
        }
        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}
