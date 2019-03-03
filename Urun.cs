using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3Av1
{
    class Urun
    {
        public static Hashtable kelimeTablosu= new Hashtable();
        private string marka;
        private string model;
        private int miktar;
        private double maliyet;
        private double satisFiyati;
        private string urunAciklamasi;
        private List<string> yorumlar;

        // Ürün nesnesi oluşturan parametreli constructor. Ayrıca ürün nesnesi oluşturulduğunda ürün açıklamasında geçen kelimeleri
        // kelimetablosu Hashtable ına ürün referansıyla birlikte ekler ve daha sonra ulaşmamıza yardımcı olur.
        public Urun (string mar ,string mod , int mik , double mal , double sat , string ack )
        {
            Marka = mar;
            Model = mod;
            Miktar = mik;
            Maliyet = mal;
            SatisFiyati = sat;
            UrunAciklamasi = ack;
            Yorumlar = new List<string>();

            string[] kelimeler = ack.Split();
            // açıklamayı bir string dizisine ekledik.
            foreach (string kelime in kelimeler)
                // açıklamadaki kelimeleri tek tek dolaşan foreach.
            {
                if (kelimeTablosu[kelime]!=null)
                    // eğer kelime tablosunda string dizimizdeki eleman(kelime) ye eşit key yoksa kelime tablosuna eleman ekliyor.
                    // ve alt satırda da ürünün referansını o key'e value olarak atıyor.
                {
                    ((List<Urun>)kelimeTablosu[kelime]).Add(this);
                }
                else
                {
                    // kelime tablosunda ilgili key varsa ürünün referansını ilgili key' e value olarak atıyor.
                    kelimeTablosu[kelime] = new List<Urun>();
                    ((List<Urun>)kelimeTablosu[kelime]).Add(this);
                }
            }
        }
        // otomatik oluşturulmuş getter ve setterlar.
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public double Maliyet { get => maliyet; set => maliyet = value; }
        public double SatisFiyati { get => satisFiyati; set => satisFiyati = value; }
        public string UrunAciklamasi { get => urunAciklamasi; set => urunAciklamasi = value; }
        public List<string> Yorumlar { get => yorumlar; set => yorumlar = value; }

        // Ürün nesnesinin  özelliklerini yazdırır.
        public void ozellikYazdir()
        {
            Console.WriteLine("Marka: "+ marka +"\nModel: "+model+"\nStok Adedi: "+miktar+"\nFiyat: "+satisFiyati
                + "\nAçıklama: "+urunAciklamasi + "\n");
            if (this.Yorumlar.Count!=0)
            {
                Console.WriteLine("\nÜrüne ait yorumlar: ");
                foreach (string yorum in this.Yorumlar)
                {
                    Console.WriteLine("-> " + yorum + "\n");
                }
            }
        }


    }
}
