using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev03022022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbxUcYuzdenAz.Visible = false;
        }
        int personelSayac = 0;
        int index = 0;
        int[] sicilNo;
        string[] adSoyad;
        int[] maas;
        string[] iller;
        

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int personelSayisi = Convert.ToInt32(tbPersonelSayisi.Text);
                
                if (sicilNo.Contains(Convert.ToInt32(tbSicilNo.Text)))
                {
                    MessageBox.Show("Aynı Sicil numarasına sahip başka Personel olamaz!!!! Sicil Numarasını Değiştirin.");
                }
                else if (Convert.ToInt32(tbMaas.Text) < Convert.ToInt32(tbEnDüsükMaas.Text) || Convert.ToInt32(tbMaas.Text) > Convert.ToInt32(tbEnBuyukMaas.Text))
                {
                    MessageBox.Show("Maaş Aralığının Dışında Bir değer Girdiniz!!! Lütfen Maaş Aralığına Dikkat Edin!!!");
                }
                else
                {
                    AddPersonel(Convert.ToInt32(tbSicilNo.Text), tbAdSoyad.Text, Convert.ToInt32(tbMaas.Text), cbxIller.Text, index);
                    index++;
                    personelSayac++;
                    ClearInformations();
                    if (personelSayac == personelSayisi)
                    {
                        MessageBox.Show("Belirlenen Personel Sayısına Ulaşıldı!! Bunları Listeleyebilirsiniz.");
                        btListeOlustur.Enabled = true;
                        personelSayac = 0;
                        btnPersonelEkle.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

       public void InitiliazeValues(int elemanSayisi)
        {
            sicilNo = new int[elemanSayisi];
            adSoyad = new string[elemanSayisi];
            maas = new int[elemanSayisi];
            iller = new string[elemanSayisi];
        }

        public void AddPersonel(int sicilNoo, string adSoyadd, int maass, string ill, int index)
        {
            sicilNo[index] = sicilNoo;
            adSoyad[index] = adSoyadd;
            maas[index] = maass;
            iller[index] = ill; 
        }

        private void btListeOlustur_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sicilNo.Length; i++)
            {
                lbxListe.Items.Add(sicilNo[i].ToString() + "\t" + adSoyad[i] + "\t" + maas[i].ToString() + "\t" + iller[i]);
            }
        }

        public void ClearInformations()
        {
            tbSicilNo.Clear();
            tbAdSoyad.Clear();
            tbMaas.Clear();
            cbxIller.Text = "";
            index = 0;
        }

        private void btnYeniListe_Click(object sender, EventArgs e)
        {
            Array.Clear(sicilNo,0, sicilNo.Length);
            Array.Clear(adSoyad, 0, adSoyad.Length);
            Array.Clear(maas, 0, maas.Length);
            cbxIller.Text = "";
            lbxListe.Items.Clear();
            tbPersonelSayisi.Clear();
            tbEnDüsükMaas.Clear();
            tbEnBuyukMaas.Clear();
            btListeOlustur.Enabled = false;
            tbPersonelSayisi.Enabled = true;
            btnPersonelEkle.Enabled = true;
        }

        private void tbEnDüsükMaas_TextChanged(object sender, EventArgs e)
        {
            tbPersonelSayisi.Enabled = false;
        }

        private void tbPersonelSayisi_Leave(object sender, EventArgs e)
        {
            try
            {
                InitiliazeValues(Convert.ToInt32(tbPersonelSayisi.Text));
                tbPersonelSayisi.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Personel Sayısı Alanı Boş Bırakılamaz!!");
            }
            
        }

        private void btnToplamPersonel_Click(object sender, EventArgs e)
        {
            
            lblToplamPersonel.Text = "Toplam Personel Sayısı : " + tbPersonelSayisi.Text;
            
        }

        private void btnEnDüsükMaas_Click(object sender, EventArgs e)
        {
            lblEnDusukMaas.Text = "En Düşük Maaş : " + maas.Min().ToString();
        }

        private void btnEnYuksekMaas_Click(object sender, EventArgs e)
        {
            lblEnYuksekMaas.Text = "En Yüksek Maaş : " + maas.Max().ToString();
        }

        private void btnMaasUcYuzdenAz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maas.Length; i++)
            {
                if (maas[i] < 300)
                {
                    lbxUcYuzdenAz.Items.Add(sicilNo[i].ToString() + " " + adSoyad[i] + " " + maas[i].ToString() + " " + iller[i]);
                }
            }
            if (lbxUcYuzdenAz.Items.Count == 0) lbxUcYuzdenAz.Items.Add("Maasşı 300 TL'den az olan personel bulunmamaktadır.");
            lbxUcYuzdenAz.Visible = true;
        }

        private void btnGirisiYapanIlkPersonel_Click(object sender, EventArgs e)
        {
            lblGirisYapilanIlkPersonel.Text = "İlk Personel : " + sicilNo[0].ToString() + " " + adSoyad[0] + " " + maas[0].ToString() + " " + iller[0];
        }

        private void btnGirisYapilanSonPersonel_Click(object sender, EventArgs e)
        {
            lblGirisYapilanSonPersonel.Text = "Son Personel : " + sicilNo[sicilNo.Length-1].ToString() + " " + adSoyad[adSoyad.Length-1] + " " + maas[maas.Length-1].ToString() + " " + iller[iller.Length-1];
        }

        private void btnToplamMaas_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < maas.Length; i++)
            {
                toplam += maas[i];
            }
            lblToplamMaas.Text = "Toplam Ödenen Maaş : " + toplam.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblToplamPersonel.Text = "";
            lblEnDusukMaas.Text = "";
            lblEnYuksekMaas.Text = "";
            lbxUcYuzdenAz.Items.Clear();
            lbxUcYuzdenAz.Visible = false;
            lblGirisYapilanIlkPersonel.Text = "";
            lblGirisYapilanSonPersonel.Text = "";
            lblToplamMaas.Text = "";
        }

    }
}
