namespace StokTakip
{
    partial class FrmSatis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            aaa = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtToplamFiyat = new TextBox();
            txtSatşFiyatı = new TextBox();
            txtMiktari = new TextBox();
            txtÜrünAdı = new TextBox();
            txtBarkodNo = new TextBox();
            btnEkle = new Button();
            btnSatışYap = new Button();
            btnSil = new Button();
            btnSatışİptal = new Button();
            label9 = new Label();
            lblGenelToplam = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            aaa.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(575, 308);
            dataGridView1.TabIndex = 0;
            // 
            // aaa
            // 
            aaa.Controls.Add(label3);
            aaa.Controls.Add(label2);
            aaa.Controls.Add(label1);
            aaa.Controls.Add(txtTelefon);
            aaa.Controls.Add(txtAdSoyad);
            aaa.Controls.Add(txtTc);
            aaa.Location = new Point(28, 148);
            aaa.Name = "aaa";
            aaa.Size = new Size(320, 154);
            aaa.TabIndex = 1;
            aaa.TabStop = false;
            aaa.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 103);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 62);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 29);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 3;
            label1.Text = "TC";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(137, 103);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(137, 59);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(137, 26);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 0;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatşFiyatı);
            groupBox2.Controls.Add(txtMiktari);
            groupBox2.Controls.Add(txtÜrünAdı);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Location = new Point(28, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 184);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 147);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 10;
            label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 114);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 9;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 84);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 8;
            label6.Text = "Miktarı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 51);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 7;
            label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 23);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "BarkodNo";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(137, 147);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(125, 27);
            txtToplamFiyat.TabIndex = 4;
            txtToplamFiyat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSatşFiyatı
            // 
            txtSatşFiyatı.Location = new Point(137, 114);
            txtSatşFiyatı.Name = "txtSatşFiyatı";
            txtSatşFiyatı.Size = new Size(125, 27);
            txtSatşFiyatı.TabIndex = 3;
            txtSatşFiyatı.TextAlign = HorizontalAlignment.Center;
            txtSatşFiyatı.TextChanged += txtSatşFiyatı_TextChanged;
            // 
            // txtMiktari
            // 
            txtMiktari.Location = new Point(137, 81);
            txtMiktari.Name = "txtMiktari";
            txtMiktari.Size = new Size(125, 27);
            txtMiktari.TabIndex = 2;
            txtMiktari.Text = "1";
            txtMiktari.TextAlign = HorizontalAlignment.Center;
            txtMiktari.TextChanged += txtMiktari_TextChanged;
            // 
            // txtÜrünAdı
            // 
            txtÜrünAdı.Location = new Point(137, 48);
            txtÜrünAdı.Name = "txtÜrünAdı";
            txtÜrünAdı.Size = new Size(125, 27);
            txtÜrünAdı.TabIndex = 1;
            txtÜrünAdı.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(137, 15);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(125, 27);
            txtBarkodNo.TabIndex = 0;
            txtBarkodNo.TextAlign = HorizontalAlignment.Center;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(404, 489);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSatışYap
            // 
            btnSatışYap.Location = new Point(514, 489);
            btnSatışYap.Name = "btnSatışYap";
            btnSatışYap.Size = new Size(94, 29);
            btnSatışYap.TabIndex = 4;
            btnSatışYap.Text = "Satış Yap";
            btnSatışYap.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(993, 177);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSatışİptal
            // 
            btnSatışİptal.Location = new Point(993, 228);
            btnSatışİptal.Name = "btnSatışİptal";
            btnSatışİptal.Size = new Size(94, 29);
            btnSatışİptal.TabIndex = 6;
            btnSatışİptal.Text = "Satış İptal";
            btnSatışİptal.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(764, 493);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 7;
            label9.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Location = new Point(871, 493);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(33, 20);
            lblGenelToplam.TabIndex = 8;
            lblGenelToplam.Text = "000";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 125);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(952, 45);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 6;
            button2.Text = "Marka";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(798, 45);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 5;
            button1.Text = "Kategori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(640, 45);
            button9.Name = "button9";
            button9.Size = new Size(147, 48);
            button9.TabIndex = 4;
            button9.Text = "Satışları Listeleme";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(487, 45);
            button8.Name = "button8";
            button8.Size = new Size(147, 48);
            button8.TabIndex = 3;
            button8.Text = "Ürün Listeleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(334, 45);
            button7.Name = "button7";
            button7.Size = new Size(147, 48);
            button7.TabIndex = 2;
            button7.Text = "Ürün Ekleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(181, 45);
            button6.Name = "button6";
            button6.Size = new Size(147, 48);
            button6.TabIndex = 1;
            button6.Text = "Müşteri Listeleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(28, 45);
            button5.Name = "button5";
            button5.Size = new Size(147, 48);
            button5.TabIndex = 0;
            button5.Text = "Müşteri Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FrmSatis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1139, 597);
            Controls.Add(panel1);
            Controls.Add(lblGenelToplam);
            Controls.Add(label9);
            Controls.Add(btnSatışİptal);
            Controls.Add(btnSil);
            Controls.Add(btnSatışYap);
            Controls.Add(btnEkle);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(aaa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Sayfası";
            Load += FrmSatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            aaa.ResumeLayout(false);
            aaa.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox aaa;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtToplamFiyat;
        private TextBox txtSatşFiyatı;
        private TextBox txtMiktari;
        private TextBox txtÜrünAdı;
        private TextBox txtBarkodNo;
        private Button btnEkle;
        private Button btnSatışYap;
        private Button btnSil;
        private Button btnSatışİptal;
        private Label label9;
        private Label lblGenelToplam;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button1;
    }
}
