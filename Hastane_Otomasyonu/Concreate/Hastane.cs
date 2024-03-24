using Hastane_Otomasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Concreate
{
    //Abstract ı şablon olarak kullandık.
    //Concreate de somutlaştırma yapacağız.
    public class Hastane : IHastane
    {
        public Hastane()
        {
            Doktorlar = new List<IDoktor> (); //Hastane olustugunda doktorların nesnesini olusturuyor
        }
        public string HastaneAdi { get ; set; }
        public int GunlukHastaSayisi { get; set; }
        public int CalisanSayisi { get; set; }
        public int YatakliServisSayisi { get; set; }
        public List<IDoktor> Doktorlar { get; set; } //Hemsireler de var ama orneğimiz sadece doktorlar uzerinden yuruyecek
    }
}
