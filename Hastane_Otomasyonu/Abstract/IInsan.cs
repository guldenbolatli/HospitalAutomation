using Hastane_Otomasyonu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Abstract
{
    public interface IInsan //Hastaneden hasta ve çalışan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public int Yas { get; set; }
        Cinsiyet Cinsiyet { get; set; }
    }
}
