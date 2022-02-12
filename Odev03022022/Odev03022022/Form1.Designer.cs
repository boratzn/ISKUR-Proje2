
namespace Odev03022022
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPersonelSayisi = new System.Windows.Forms.TextBox();
            this.tbEnDüsükMaas = new System.Windows.Forms.TextBox();
            this.tbEnBuyukMaas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnYeniListe = new System.Windows.Forms.Button();
            this.cbxIller = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.tbSicilNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btListeOlustur = new System.Windows.Forms.Button();
            this.lbxListe = new System.Windows.Forms.ListBox();
            this.btnToplamPersonel = new System.Windows.Forms.Button();
            this.btnEnDüsükMaas = new System.Windows.Forms.Button();
            this.btnEnYuksekMaas = new System.Windows.Forms.Button();
            this.btnMaasUcYuzdenAz = new System.Windows.Forms.Button();
            this.btnGirisiYapanIlkPersonel = new System.Windows.Forms.Button();
            this.btnGirisYapilanSonPersonel = new System.Windows.Forms.Button();
            this.btnToplamMaas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lblGirisYapilanSonPersonel = new System.Windows.Forms.Label();
            this.lblGirisYapilanIlkPersonel = new System.Windows.Forms.Label();
            this.lblEnYuksekMaas = new System.Windows.Forms.Label();
            this.lblEnDusukMaas = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lbxUcYuzdenAz = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Sayısı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maaş Aralığı";
            // 
            // tbPersonelSayisi
            // 
            this.tbPersonelSayisi.Location = new System.Drawing.Point(137, 12);
            this.tbPersonelSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.tbPersonelSayisi.Name = "tbPersonelSayisi";
            this.tbPersonelSayisi.Size = new System.Drawing.Size(187, 22);
            this.tbPersonelSayisi.TabIndex = 1;
            this.tbPersonelSayisi.Text = "1";
            this.tbPersonelSayisi.Leave += new System.EventHandler(this.tbPersonelSayisi_Leave);
            // 
            // tbEnDüsükMaas
            // 
            this.tbEnDüsükMaas.Location = new System.Drawing.Point(137, 43);
            this.tbEnDüsükMaas.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnDüsükMaas.Name = "tbEnDüsükMaas";
            this.tbEnDüsükMaas.Size = new System.Drawing.Size(89, 22);
            this.tbEnDüsükMaas.TabIndex = 2;
            this.tbEnDüsükMaas.TextChanged += new System.EventHandler(this.tbEnDüsükMaas_TextChanged);
            // 
            // tbEnBuyukMaas
            // 
            this.tbEnBuyukMaas.Location = new System.Drawing.Point(236, 43);
            this.tbEnBuyukMaas.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnBuyukMaas.Name = "tbEnBuyukMaas";
            this.tbEnBuyukMaas.Size = new System.Drawing.Size(88, 22);
            this.tbEnBuyukMaas.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.btnYeniListe);
            this.groupBox1.Controls.Add(this.cbxIller);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbMaas);
            this.groupBox1.Controls.Add(this.tbAdSoyad);
            this.groupBox1.Controls.Add(this.tbSicilNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(313, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(12, 133);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(140, 28);
            this.btnPersonelEkle.TabIndex = 9;
            this.btnPersonelEkle.Text = "Personle Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnYeniListe
            // 
            this.btnYeniListe.Location = new System.Drawing.Point(160, 133);
            this.btnYeniListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniListe.Name = "btnYeniListe";
            this.btnYeniListe.Size = new System.Drawing.Size(145, 28);
            this.btnYeniListe.TabIndex = 10;
            this.btnYeniListe.Text = "Yeni Liste";
            this.btnYeniListe.UseVisualStyleBackColor = true;
            this.btnYeniListe.Click += new System.EventHandler(this.btnYeniListe_Click);
            // 
            // cbxIller
            // 
            this.cbxIller.FormattingEnabled = true;
            this.cbxIller.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cbxIller.Location = new System.Drawing.Point(117, 100);
            this.cbxIller.Margin = new System.Windows.Forms.Padding(4);
            this.cbxIller.Name = "cbxIller";
            this.cbxIller.Size = new System.Drawing.Size(187, 24);
            this.cbxIller.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "İl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maaş";
            // 
            // tbMaas
            // 
            this.tbMaas.Location = new System.Drawing.Point(117, 71);
            this.tbMaas.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(187, 22);
            this.tbMaas.TabIndex = 7;
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(117, 44);
            this.tbAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(187, 22);
            this.tbAdSoyad.TabIndex = 6;
            // 
            // tbSicilNo
            // 
            this.tbSicilNo.Location = new System.Drawing.Point(117, 16);
            this.tbSicilNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbSicilNo.Name = "tbSicilNo";
            this.tbSicilNo.Size = new System.Drawing.Size(187, 22);
            this.tbSicilNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sicil No";
            // 
            // btListeOlustur
            // 
            this.btListeOlustur.Enabled = false;
            this.btListeOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btListeOlustur.ForeColor = System.Drawing.Color.Red;
            this.btListeOlustur.Location = new System.Drawing.Point(17, 252);
            this.btListeOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btListeOlustur.Name = "btListeOlustur";
            this.btListeOlustur.Size = new System.Drawing.Size(308, 36);
            this.btListeOlustur.TabIndex = 11;
            this.btListeOlustur.Text = "Liste Oluştur";
            this.btListeOlustur.UseVisualStyleBackColor = true;
            this.btListeOlustur.Click += new System.EventHandler(this.btListeOlustur_Click);
            // 
            // lbxListe
            // 
            this.lbxListe.FormattingEnabled = true;
            this.lbxListe.ItemHeight = 16;
            this.lbxListe.Location = new System.Drawing.Point(17, 297);
            this.lbxListe.Margin = new System.Windows.Forms.Padding(4);
            this.lbxListe.Name = "lbxListe";
            this.lbxListe.Size = new System.Drawing.Size(307, 148);
            this.lbxListe.TabIndex = 20;
            // 
            // btnToplamPersonel
            // 
            this.btnToplamPersonel.Location = new System.Drawing.Point(381, 31);
            this.btnToplamPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.btnToplamPersonel.Name = "btnToplamPersonel";
            this.btnToplamPersonel.Size = new System.Drawing.Size(296, 37);
            this.btnToplamPersonel.TabIndex = 12;
            this.btnToplamPersonel.Text = "Toplam Personel Sayısı";
            this.btnToplamPersonel.UseVisualStyleBackColor = true;
            this.btnToplamPersonel.Click += new System.EventHandler(this.btnToplamPersonel_Click);
            // 
            // btnEnDüsükMaas
            // 
            this.btnEnDüsükMaas.Location = new System.Drawing.Point(381, 71);
            this.btnEnDüsükMaas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnDüsükMaas.Name = "btnEnDüsükMaas";
            this.btnEnDüsükMaas.Size = new System.Drawing.Size(296, 37);
            this.btnEnDüsükMaas.TabIndex = 13;
            this.btnEnDüsükMaas.Text = "En Düşük Maaş";
            this.btnEnDüsükMaas.UseVisualStyleBackColor = true;
            this.btnEnDüsükMaas.Click += new System.EventHandler(this.btnEnDüsükMaas_Click);
            // 
            // btnEnYuksekMaas
            // 
            this.btnEnYuksekMaas.Location = new System.Drawing.Point(381, 112);
            this.btnEnYuksekMaas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnYuksekMaas.Name = "btnEnYuksekMaas";
            this.btnEnYuksekMaas.Size = new System.Drawing.Size(296, 37);
            this.btnEnYuksekMaas.TabIndex = 14;
            this.btnEnYuksekMaas.Text = "En Yüksek Maaş";
            this.btnEnYuksekMaas.UseVisualStyleBackColor = true;
            this.btnEnYuksekMaas.Click += new System.EventHandler(this.btnEnYuksekMaas_Click);
            // 
            // btnMaasUcYuzdenAz
            // 
            this.btnMaasUcYuzdenAz.Location = new System.Drawing.Point(381, 156);
            this.btnMaasUcYuzdenAz.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaasUcYuzdenAz.Name = "btnMaasUcYuzdenAz";
            this.btnMaasUcYuzdenAz.Size = new System.Drawing.Size(296, 37);
            this.btnMaasUcYuzdenAz.TabIndex = 15;
            this.btnMaasUcYuzdenAz.Text = "Maaşı 300 TL\'den az Personller";
            this.btnMaasUcYuzdenAz.UseVisualStyleBackColor = true;
            this.btnMaasUcYuzdenAz.Click += new System.EventHandler(this.btnMaasUcYuzdenAz_Click);
            // 
            // btnGirisiYapanIlkPersonel
            // 
            this.btnGirisiYapanIlkPersonel.Location = new System.Drawing.Point(381, 201);
            this.btnGirisiYapanIlkPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisiYapanIlkPersonel.Name = "btnGirisiYapanIlkPersonel";
            this.btnGirisiYapanIlkPersonel.Size = new System.Drawing.Size(296, 37);
            this.btnGirisiYapanIlkPersonel.TabIndex = 16;
            this.btnGirisiYapanIlkPersonel.Text = "Giriş Yapılan İlk Personel";
            this.btnGirisiYapanIlkPersonel.UseVisualStyleBackColor = true;
            this.btnGirisiYapanIlkPersonel.Click += new System.EventHandler(this.btnGirisiYapanIlkPersonel_Click);
            // 
            // btnGirisYapilanSonPersonel
            // 
            this.btnGirisYapilanSonPersonel.Location = new System.Drawing.Point(381, 245);
            this.btnGirisYapilanSonPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYapilanSonPersonel.Name = "btnGirisYapilanSonPersonel";
            this.btnGirisYapilanSonPersonel.Size = new System.Drawing.Size(296, 37);
            this.btnGirisYapilanSonPersonel.TabIndex = 17;
            this.btnGirisYapilanSonPersonel.Text = "Giriş Yapılan Son Personel";
            this.btnGirisYapilanSonPersonel.UseVisualStyleBackColor = true;
            this.btnGirisYapilanSonPersonel.Click += new System.EventHandler(this.btnGirisYapilanSonPersonel_Click);
            // 
            // btnToplamMaas
            // 
            this.btnToplamMaas.Location = new System.Drawing.Point(381, 289);
            this.btnToplamMaas.Margin = new System.Windows.Forms.Padding(4);
            this.btnToplamMaas.Name = "btnToplamMaas";
            this.btnToplamMaas.Size = new System.Drawing.Size(296, 37);
            this.btnToplamMaas.TabIndex = 18;
            this.btnToplamMaas.Text = "Toplam Ödenen Maaş";
            this.btnToplamMaas.UseVisualStyleBackColor = true;
            this.btnToplamMaas.Click += new System.EventHandler(this.btnToplamMaas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxUcYuzdenAz);
            this.groupBox2.Controls.Add(this.lblToplamMaas);
            this.groupBox2.Controls.Add(this.lblGirisYapilanSonPersonel);
            this.groupBox2.Controls.Add(this.lblGirisYapilanIlkPersonel);
            this.groupBox2.Controls.Add(this.lblEnYuksekMaas);
            this.groupBox2.Controls.Add(this.lblEnDusukMaas);
            this.groupBox2.Controls.Add(this.lblToplamPersonel);
            this.groupBox2.Location = new System.Drawing.Point(687, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(364, 356);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operasyonel Bilgiler";
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(9, 224);
            this.lblToplamMaas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(0, 17);
            this.lblToplamMaas.TabIndex = 0;
            // 
            // lblGirisYapilanSonPersonel
            // 
            this.lblGirisYapilanSonPersonel.AutoSize = true;
            this.lblGirisYapilanSonPersonel.Location = new System.Drawing.Point(9, 179);
            this.lblGirisYapilanSonPersonel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGirisYapilanSonPersonel.Name = "lblGirisYapilanSonPersonel";
            this.lblGirisYapilanSonPersonel.Size = new System.Drawing.Size(0, 17);
            this.lblGirisYapilanSonPersonel.TabIndex = 0;
            // 
            // lblGirisYapilanIlkPersonel
            // 
            this.lblGirisYapilanIlkPersonel.AutoSize = true;
            this.lblGirisYapilanIlkPersonel.Location = new System.Drawing.Point(9, 135);
            this.lblGirisYapilanIlkPersonel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGirisYapilanIlkPersonel.Name = "lblGirisYapilanIlkPersonel";
            this.lblGirisYapilanIlkPersonel.Size = new System.Drawing.Size(0, 17);
            this.lblGirisYapilanIlkPersonel.TabIndex = 0;
            // 
            // lblEnYuksekMaas
            // 
            this.lblEnYuksekMaas.AutoSize = true;
            this.lblEnYuksekMaas.Location = new System.Drawing.Point(9, 92);
            this.lblEnYuksekMaas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnYuksekMaas.Name = "lblEnYuksekMaas";
            this.lblEnYuksekMaas.Size = new System.Drawing.Size(0, 17);
            this.lblEnYuksekMaas.TabIndex = 0;
            // 
            // lblEnDusukMaas
            // 
            this.lblEnDusukMaas.AutoSize = true;
            this.lblEnDusukMaas.Location = new System.Drawing.Point(9, 52);
            this.lblEnDusukMaas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnDusukMaas.Name = "lblEnDusukMaas";
            this.lblEnDusukMaas.Size = new System.Drawing.Size(0, 17);
            this.lblEnDusukMaas.TabIndex = 0;
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.AutoSize = true;
            this.lblToplamPersonel.Location = new System.Drawing.Point(9, 25);
            this.lblToplamPersonel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(0, 17);
            this.lblToplamPersonel.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(687, 394);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(364, 51);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lbxUcYuzdenAz
            // 
            this.lbxUcYuzdenAz.FormattingEnabled = true;
            this.lbxUcYuzdenAz.ItemHeight = 16;
            this.lbxUcYuzdenAz.Location = new System.Drawing.Point(12, 258);
            this.lbxUcYuzdenAz.Name = "lbxUcYuzdenAz";
            this.lbxUcYuzdenAz.Size = new System.Drawing.Size(345, 84);
            this.lbxUcYuzdenAz.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 456);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnToplamMaas);
            this.Controls.Add(this.btnGirisYapilanSonPersonel);
            this.Controls.Add(this.btnGirisiYapanIlkPersonel);
            this.Controls.Add(this.btnMaasUcYuzdenAz);
            this.Controls.Add(this.btnEnYuksekMaas);
            this.Controls.Add(this.btnEnDüsükMaas);
            this.Controls.Add(this.btnToplamPersonel);
            this.Controls.Add(this.lbxListe);
            this.Controls.Add(this.btListeOlustur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbEnBuyukMaas);
            this.Controls.Add(this.tbEnDüsükMaas);
            this.Controls.Add(this.tbPersonelSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPersonelSayisi;
        private System.Windows.Forms.TextBox tbEnDüsükMaas;
        private System.Windows.Forms.TextBox tbEnBuyukMaas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnYeniListe;
        private System.Windows.Forms.ComboBox cbxIller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaas;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.TextBox tbSicilNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btListeOlustur;
        private System.Windows.Forms.ListBox lbxListe;
        private System.Windows.Forms.Button btnToplamPersonel;
        private System.Windows.Forms.Button btnEnDüsükMaas;
        private System.Windows.Forms.Button btnEnYuksekMaas;
        private System.Windows.Forms.Button btnMaasUcYuzdenAz;
        private System.Windows.Forms.Button btnGirisiYapanIlkPersonel;
        private System.Windows.Forms.Button btnGirisYapilanSonPersonel;
        private System.Windows.Forms.Button btnToplamMaas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lblGirisYapilanSonPersonel;
        private System.Windows.Forms.Label lblGirisYapilanIlkPersonel;
        private System.Windows.Forms.Label lblEnYuksekMaas;
        private System.Windows.Forms.Label lblEnDusukMaas;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lbxUcYuzdenAz;
    }
}

