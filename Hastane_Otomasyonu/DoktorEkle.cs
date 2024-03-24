using Hastane_Otomasyonu.Concreate;
using Hastane_Otomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(System.Enum.GetNames(typeof(Cinsiyet)));
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            if (rdbOrtopedi.Checked)
            {
                OrtopediDoktor eklenecekDoktor = new OrtopediDoktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToDouble(txtMaas.Text),
                    TC = txtTC.Text,
                    AylikNobetSayisi = Convert.ToInt16(txtAylikNobet.Text),
                    DonerSermayeParasi = Convert.ToDouble(txtDonerSermaye.Text),
                    Birim = Birim.Ortopedi,
                    GunlukHastaSayisi = Convert.ToInt16(txtGunlukHasta.Text),
                    Unvan = txtUnvan.Text,
                    UzmanlikAlani = txtUzmanlik.Text,
                    Yas = Convert.ToInt16(txtYas.Text)
                };
                eklenecekDoktor.Cinsiyet = cmbCinsiyet.SelectedItem.ToString() == "Erkek" ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                Form1.hastane.Doktorlar.Add(eklenecekDoktor);
            }
            else if(rdbPsikiyatri.Checked)
            {
                PsikiyatriDoktor eklenecekDoktor = new PsikiyatriDoktor()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Maas = Convert.ToDouble(txtMaas.Text),
                    TC = txtTC.Text,
                    AylikNobetSayisi = Convert.ToInt16(txtAylikNobet.Text),
                    DonerSermayeParasi = Convert.ToDouble(txtDonerSermaye.Text),
                    Birim = Birim.Psikiyatri,
                    GunlukHastaSayisi = Convert.ToInt16(txtGunlukHasta.Text),
                    Unvan = txtUnvan.Text,
                    UzmanlikAlani = txtUzmanlik.Text,
                    Yas = Convert.ToInt16(txtYas.Text)
                };
                eklenecekDoktor.Cinsiyet = cmbCinsiyet.SelectedItem.ToString() == "Erkek" ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                Form1.hastane.Doktorlar.Add(eklenecekDoktor);
            }
            Fonksiyonlar.Temizle(this); //Doktor ekle formunu temizliyoruz.
        }
    }
}
