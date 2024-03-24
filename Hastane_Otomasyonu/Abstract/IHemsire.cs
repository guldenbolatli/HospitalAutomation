using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Abstract
{
    public interface IHemsire:IInsan,ICalisan,IEkParaAl
    {
        void HastadanKalAl();
        void HastayaSerumTak();
        void IgneVur();
        void PansumanYap();
        int AylikNobetSayisi { get; set; }
    }
}
