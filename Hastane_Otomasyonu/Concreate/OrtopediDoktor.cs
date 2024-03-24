using Hastane_Otomasyonu.Abstract;
using Hastane_Otomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Concreate
{
    [Serializable]
    public class OrtopediDoktor : IDoktor
    {
        public int GunlukHastaSayisi { get; set; }
        public int AylikNobetSayisi { get; set; }
        public string UzmanlikAlani { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string Unvan { get; set; }
        private Birim _birim;
        public Birim Birim
        {
            get { return _birim; }
            set { 
                if (value != Birim.Ortopedi)
                { _birim = Birim.Ortopedi; }
                else _birim =value;
                }
        }
        public double DonerSermayeParasi { get; set; }
        private double _maas;
        public double Maas { 
            get { return _maas; } 
            set
            {
                _maas= value < 20000 ? 25000 : value;
            }
                }
        public void AmeliyatYap()
        {
            MessageBox.Show("Kırık cıkık ameliyetı yapar, gerekirse platin takar.");
        }

        public void MuayeneEt()
        {
            DialogResult dialogResult = MessageBox.Show("Rontgen çektirdiniz mi?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Rontgen sonucunu inceleyip muayene edeceğim");
            }
            else
                MessageBox.Show("Röntgen çektirin, ondan sonra gelin");
        }

        public void ParaAl() //IEkParaAl dan geliyor.
        {
            MessageBox.Show($"Doner sermayeden alinan para {DonerSermayeParasi},Toplam Kazanc = {_maas + DonerSermayeParasi}");
        }
    }
}
