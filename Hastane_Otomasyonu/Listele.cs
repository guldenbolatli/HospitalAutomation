using Hastane_Otomasyonu.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            lstVlist.View = View.Details; //bu da bir enum
            lstVlist.GridLines = true;
            lstVlist.Columns.Add("Ad", 100);
            lstVlist.Columns.Add("Soyad", 100);
            lstVlist.Columns.Add("TC No", 100);
            lstVlist.Columns.Add("Maas", 100);
            lstVlist.Columns.Add("Yas", 100);
            lstVlist.Columns.Add("Cinsiyet", 100);
            lstVlist.Columns.Add("Gunluk Hasta Sayisi", 120);
            lstVlist.Columns.Add("Unvan", 100);
            lstVlist.Columns.Add("Aylik Nobet Sayisi", 120);
            lstVlist.Columns.Add("Uzmanlik Alani", 100);
            lstVlist.Columns.Add("Doner Sermaye Parasi", 130);
            foreach (var item in Form1.hastane.Doktorlar)
            {
                ListViewItem lstitem = new ListViewItem();
                lstitem.Text = item.Ad; //ilk satır kısmı olustu. İlk bilgi Ad oldugu için. O satıra ait bilgiler de altına gelecek.
                lstitem.SubItems.Add(item.Soyad);
                lstitem.SubItems.Add(item.TC);
                lstitem.SubItems.Add(item.Maas.ToString());
                lstitem.SubItems.Add(item.Yas.ToString());
                lstitem.SubItems.Add(item.Cinsiyet.ToString());
                lstitem.SubItems.Add(item.GunlukHastaSayisi.ToString());
                lstitem.SubItems.Add(item.Unvan);
                lstitem.SubItems.Add(item.AylikNobetSayisi.ToString());
                lstitem.SubItems.Add(item.UzmanlikAlani);
                lstitem.SubItems.Add(item.DonerSermayeParasi.ToString());
                lstVlist.Items.Add(lstitem);
            }
        }
    }
}
