using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Abstract
{
    internal interface IHizmetPersoneli:IInsan,ICalisan
    {
        void GoreviniYerineGetir();//Aşçı,GuvenlikGorevlisi
    }
}
