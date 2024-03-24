using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    public class Fonksiyonlar
    {
        public static void Temizle(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedItem = -1;//ne erkek ne kadın seçili olmasın diye -1 e çektik.
                else if (item is GroupBox)
                {
                    GroupBox g = (GroupBox)item;
                    foreach (Control item2 in g.Controls)
                    {
                        if(item2 is RadioButton)
                        {
                            ((RadioButton)item2).Checked = default;
                        }
                    }
                }

            }
        }
    }
}
