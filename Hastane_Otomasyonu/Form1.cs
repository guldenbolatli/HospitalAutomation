using Hastane_Otomasyonu.Concreate;
using Hastane_Otomasyonu.Enum;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hastane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public static Hastane hastane;//Eklenen hastalarin 
        public Form1()
        {
            InitializeComponent();
            hastane = new Hastane()
            {
                HastaneAdi = "BilgeAdam",
                CalisanSayisi = 5000,
                GunlukHastaSayisi = 10000,
                YatakliServisSayisi = 150
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbList.View = View.Details; //bu da bir enum
            lstbList.GridLines = true;
            lstbList.Columns.Add("Ad", 100);
            lstbList.Columns.Add("Soyad", 100);
            lstbList.Columns.Add("TC No", 100);
            lstbList.Columns.Add("Maas", 100);
            lstbList.Columns.Add("Yas", 100);
            lstbList.Columns.Add("Cinsiyet", 100);
            lstbList.Columns.Add("Gunluk Hasta Sayisi", 120);
            lstbList.Columns.Add("Unvan", 100);
            lstbList.Columns.Add("Aylik Nobet Sayisi", 120);
            lstbList.Columns.Add("Uzmanlik Alani", 100);
            lstbList.Columns.Add("Doner Sermaye Parasi", 130);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            OrtopediDoktor ortopediDoktor = new OrtopediDoktor()
            {
                Ad = "Faruk",
                Soyad = "Akpinar",
                Maas = 30000,
                Yas = 36,
                GunlukHastaSayisi = 30,
                Cinsiyet = Cinsiyet.Erkek,
                Unvan = "Prof",
                AylikNobetSayisi = 2,
                UzmanlikAlani = "Ortopedi",
                DonerSermayeParasi = 26000,
                TC = "12345678910"
            };
            OrtopediDoktor ortopediDoktor2 = new OrtopediDoktor()
            {
                Ad = "Tuba",
                Soyad = "Zorlu",
                Maas = 45000,
                Yas = 45,
                GunlukHastaSayisi = 20,
                Cinsiyet = Cinsiyet.Kadin,
                Unvan = "Ordinaryus Prof",
                AylikNobetSayisi = 1,
                UzmanlikAlani = "Ortopedi",
                DonerSermayeParasi = 26000,
                TC = "12345123450"
            };
            OrtopediDoktor ortopediDoktor3 = new OrtopediDoktor()
            {
                Ad = "Ayşe",
                Soyad = "Ölmez",
                Maas = 28000,
                Yas = 29,
                GunlukHastaSayisi = 35,
                Cinsiyet = Cinsiyet.Kadin,
                Unvan = "Docent",
                AylikNobetSayisi = 6,
                UzmanlikAlani = "Ortopedi",
                DonerSermayeParasi = 20000,
                TC = "12345987654"
            };
            //3.Ortopedi doktorunu bir dosyaya kaydedeceğiz.
            FileStream fs = new FileStream("temp.txt", FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(fs, ortopediDoktor3);
            fs.Close();

            FileStream _fs = new FileStream("temp.txt", FileMode.Open);
            BinaryFormatter _binary = new BinaryFormatter();
            OrtopediDoktor v = (OrtopediDoktor)_binary.Deserialize(_fs);
            MessageBox.Show($"TC No = {v.TC}, Baktigi hasta sayisi= {v.GunlukHastaSayisi}");
            _fs.Close();

            hastane.Doktorlar.Add(ortopediDoktor);
            hastane.Doktorlar.Add(ortopediDoktor2);
            hastane.Doktorlar.Add(ortopediDoktor3);
            //hastane nesnesinin icindeki doktorlar listesini sırasıyla ekrana basacağız
            foreach (var item in hastane.Doktorlar)
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
                lstbList.Items.Add(lstitem);
            }
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle = new DoktorEkle();
            doktorEkle.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele listele = new Listele();
            listele.Show();
        }
    }
}