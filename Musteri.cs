using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3Av1
{
    class Musteri
    {
        private string adSoyad;
        private int yas;
        private double maas;
        private string cinsiyet;
        private string medeniDurum;
        private string meslek;
        private string sehir;
        private Sepet sepet;
        private List<Urun> satinAlinanlar;

        public Musteri()
        {
            // müşteri nesnesi oluşturan parametresiz konstructor.
            AdSoyad = "";
            Yas = 0;
            Maas = 0;
            Cinsiyet = "";
            MedeniDurum = "";
            Meslek = "";
            Sehir = "";
            Sepet = new Sepet();
            SatinAlinanlar = new List<Urun>();
        }

        public Musteri (string adSoyad, int yas,double maas,string cinsiyet,string medeniDurum,string meslek,string sehir)
        {
            // müşteri nesnesi oluşturan parametreli konstructor aldığı parametreleri class değişkenlerine atar.
            this.AdSoyad = adSoyad;
            this.Yas = yas;
            this.Maas = maas;
            this.Cinsiyet = cinsiyet;
            this.MedeniDurum = medeniDurum;
            this.Meslek = meslek;
            this.Sehir = sehir;
            this.Sepet = new Sepet();
            SatinAlinanlar = new List<Urun>();
        }

        public double kNN(Musteri diger)
        {
            // etkin müşteri ve parametre olarak verilen diğer müşteriyi kNN e göre karşılaştırarak birbirine uzaklığını belirler.
            // geriye döndürdüğü değer ne kadar az ise karşılaştıran müşteriler birbirine o kadar yakın olur .
            double donut = 0;
            int benzerlikDiger = 0;
            // uzaklığı hesaplarken iki müşteri arasındaki yaş farkının maksimum 60 civarında olacağını düşündük ve 
            // tüm özelliklerin etkisi buna eşitlemeye çalıştık.
            donut += Math.Abs(this.Yas-diger.Yas);
            donut += (Math.Pow(Math.Abs(this.Maas - diger.Maas), (1 / 3)))*2;
            // maaş farkı en fazla 20000 olucağını kabul ettik bunun küpkökünü alıp 2 ile çarparsak 60 civarı etki eder
            // yani maksimum maaş farkında aradaki kNN e 60 etki etmiş olur(yaş etkisiyle aynı).
            if (this.Cinsiyet!=diger.Cinsiyet)
            {
                benzerlikDiger++; 
                // cinsiyet farklı ise 60 etki eder.
            }
            if (this.MedeniDurum!=diger.MedeniDurum)
            {
                benzerlikDiger++; 
                // medeni durum farklı ise 60 etki eder.
            }
            if (this.Meslek!=diger.Meslek)
            {
                benzerlikDiger++; 
                // meslek farklı ise 60 etki eder.
            }
            if (this.Sehir!=diger.Sehir)
            {
                benzerlikDiger++;
                // şehir farklı ise 60 etki eder.
            }
            donut += benzerlikDiger *60;
            return donut;
            // toplam uzaklığı döndürür. donut ne kadar küçük ise karşılaştırılanlar o kadar benzerdir.
        }

        // değişkenlerin getter ve setter metodları.
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public int Yas { get => yas; set => yas = value; }
        public double Maas { get => maas; set => maas = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string MedeniDurum { get => medeniDurum; set => medeniDurum = value; }
        public string Meslek { get => meslek; set => meslek = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        internal Sepet Sepet { get => sepet; set => sepet = value; }
        internal List<Urun> SatinAlinanlar { get => satinAlinanlar; set => satinAlinanlar = value; }
    }
}
