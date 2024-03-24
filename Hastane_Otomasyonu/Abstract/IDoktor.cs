using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Abstract
{
    public interface IDoktor:IInsan,ICalisan,IEkParaAl
    {
        void AmeliyatYap();
        void MuayeneEt();
        int GunlukHastaSayisi { get; set; }
        int AylikNobetSayisi { get; set; }
        string UzmanlikAlani { get; set; }
    }
}
