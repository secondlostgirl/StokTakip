namespace StokTakip
{
    partial class frmÜrünListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lblMiktarı = new Label();
            llblMiktari = new Label();
            btnGüncelle = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SatışFiyatıTxt = new TextBox();
            AlışFiyatıTxt = new TextBox();
            MiktarıTxt = new TextBox();
            ÜrünAdıTxt = new TextBox();
            MarkaTxt = new TextBox();
            KategoriTxt = new TextBox();
            BarkodNoTxt = new TextBox();
            btnSil = new Button();
            BarkodNoAra = new TextBox();
            label1 = new Label();
            comboKategori = new ComboBox();
            comboMarka = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnMarkaGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(305, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(689, 442);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // lblMiktarı
            // 
            lblMiktarı.AutoSize = true;
            lblMiktarı.Location = new Point(91, 350);
            lblMiktarı.Name = "lblMiktarı";
            lblMiktarı.Size = new Size(0, 20);
            lblMiktarı.TabIndex = 39;
            // 
            // llblMiktari
            // 
            llblMiktari.AutoSize = true;
            llblMiktari.Location = new Point(79, 350);
            llblMiktari.Name = "llblMiktari";
            llblMiktari.Size = new Size(0, 20);
            llblMiktari.TabIndex = 38;
            // 
            // btnGüncelle
            // 
            btnGüncelle.ForeColor = Color.Black;
            btnGüncelle.Location = new Point(185, 387);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 29);
            btnGüncelle.TabIndex = 27;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 348);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 37;
            label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 303);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 36;
            label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(83, 261);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 35;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(71, 215);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 34;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(93, 170);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 33;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(77, 125);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 32;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(71, 83);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 31;
            label14.Text = "Barkod No";
            // 
            // SatışFiyatıTxt
            // 
            SatışFiyatıTxt.Location = new Point(154, 345);
            SatışFiyatıTxt.Name = "SatışFiyatıTxt";
            SatışFiyatıTxt.Size = new Size(125, 27);
            SatışFiyatıTxt.TabIndex = 26;
            // 
            // AlışFiyatıTxt
            // 
            AlışFiyatıTxt.Location = new Point(154, 303);
            AlışFiyatıTxt.Name = "AlışFiyatıTxt";
            AlışFiyatıTxt.Size = new Size(125, 27);
            AlışFiyatıTxt.TabIndex = 30;
            // 
            // MiktarıTxt
            // 
            MiktarıTxt.Location = new Point(154, 261);
            MiktarıTxt.Name = "MiktarıTxt";
            MiktarıTxt.Size = new Size(125, 27);
            MiktarıTxt.TabIndex = 29;
            // 
            // ÜrünAdıTxt
            // 
            ÜrünAdıTxt.Location = new Point(154, 215);
            ÜrünAdıTxt.Name = "ÜrünAdıTxt";
            ÜrünAdıTxt.Size = new Size(125, 27);
            ÜrünAdıTxt.TabIndex = 28;
            // 
            // MarkaTxt
            // 
            MarkaTxt.Location = new Point(154, 170);
            MarkaTxt.Name = "MarkaTxt";
            MarkaTxt.ReadOnly = true;
            MarkaTxt.Size = new Size(125, 27);
            MarkaTxt.TabIndex = 25;
            // 
            // KategoriTxt
            // 
            KategoriTxt.Location = new Point(154, 125);
            KategoriTxt.Name = "KategoriTxt";
            KategoriTxt.ReadOnly = true;
            KategoriTxt.Size = new Size(125, 27);
            KategoriTxt.TabIndex = 24;
            // 
            // BarkodNoTxt
            // 
            BarkodNoTxt.Location = new Point(154, 83);
            BarkodNoTxt.Name = "BarkodNoTxt";
            BarkodNoTxt.Size = new Size(125, 27);
            BarkodNoTxt.TabIndex = 23;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1000, 83);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 40;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // BarkodNoAra
            // 
            BarkodNoAra.Location = new Point(522, 35);
            BarkodNoAra.Name = "BarkodNoAra";
            BarkodNoAra.Size = new Size(331, 27);
            BarkodNoAra.TabIndex = 41;
            BarkodNoAra.TextChanged += BarkodNoAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 42);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 42;
            label1.Text = "Barkod Numarasına Göre Ara";
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(1077, 170);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(151, 28);
            comboKategori.TabIndex = 44;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(1077, 214);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(151, 28);
            comboMarka.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1020, 217);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 47;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1004, 177);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 46;
            label3.Text = "Kategori";
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.ForeColor = Color.Black;
            btnMarkaGuncelle.Location = new Point(1134, 252);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(94, 29);
            btnMarkaGuncelle.TabIndex = 48;
            btnMarkaGuncelle.Text = "Güncelle";
            btnMarkaGuncelle.UseVisualStyleBackColor = true;
            btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
            // 
            // frmÜrünListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1240, 537);
            Controls.Add(btnMarkaGuncelle);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboMarka);
            Controls.Add(comboKategori);
            Controls.Add(label1);
            Controls.Add(BarkodNoAra);
            Controls.Add(btnSil);
            Controls.Add(lblMiktarı);
            Controls.Add(llblMiktari);
            Controls.Add(btnGüncelle);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(SatışFiyatıTxt);
            Controls.Add(AlışFiyatıTxt);
            Controls.Add(MiktarıTxt);
            Controls.Add(ÜrünAdıTxt);
            Controls.Add(MarkaTxt);
            Controls.Add(KategoriTxt);
            Controls.Add(BarkodNoTxt);
            Controls.Add(dataGridView1);
            Name = "frmÜrünListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listeleme Sayfası";
            Load += frmÜrünListele_Load;
            Click += btnSil_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblMiktarı;
        private Label llblMiktari;
        private Button btnGüncelle;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox SatışFiyatıTxt;
        private TextBox AlışFiyatıTxt;
        private TextBox MiktarıTxt;
        private TextBox ÜrünAdıTxt;
        private TextBox MarkaTxt;
        private TextBox KategoriTxt;
        private TextBox BarkodNoTxt;
        private Button btnSil;
        private TextBox BarkodNoAra;
        private Label label1;
        private ComboBox comboKategori;
        private ComboBox comboMarka;
        private Label label2;
        private Label label3;
        private Button btnMarkaGuncelle;
    }
}