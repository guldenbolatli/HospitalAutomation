using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Abstract
{
    public interface IEkParaAl
    {
        public double DonerSermayeParasi { get; set; }
        void ParaAl();
    }
}
