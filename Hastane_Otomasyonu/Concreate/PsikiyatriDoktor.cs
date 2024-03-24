using Hastane_Otomasyonu.Abstract;
using Hastane_Otomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Concreate
{
    public class PsikiyatriDoktor : IDoktor
    {
        public int GunlukHastaSayisi { get ; set; }
        public int AylikNobetSayisi { get; set; }
        public string UzmanlikAlani { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        private double _maas;
        public double Maas { get { return _maas; } 
            set { 
                if(value <20000)
                {
                    _maas = 23000;
                }
                else _maas = value;
            } 
        }
        public string Unvan { get; set; }
        private Birim _birim;
        public Birim Birim
        {
            get { return _birim; }
            set { 
                if (value != Birim.Psikiyatri)
                {
                    _birim = Birim.Psikiyatri;
                }
                else _birim = value;
                }
        }
        public double DonerSermayeParasi { get; set; }

        public void AmeliyatYap()
        {
            MessageBox.Show("Ben ameliyat yapmam.");
        }

        public void MuayeneEt()
        {
            MessageBox.Show("Benim işim sen anlatırsın ben dinlerim.");
        }

        public void ParaAl()
        {
            MessageBox.Show($"Doner sermayeden alınan para: {DonerSermayeParasi}, Toplam Kazanç : {_maas+DonerSermayeParasi*1.1}");
        }
    }
}
