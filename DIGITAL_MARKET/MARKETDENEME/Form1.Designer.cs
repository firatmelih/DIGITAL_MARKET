namespace MARKETDENEME
{
    
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TV_LABEL_Fiyat = new System.Windows.Forms.Label();
            this.TV_LABEL_Stok = new System.Windows.Forms.Label();
            this.TV_LABEL_Adet = new System.Windows.Forms.Label();
            this.TV_NUMERIC = new System.Windows.Forms.NumericUpDown();
            this.LAPTOP_LABLE_Fiyat = new System.Windows.Forms.Label();
            this.LAPTOP_LABLE_Stok = new System.Windows.Forms.Label();
            this.LAPTOP_LABLE_Adet = new System.Windows.Forms.Label();
            this.LAPTOP_NUMERIC = new System.Windows.Forms.NumericUpDown();
            this.TELEFON_LABEL_Fiyat = new System.Windows.Forms.Label();
            this.TELEFON_LABEL_Stok = new System.Windows.Forms.Label();
            this.TELEFON_LABEL_Adet = new System.Windows.Forms.Label();
            this.TELEFON_NUMERIC = new System.Windows.Forms.NumericUpDown();
            this.FRIDGE_LABLE_Fiyat = new System.Windows.Forms.Label();
            this.FRIDGE_LABLE_Stok = new System.Windows.Forms.Label();
            this.FRIDGE_LABLE_Adet = new System.Windows.Forms.Label();
            this.FRIDGE_NUMERIC = new System.Windows.Forms.NumericUpDown();
            this.BASLIK1 = new System.Windows.Forms.Label();
            this.BASLIK2 = new System.Windows.Forms.Label();
            this.SIPARIS_ADET = new System.Windows.Forms.Label();
            this.SIPARIS_URUN = new System.Windows.Forms.Label();
            this.SIPARIS_KDV_FIYAT = new System.Windows.Forms.Label();
            this.START_BUTTON = new System.Windows.Forms.Button();
            this.RESET_BUTTON = new System.Windows.Forms.Button();
            this.SIPARIS_ADET_TEXT = new System.Windows.Forms.RichTextBox();
            this.SIPARIS_URUN_TEXT = new System.Windows.Forms.RichTextBox();
            this.SIPARIS_FIYAT_TEXT = new System.Windows.Forms.RichTextBox();
            this.SONUC_LABLE = new System.Windows.Forms.Label();
            this.FIYAT_SONUC = new System.Windows.Forms.Label();
            this.TV_FIYAT_GOSTERGE = new System.Windows.Forms.Label();
            this.TV_STOK_GOSTERGE = new System.Windows.Forms.Label();
            this.BUZDOLABI_FIYAT_GOSTERGE = new System.Windows.Forms.Label();
            this.BUZDOLABI_STOK_GOSTERGE = new System.Windows.Forms.Label();
            this.TELEFON_FIYAT_GOSTERGE = new System.Windows.Forms.Label();
            this.TELEFON_STOK_GOSTERGE = new System.Windows.Forms.Label();
            this.LAPTOP_FIYAT_GOSTERGE = new System.Windows.Forms.Label();
            this.LAPTOP_STOK_GOSTERGE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV_NUMERIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAPTOP_NUMERIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TELEFON_NUMERIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRIDGE_NUMERIC)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MARKETDENEME.Properties.Resources.tv1;
            this.pictureBox1.Location = new System.Drawing.Point(48, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MARKETDENEME.Properties.Resources.fridge1;
            this.pictureBox2.Location = new System.Drawing.Point(422, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 197);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MARKETDENEME.Properties.Resources.laptop;
            this.pictureBox3.Location = new System.Drawing.Point(397, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 105);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MARKETDENEME.Properties.Resources.cellphone;
            this.pictureBox4.Location = new System.Drawing.Point(79, 255);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 197);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // TV_LABEL_Fiyat
            // 
            this.TV_LABEL_Fiyat.AutoSize = true;
            this.TV_LABEL_Fiyat.Location = new System.Drawing.Point(76, 172);
            this.TV_LABEL_Fiyat.Name = "TV_LABEL_Fiyat";
            this.TV_LABEL_Fiyat.Size = new System.Drawing.Size(32, 13);
            this.TV_LABEL_Fiyat.TabIndex = 4;
            this.TV_LABEL_Fiyat.Text = "Fiyat:";
            // 
            // TV_LABEL_Stok
            // 
            this.TV_LABEL_Stok.AutoSize = true;
            this.TV_LABEL_Stok.Location = new System.Drawing.Point(76, 198);
            this.TV_LABEL_Stok.Name = "TV_LABEL_Stok";
            this.TV_LABEL_Stok.Size = new System.Drawing.Size(32, 13);
            this.TV_LABEL_Stok.TabIndex = 5;
            this.TV_LABEL_Stok.Text = "Stok:";
            // 
            // TV_LABEL_Adet
            // 
            this.TV_LABEL_Adet.AutoSize = true;
            this.TV_LABEL_Adet.Location = new System.Drawing.Point(76, 225);
            this.TV_LABEL_Adet.Name = "TV_LABEL_Adet";
            this.TV_LABEL_Adet.Size = new System.Drawing.Size(32, 13);
            this.TV_LABEL_Adet.TabIndex = 6;
            this.TV_LABEL_Adet.Text = "Adet:";
            // 
            // TV_NUMERIC
            // 
            this.TV_NUMERIC.Location = new System.Drawing.Point(124, 223);
            this.TV_NUMERIC.Name = "TV_NUMERIC";
            this.TV_NUMERIC.Size = new System.Drawing.Size(45, 20);
            this.TV_NUMERIC.TabIndex = 7;
            // 
            // LAPTOP_LABLE_Fiyat
            // 
            this.LAPTOP_LABLE_Fiyat.AutoSize = true;
            this.LAPTOP_LABLE_Fiyat.Location = new System.Drawing.Point(419, 172);
            this.LAPTOP_LABLE_Fiyat.Name = "LAPTOP_LABLE_Fiyat";
            this.LAPTOP_LABLE_Fiyat.Size = new System.Drawing.Size(32, 13);
            this.LAPTOP_LABLE_Fiyat.TabIndex = 8;
            this.LAPTOP_LABLE_Fiyat.Text = "Fiyat:";
            // 
            // LAPTOP_LABLE_Stok
            // 
            this.LAPTOP_LABLE_Stok.AutoSize = true;
            this.LAPTOP_LABLE_Stok.Location = new System.Drawing.Point(419, 198);
            this.LAPTOP_LABLE_Stok.Name = "LAPTOP_LABLE_Stok";
            this.LAPTOP_LABLE_Stok.Size = new System.Drawing.Size(32, 13);
            this.LAPTOP_LABLE_Stok.TabIndex = 9;
            this.LAPTOP_LABLE_Stok.Text = "Stok:";
            // 
            // LAPTOP_LABLE_Adet
            // 
            this.LAPTOP_LABLE_Adet.AutoSize = true;
            this.LAPTOP_LABLE_Adet.Location = new System.Drawing.Point(419, 225);
            this.LAPTOP_LABLE_Adet.Name = "LAPTOP_LABLE_Adet";
            this.LAPTOP_LABLE_Adet.Size = new System.Drawing.Size(32, 13);
            this.LAPTOP_LABLE_Adet.TabIndex = 10;
            this.LAPTOP_LABLE_Adet.Text = "Adet:";
            // 
            // LAPTOP_NUMERIC
            // 
            this.LAPTOP_NUMERIC.Location = new System.Drawing.Point(467, 223);
            this.LAPTOP_NUMERIC.Name = "LAPTOP_NUMERIC";
            this.LAPTOP_NUMERIC.Size = new System.Drawing.Size(45, 20);
            this.LAPTOP_NUMERIC.TabIndex = 11;
            // 
            // TELEFON_LABEL_Fiyat
            // 
            this.TELEFON_LABEL_Fiyat.AutoSize = true;
            this.TELEFON_LABEL_Fiyat.Location = new System.Drawing.Point(76, 474);
            this.TELEFON_LABEL_Fiyat.Name = "TELEFON_LABEL_Fiyat";
            this.TELEFON_LABEL_Fiyat.Size = new System.Drawing.Size(32, 13);
            this.TELEFON_LABEL_Fiyat.TabIndex = 12;
            this.TELEFON_LABEL_Fiyat.Text = "Fiyat:";
            // 
            // TELEFON_LABEL_Stok
            // 
            this.TELEFON_LABEL_Stok.AutoSize = true;
            this.TELEFON_LABEL_Stok.Location = new System.Drawing.Point(76, 500);
            this.TELEFON_LABEL_Stok.Name = "TELEFON_LABEL_Stok";
            this.TELEFON_LABEL_Stok.Size = new System.Drawing.Size(32, 13);
            this.TELEFON_LABEL_Stok.TabIndex = 13;
            this.TELEFON_LABEL_Stok.Text = "Stok:";
            // 
            // TELEFON_LABEL_Adet
            // 
            this.TELEFON_LABEL_Adet.AutoSize = true;
            this.TELEFON_LABEL_Adet.Location = new System.Drawing.Point(76, 527);
            this.TELEFON_LABEL_Adet.Name = "TELEFON_LABEL_Adet";
            this.TELEFON_LABEL_Adet.Size = new System.Drawing.Size(32, 13);
            this.TELEFON_LABEL_Adet.TabIndex = 14;
            this.TELEFON_LABEL_Adet.Text = "Adet:";
            // 
            // TELEFON_NUMERIC
            // 
            this.TELEFON_NUMERIC.Location = new System.Drawing.Point(124, 525);
            this.TELEFON_NUMERIC.Name = "TELEFON_NUMERIC";
            this.TELEFON_NUMERIC.Size = new System.Drawing.Size(45, 20);
            this.TELEFON_NUMERIC.TabIndex = 15;
            // 
            // FRIDGE_LABLE_Fiyat
            // 
            this.FRIDGE_LABLE_Fiyat.AutoSize = true;
            this.FRIDGE_LABLE_Fiyat.Location = new System.Drawing.Point(419, 474);
            this.FRIDGE_LABLE_Fiyat.Name = "FRIDGE_LABLE_Fiyat";
            this.FRIDGE_LABLE_Fiyat.Size = new System.Drawing.Size(32, 13);
            this.FRIDGE_LABLE_Fiyat.TabIndex = 16;
            this.FRIDGE_LABLE_Fiyat.Text = "Fiyat:";
            // 
            // FRIDGE_LABLE_Stok
            // 
            this.FRIDGE_LABLE_Stok.AutoSize = true;
            this.FRIDGE_LABLE_Stok.Location = new System.Drawing.Point(419, 500);
            this.FRIDGE_LABLE_Stok.Name = "FRIDGE_LABLE_Stok";
            this.FRIDGE_LABLE_Stok.Size = new System.Drawing.Size(32, 13);
            this.FRIDGE_LABLE_Stok.TabIndex = 17;
            this.FRIDGE_LABLE_Stok.Text = "Stok:";
            // 
            // FRIDGE_LABLE_Adet
            // 
            this.FRIDGE_LABLE_Adet.AutoSize = true;
            this.FRIDGE_LABLE_Adet.Location = new System.Drawing.Point(419, 527);
            this.FRIDGE_LABLE_Adet.Name = "FRIDGE_LABLE_Adet";
            this.FRIDGE_LABLE_Adet.Size = new System.Drawing.Size(32, 13);
            this.FRIDGE_LABLE_Adet.TabIndex = 18;
            this.FRIDGE_LABLE_Adet.Text = "Adet:";
            // 
            // FRIDGE_NUMERIC
            // 
            this.FRIDGE_NUMERIC.Location = new System.Drawing.Point(467, 525);
            this.FRIDGE_NUMERIC.Name = "FRIDGE_NUMERIC";
            this.FRIDGE_NUMERIC.Size = new System.Drawing.Size(45, 20);
            this.FRIDGE_NUMERIC.TabIndex = 19;
            // 
            // BASLIK1
            // 
            this.BASLIK1.AutoSize = true;
            this.BASLIK1.Location = new System.Drawing.Point(48, 13);
            this.BASLIK1.Name = "BASLIK1";
            this.BASLIK1.Size = new System.Drawing.Size(137, 13);
            this.BASLIK1.TabIndex = 20;
            this.BASLIK1.Text = "Ürünlere Ait KDV\'siz Fiyatlar";
            // 
            // BASLIK2
            // 
            this.BASLIK2.AutoSize = true;
            this.BASLIK2.Location = new System.Drawing.Point(671, 13);
            this.BASLIK2.Name = "BASLIK2";
            this.BASLIK2.Size = new System.Drawing.Size(65, 13);
            this.BASLIK2.TabIndex = 21;
            this.BASLIK2.Text = "Sipariş Özeti";
            // 
            // SIPARIS_ADET
            // 
            this.SIPARIS_ADET.AutoSize = true;
            this.SIPARIS_ADET.Location = new System.Drawing.Point(671, 45);
            this.SIPARIS_ADET.Name = "SIPARIS_ADET";
            this.SIPARIS_ADET.Size = new System.Drawing.Size(32, 13);
            this.SIPARIS_ADET.TabIndex = 22;
            this.SIPARIS_ADET.Text = "Adet:";
            // 
            // SIPARIS_URUN
            // 
            this.SIPARIS_URUN.AutoSize = true;
            this.SIPARIS_URUN.Location = new System.Drawing.Point(757, 45);
            this.SIPARIS_URUN.Name = "SIPARIS_URUN";
            this.SIPARIS_URUN.Size = new System.Drawing.Size(30, 13);
            this.SIPARIS_URUN.TabIndex = 23;
            this.SIPARIS_URUN.Text = "Ürün";
            // 
            // SIPARIS_KDV_FIYAT
            // 
            this.SIPARIS_KDV_FIYAT.AutoSize = true;
            this.SIPARIS_KDV_FIYAT.Location = new System.Drawing.Point(845, 45);
            this.SIPARIS_KDV_FIYAT.Name = "SIPARIS_KDV_FIYAT";
            this.SIPARIS_KDV_FIYAT.Size = new System.Drawing.Size(60, 13);
            this.SIPARIS_KDV_FIYAT.TabIndex = 24;
            this.SIPARIS_KDV_FIYAT.Text = "KDV\'li Fiyat";
            // 
            // START_BUTTON
            // 
            this.START_BUTTON.Location = new System.Drawing.Point(79, 577);
            this.START_BUTTON.Name = "START_BUTTON";
            this.START_BUTTON.Size = new System.Drawing.Size(137, 23);
            this.START_BUTTON.TabIndex = 25;
            this.START_BUTTON.Text = "Ürünleri Spete Ekle";
            this.START_BUTTON.UseVisualStyleBackColor = true;
            this.START_BUTTON.Click += new System.EventHandler(this.START_BUTTON_Click);
            // 
            // RESET_BUTTON
            // 
            this.RESET_BUTTON.Location = new System.Drawing.Point(422, 577);
            this.RESET_BUTTON.Name = "RESET_BUTTON";
            this.RESET_BUTTON.Size = new System.Drawing.Size(111, 23);
            this.RESET_BUTTON.TabIndex = 26;
            this.RESET_BUTTON.Text = "Sepeti Temizle";
            this.RESET_BUTTON.UseVisualStyleBackColor = true;
            this.RESET_BUTTON.Click += new System.EventHandler(this.RESET_BUTTON_Click);
            // 
            // SIPARIS_ADET_TEXT
            // 
            this.SIPARIS_ADET_TEXT.Location = new System.Drawing.Point(674, 74);
            this.SIPARIS_ADET_TEXT.Name = "SIPARIS_ADET_TEXT";
            this.SIPARIS_ADET_TEXT.Size = new System.Drawing.Size(36, 220);
            this.SIPARIS_ADET_TEXT.TabIndex = 27;
            this.SIPARIS_ADET_TEXT.Text = "";
            // 
            // SIPARIS_URUN_TEXT
            // 
            this.SIPARIS_URUN_TEXT.Location = new System.Drawing.Point(731, 74);
            this.SIPARIS_URUN_TEXT.Name = "SIPARIS_URUN_TEXT";
            this.SIPARIS_URUN_TEXT.Size = new System.Drawing.Size(85, 220);
            this.SIPARIS_URUN_TEXT.TabIndex = 28;
            this.SIPARIS_URUN_TEXT.Text = "";
            // 
            // SIPARIS_FIYAT_TEXT
            // 
            this.SIPARIS_FIYAT_TEXT.Location = new System.Drawing.Point(837, 74);
            this.SIPARIS_FIYAT_TEXT.Name = "SIPARIS_FIYAT_TEXT";
            this.SIPARIS_FIYAT_TEXT.Size = new System.Drawing.Size(78, 220);
            this.SIPARIS_FIYAT_TEXT.TabIndex = 29;
            this.SIPARIS_FIYAT_TEXT.Text = "";
            // 
            // SONUC_LABLE
            // 
            this.SONUC_LABLE.AutoSize = true;
            this.SONUC_LABLE.Location = new System.Drawing.Point(671, 394);
            this.SONUC_LABLE.Name = "SONUC_LABLE";
            this.SONUC_LABLE.Size = new System.Drawing.Size(101, 13);
            this.SONUC_LABLE.TabIndex = 30;
            this.SONUC_LABLE.Text = "KDV\'li Toplam Fiyat:";
            // 
            // FIYAT_SONUC
            // 
            this.FIYAT_SONUC.AutoSize = true;
            this.FIYAT_SONUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FIYAT_SONUC.Location = new System.Drawing.Point(790, 383);
            this.FIYAT_SONUC.Name = "FIYAT_SONUC";
            this.FIYAT_SONUC.Size = new System.Drawing.Size(51, 24);
            this.FIYAT_SONUC.TabIndex = 31;
            this.FIYAT_SONUC.Text = "0 TL";
            // 
            // TV_FIYAT_GOSTERGE
            // 
            this.TV_FIYAT_GOSTERGE.AutoSize = true;
            this.TV_FIYAT_GOSTERGE.Location = new System.Drawing.Point(115, 172);
            this.TV_FIYAT_GOSTERGE.Name = "TV_FIYAT_GOSTERGE";
            this.TV_FIYAT_GOSTERGE.Size = new System.Drawing.Size(13, 13);
            this.TV_FIYAT_GOSTERGE.TabIndex = 32;
            this.TV_FIYAT_GOSTERGE.Text = "0";
            // 
            // TV_STOK_GOSTERGE
            // 
            this.TV_STOK_GOSTERGE.AutoSize = true;
            this.TV_STOK_GOSTERGE.Location = new System.Drawing.Point(115, 198);
            this.TV_STOK_GOSTERGE.Name = "TV_STOK_GOSTERGE";
            this.TV_STOK_GOSTERGE.Size = new System.Drawing.Size(22, 13);
            this.TV_STOK_GOSTERGE.TabIndex = 33;
            this.TV_STOK_GOSTERGE.Text = "XD";
            // 
            // BUZDOLABI_FIYAT_GOSTERGE
            // 
            this.BUZDOLABI_FIYAT_GOSTERGE.AutoSize = true;
            this.BUZDOLABI_FIYAT_GOSTERGE.Location = new System.Drawing.Point(467, 474);
            this.BUZDOLABI_FIYAT_GOSTERGE.Name = "BUZDOLABI_FIYAT_GOSTERGE";
            this.BUZDOLABI_FIYAT_GOSTERGE.Size = new System.Drawing.Size(13, 13);
            this.BUZDOLABI_FIYAT_GOSTERGE.TabIndex = 34;
            this.BUZDOLABI_FIYAT_GOSTERGE.Text = "0";
            // 
            // BUZDOLABI_STOK_GOSTERGE
            // 
            this.BUZDOLABI_STOK_GOSTERGE.AutoSize = true;
            this.BUZDOLABI_STOK_GOSTERGE.Location = new System.Drawing.Point(467, 500);
            this.BUZDOLABI_STOK_GOSTERGE.Name = "BUZDOLABI_STOK_GOSTERGE";
            this.BUZDOLABI_STOK_GOSTERGE.Size = new System.Drawing.Size(13, 13);
            this.BUZDOLABI_STOK_GOSTERGE.TabIndex = 35;
            this.BUZDOLABI_STOK_GOSTERGE.Text = "0";
            // 
            // TELEFON_FIYAT_GOSTERGE
            // 
            this.TELEFON_FIYAT_GOSTERGE.AutoSize = true;
            this.TELEFON_FIYAT_GOSTERGE.Location = new System.Drawing.Point(118, 474);
            this.TELEFON_FIYAT_GOSTERGE.Name = "TELEFON_FIYAT_GOSTERGE";
            this.TELEFON_FIYAT_GOSTERGE.Size = new System.Drawing.Size(13, 13);
            this.TELEFON_FIYAT_GOSTERGE.TabIndex = 36;
            this.TELEFON_FIYAT_GOSTERGE.Text = "0";
            // 
            // TELEFON_STOK_GOSTERGE
            // 
            this.TELEFON_STOK_GOSTERGE.AutoSize = true;
            this.TELEFON_STOK_GOSTERGE.Location = new System.Drawing.Point(118, 500);
            this.TELEFON_STOK_GOSTERGE.Name = "TELEFON_STOK_GOSTERGE";
            this.TELEFON_STOK_GOSTERGE.Size = new System.Drawing.Size(13, 13);
            this.TELEFON_STOK_GOSTERGE.TabIndex = 37;
            this.TELEFON_STOK_GOSTERGE.Text = "0";
            // 
            // LAPTOP_FIYAT_GOSTERGE
            // 
            this.LAPTOP_FIYAT_GOSTERGE.AutoSize = true;
            this.LAPTOP_FIYAT_GOSTERGE.Location = new System.Drawing.Point(458, 172);
            this.LAPTOP_FIYAT_GOSTERGE.Name = "LAPTOP_FIYAT_GOSTERGE";
            this.LAPTOP_FIYAT_GOSTERGE.Size = new System.Drawing.Size(13, 13);
            this.LAPTOP_FIYAT_GOSTERGE.TabIndex = 38;
            this.LAPTOP_FIYAT_GOSTERGE.Text = "0";
            // 
            // LAPTOP_STOK_GOSTERGE
            // 
            this.LAPTOP_STOK_GOSTERGE.AutoSize = true;
            this.LAPTOP_STOK_GOSTERGE.Location = new System.Drawing.Point(458, 198);
            this.LAPTOP_STOK_GOSTERGE.Name = "LAPTOP_STOK_GOSTERGE";
            this.LAPTOP_STOK_GOSTERGE.Size = new System.Drawing.Size(13, 13);
            this.LAPTOP_STOK_GOSTERGE.TabIndex = 39;
            this.LAPTOP_STOK_GOSTERGE.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 646);
            this.Controls.Add(this.LAPTOP_STOK_GOSTERGE);
            this.Controls.Add(this.LAPTOP_FIYAT_GOSTERGE);
            this.Controls.Add(this.TELEFON_STOK_GOSTERGE);
            this.Controls.Add(this.TELEFON_FIYAT_GOSTERGE);
            this.Controls.Add(this.BUZDOLABI_STOK_GOSTERGE);
            this.Controls.Add(this.BUZDOLABI_FIYAT_GOSTERGE);
            this.Controls.Add(this.TV_STOK_GOSTERGE);
            this.Controls.Add(this.TV_FIYAT_GOSTERGE);
            this.Controls.Add(this.FIYAT_SONUC);
            this.Controls.Add(this.SONUC_LABLE);
            this.Controls.Add(this.SIPARIS_FIYAT_TEXT);
            this.Controls.Add(this.SIPARIS_URUN_TEXT);
            this.Controls.Add(this.SIPARIS_ADET_TEXT);
            this.Controls.Add(this.RESET_BUTTON);
            this.Controls.Add(this.START_BUTTON);
            this.Controls.Add(this.SIPARIS_KDV_FIYAT);
            this.Controls.Add(this.SIPARIS_URUN);
            this.Controls.Add(this.SIPARIS_ADET);
            this.Controls.Add(this.BASLIK2);
            this.Controls.Add(this.BASLIK1);
            this.Controls.Add(this.FRIDGE_NUMERIC);
            this.Controls.Add(this.FRIDGE_LABLE_Adet);
            this.Controls.Add(this.FRIDGE_LABLE_Stok);
            this.Controls.Add(this.FRIDGE_LABLE_Fiyat);
            this.Controls.Add(this.TELEFON_NUMERIC);
            this.Controls.Add(this.TELEFON_LABEL_Adet);
            this.Controls.Add(this.TELEFON_LABEL_Stok);
            this.Controls.Add(this.TELEFON_LABEL_Fiyat);
            this.Controls.Add(this.LAPTOP_NUMERIC);
            this.Controls.Add(this.LAPTOP_LABLE_Adet);
            this.Controls.Add(this.LAPTOP_LABLE_Stok);
            this.Controls.Add(this.LAPTOP_LABLE_Fiyat);
            this.Controls.Add(this.TV_NUMERIC);
            this.Controls.Add(this.TV_LABEL_Adet);
            this.Controls.Add(this.TV_LABEL_Stok);
            this.Controls.Add(this.TV_LABEL_Fiyat);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV_NUMERIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LAPTOP_NUMERIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TELEFON_NUMERIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRIDGE_NUMERIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label TV_LABEL_Fiyat;
        private System.Windows.Forms.Label TV_LABEL_Stok;
        private System.Windows.Forms.Label TV_LABEL_Adet;
        private System.Windows.Forms.NumericUpDown TV_NUMERIC;
        private System.Windows.Forms.Label LAPTOP_LABLE_Fiyat;
        private System.Windows.Forms.Label LAPTOP_LABLE_Stok;
        private System.Windows.Forms.Label LAPTOP_LABLE_Adet;
        private System.Windows.Forms.NumericUpDown LAPTOP_NUMERIC;
        private System.Windows.Forms.Label TELEFON_LABEL_Fiyat;
        private System.Windows.Forms.Label TELEFON_LABEL_Stok;
        private System.Windows.Forms.Label TELEFON_LABEL_Adet;
        private System.Windows.Forms.NumericUpDown TELEFON_NUMERIC;
        private System.Windows.Forms.Label FRIDGE_LABLE_Fiyat;
        private System.Windows.Forms.Label FRIDGE_LABLE_Stok;
        private System.Windows.Forms.Label FRIDGE_LABLE_Adet;
        private System.Windows.Forms.NumericUpDown FRIDGE_NUMERIC;
        private System.Windows.Forms.Label BASLIK1;
        private System.Windows.Forms.Label BASLIK2;
        private System.Windows.Forms.Label SIPARIS_ADET;
        private System.Windows.Forms.Label SIPARIS_URUN;
        private System.Windows.Forms.Label SIPARIS_KDV_FIYAT;
        private System.Windows.Forms.Button START_BUTTON;
        private System.Windows.Forms.Button RESET_BUTTON;
        private System.Windows.Forms.RichTextBox SIPARIS_ADET_TEXT;
        private System.Windows.Forms.RichTextBox SIPARIS_URUN_TEXT;
        private System.Windows.Forms.RichTextBox SIPARIS_FIYAT_TEXT;
        private System.Windows.Forms.Label SONUC_LABLE;
        private System.Windows.Forms.Label FIYAT_SONUC;
        private System.Windows.Forms.Label TV_FIYAT_GOSTERGE;
        private System.Windows.Forms.Label TV_STOK_GOSTERGE;
        private System.Windows.Forms.Label BUZDOLABI_FIYAT_GOSTERGE;
        private System.Windows.Forms.Label BUZDOLABI_STOK_GOSTERGE;
        private System.Windows.Forms.Label TELEFON_FIYAT_GOSTERGE;
        private System.Windows.Forms.Label TELEFON_STOK_GOSTERGE;
        private System.Windows.Forms.Label LAPTOP_FIYAT_GOSTERGE;
        private System.Windows.Forms.Label LAPTOP_STOK_GOSTERGE;
    }
}

