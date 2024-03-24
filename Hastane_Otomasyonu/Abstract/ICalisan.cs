using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Abstract
{
    public interface ICalisan
    {
        public double Maas { get; set; }
        public string Unvan { get; set; }
        Birim Birim { get; set; }
    }
}
