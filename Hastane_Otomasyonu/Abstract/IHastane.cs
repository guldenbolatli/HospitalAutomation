using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Abstract
{
    public interface IHastane
    {
        string HastaneAdi { get; set; }
        int GunlukHastaSayisi { get; set; }
        int CalisanSayisi { get; set; }
        int YatakliServisSayisi { get; set; }
        List<IDoktor> Doktorlar { get; set; }
    }
}
