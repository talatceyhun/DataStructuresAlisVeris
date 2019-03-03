using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructuresProje3Av1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***HEPSİŞURADA'YA HOŞGELDİNİZ!***");
            List<Musteri> kayıtlıMusteriler = new List<Musteri>(); 
            // programdaki kayıtlı müşterilerin tutulduğu liste.
            Musteri etkinMusteri = null;
            // programda o anda işlem yapmakta olan müşteri.
            Hashtable kategoriTablosu = new Hashtable();
            // kategori ağaçlarının tutulduğu Hashtable. 
            string[] urunBilgileri = {"Bilgisayar,Masaüstü Bilgisayar,MSI,AEGIS 3,50,5000.00,6999.00,oyun oynayanlar için benzeri olmayan performans en gelişmiş ekran kartları en iyi soğutma",
"Bilgisayar,Masaüstü Bilgisayar,HP,570-P010NT,150,1500.00,2228.00,göz alıcı ve yer tasarrufu sağlayan tasarım i5 işlemci 8 gb bellek",
"Bilgisayar,Tablet Bilgisayar,Samsung,Galaxy Tab E,500,400.00,658.99,üstün performans şık tasarım geniş ekran 8 gb hafıza",
"Bilgisayar,Tablet Bilgisayar,Apple,IPad Wi-fi,500,1000.00,1450.00,göz alıcı ekran göz alıcı tasarım 32 gb hafıza yüksek performans",
"Bilgisayar,Dizüstü Bilgisayar,Lenovo,Legion Y520,200,2900.00,3899.00,8 gb bellek yüksek performans full hd ekran gtx 1050 ekran kartı",
"Bilgisayar,Dizüstü Bilgisayar,Dell,Insprion 3567,180,1500.00,2299.99,4 gb bellek harici ekran kartı full hd ekran yüksek performans",
"Beyaz Eşya,Çamaşır Makinesi,Altus,ALM-601,350,500.00,788.00,6kg 1000 devir yüksek verimli paslanmaz gövde",
"Beyaz Eşya,Çamaşır Makinesi,Vestel,EKO 7710 CL,300,640.00,839.00,7 kg 1000 devir A+++ verimlilik",
"Beyaz Eşya,Buzdolabı,Grundig,GSND 6282,105,2500.00,3299.00,640 litre geniş kapasite no frost gümüş renk led aydınlatma",
"Beyaz Eşya,Buzdolabı,Hotpoint Ariston,ENXTM 19211,90,1200.00,1539.00,504 lt no frost A+ hijyen kontrol sistemi",
"Beyaz Eşya,Fırın,Vestel,Eko 7400P Turbo,200,550.00,710.00,turbo tipi fırın A sınıfı enerji çocuk kilidi beyaz renk iç aydınlatma lambası",
"Beyaz Eşya,Fırın,Kumtel,Ko-A6S2,400,350.00,482.00,B sınıfı enerji ısıya dayanıklı kapak güç gösterge lambası ayarlanabilir termostat",
"Yapı Market,Kapı,Nobel,Rozetli Kapı Kolu,1000,15.00,22.00,korozyona karşı dayanıklı kaplama şık tasarım sağlam gövde",
"Yapı Market,Kapı,Rem,Camlı Akordiyon Kapı,100,250.00,335.00,suya ve neme karşı dayanıklı sağlam yapı pratik tasarım",
"Yapı Market,Boya,Fawori,Premium Sentetik Yağlı Boya,2000,45.00,55.00,parlak görünüş sentetik boya tse belgesi",
"Yapı Market,Boya,Filli Boya,Parlak Yağlı Boya,1000,38.00,49.90,yüksek kalıcılık ve parlaklık akrilik reçine esaslı örtme ve yapışması mükemmel boya",
"Yapı Market,Merdiven,Erol,Teknik Merdiven,200,33.00,46.00,3 basamak sağlam gövde çizilme önleyici ambalaj",
"Yapı Market,Merdiven,Çağsan,2x6 Basamaklı Merdiven,200,250.00,295.00,6 kat 12 basamak kaymayı önleyici ayak sağlam gövde"
 };
            // programın içerisinde gelen ürünlerin tutulduğu string dizisi toplam 3 kategoride 9 alt kategori vardır 
            // ve alt kategorilerin içerisinde 18 ürün bulunuyor.
            string[] iyiVeriSeti = {"iyi","güzel","muhteşem","kalite","kaliteli","performans","mükemmel","kalitesi","artı","hızlı",
"aynı","sorunsuz","teşekkürler","teşekkür","sağlam","harika","ısınmıyor","ekstra","ucuz","uygun","şık","garanti","garantili","kusursuz",
"sessiz","güven","güvenle","tavsiye","memnun","memnunuz","mantıklı","kibar","harika","eksiksiz","zamanında","kullanışlı",
"süper","saygı","saygılı","saygılılar","sağlık","muazzam","şans","memnunum","bol","rahat","verimli"};
            // programın ekstralarında istenen yorum analizi için iyi verilerin veri seti.
            string[] kotuVeriSeti = {"ulaşmadı","ulaşamadı","kaybetti","gelmedi","alamıyorum","geçersiz","eski","kullanılmış",
"farklı","yıpranmış","geç","gecikmeli","berbat","çirkin","yurtiçi","yalan","yanlış","rezalet","yapmam","bozuk","eksik","sorun",
"sorunlu","hasarlı","kırık","parçalanmış","vermiyor","kayboldu","yavaş","kalitesiz","gürültülü","düşük","hatalı","ama","saygısız",
"ilgisiz","pis","dolandırıcı","bayat","kullanışsız"};
            // kötü verilerin veri seti.


            foreach (string bilgiler in urunBilgileri)
                // programın içerisinde hazır gelen ürünleri oluşturan metod.
            {
                urunEkle(kategoriTablosu, bilgiler);
            }
            

            anaMenu(kategoriTablosu, kayıtlıMusteriler, etkinMusteri,iyiVeriSeti,kotuVeriSeti);// programın işleyişini sağlayan metod.
            // static değişken kullanmadığımız için ihtiyacı olan tüm değişkenleri parametre olarak verdik.
            Console.ReadKey();

        }
        // kategorileri tutan hashtable da parametre olarak verilen stringin olup olmadığını kontrol eder.
        static bool kategoriVarMi (string kategori,Hashtable table)
            
        {
            return table.Contains(kategori); 
            // Hashtable ın ilgili kategoriyi içerip içermediğini geriye döndüren metod.
        }

        static void urunBilgisiAl(Hashtable table)
        {
            // personel yeni ürün eklemek istediğinde personelden ürün girişini alıcak alan metod.
            
            Console.WriteLine("Ürün kategorisini giriniz(Bilgisayar, Beyaz Eşya vb): ");
            string kategori = Console.ReadLine();
            Console.WriteLine("Ürün kategori ismini giriniz(Laptop,Çamaşır Makinesi vb): ");
            string kategoriIsmi = Console.ReadLine();
            Console.WriteLine("Ürünün markasını giriniz: ");
            string marka = Console.ReadLine();
            Console.WriteLine("Ürünün modelini giriniz: ");
            string model = Console.ReadLine();
            Console.WriteLine("Ürünün miktarını giriniz: ");
            string miktar = Console.ReadLine();
            Console.WriteLine("Ürünün maliyetini giriniz: ");
            string maliyet = Console.ReadLine();
            Console.WriteLine("Ürünün satış fiyatını giriniz: ");
           string satisFiyati = Console.ReadLine();
            Console.WriteLine("Ürünün açıklamasını giriniz: ");
            string aciklama = Console.ReadLine();
            string urunBilgileri=kategori+","+kategoriIsmi+","+marka+","+model+","+miktar+","+maliyet+","+satisFiyati+","+aciklama;

            urunEkle(table, urunBilgileri);
            // ürünü uygun yere ekler.

            
        }

        static void urunEkle (Hashtable table,string urunBilgileri) 
            // ürün bilgileri ve kategoritablosunu alarak ürünü uygun uygun konuma ekleyen metod.
        {
            string[] ozellikler = urunBilgileri.Split(','); 
            // ürün bilgilerini split ile bir diziye atadık.
            Urun eklenecek = new Urun(ozellikler[2], ozellikler[3], Int32.Parse(ozellikler[4]),
                Convert.ToDouble(ozellikler[5].Replace(".",",")),
                Convert.ToDouble(ozellikler[6].Replace(".", ",")), ozellikler[7]); 
            // eklenecek ürünü oluşturduk.
            
            string kategori = ozellikler[0];
            // ürünün kategorisi dizinin 0 indisli elemanı olur. 
            string kategoriIsmi = ozellikler[1];
            // kategori ismi 1 indisli eleman olur.
            if (kategoriVarMi(kategori, table))
                // kategori ağaçlarını tutan hashtable da ilgili kategori ağacının olup olmadığını kontrol eder.
                // var ise bu kısım çalışır ve ürün ağacın ilgili yerine eklenir.
            {
                Tree tmp = (Tree)table[kategori];
                if (tmp.IsimBul(kategoriIsmi) == null)
                {
                    tmp.YeniKategoriUrunEkle(kategoriIsmi);
                }
                tmp.IsimBul(kategoriIsmi).Urunler.Add(eklenecek);
            }
            else
            {
                // kategori hashtable da yok ise bu kısım çalışır ve önce o kategori için bir kategori ağacı oluşturulur 
                // ve o ağaç kategori ağaçlarını tutuan hashtable a eklenir ve ürün de ağacın ilgili yerine eklenir.
                Tree tmp = new Tree();
                table.Add(kategori, tmp);
                tmp.YeniKategoriUrunEkle(kategoriIsmi);
                tmp.IsimBul(kategoriIsmi).Urunler.Add(eklenecek);

            }



        }

        static ArrayList urunAra(Hashtable table)
        {
            // kategori ismine göre (laptop vb) ve ürün bilgilerine göre ürün aramamızı sağlayan metod.
            // metod geriye ürünün bulunduğu node u ve ürünü bir arraylist içerisine alarak döndürür.
            
            ArrayList donut= new ArrayList();
            Tree hedefTree;
            Console.WriteLine("Ürün kategori ismini giriniz(Laptop,Çamaşır Makinesi vb): ");
            string kategoriIsmi = Console.ReadLine();

            foreach (Tree item in table.Values)
                // kategoriTablosu hashtable ı için.
            {
                Node tmp = item.IsimBul(kategoriIsmi);
                // kategori isminin hashtable ın iteminde bulunup bulunmadığını kontrol eder.
                if (tmp!=null)
                {
                    // eğer kategori ismini içeren node item in içerisindeyse bu kısım çalışır ve kalan ürün özelliklerini isteyerek ürün arar.
                    hedefTree = item;
                    donut.Add(tmp);
                    Console.WriteLine("Ürünün markasını giriniz: ");
                    string marka = Console.ReadLine();
                    Console.WriteLine("Ürünün modelini giriniz: ");
                    string model = Console.ReadLine();

                    foreach (Urun urun in tmp.Urunler)
                    {
                        if (urun.Marka==marka && urun.Model==model)
                        {
                            donut.Add(urun);
                            break;
                        }
                    }
                        break;
                }
            }
            return donut;
            // bulduğu ürünü geriye döndürür.
            

        }

        static void urunSil(ArrayList aList)
        {
            // arraylist içerisinde bulunduğu node u ve nesnesini aldığı ürünü silen metod.
            ((Node)aList[0]).Urunler.Remove(((Urun)aList[1]));

            //silinen ürünün kelime hashtable'ından da silinmesi için
            string[] silinecekKelimeler = ((Urun)aList[1]).UrunAciklamasi.Split();
            foreach (string kelime in silinecekKelimeler)
            {
                ((List<Urun>)Urun.kelimeTablosu[kelime]).Remove((Urun)aList[1]);
                
                // hashtable'ın refere ettiği liste boşsa kelimenin hashtabledan silinmesi için
                if (((List<Urun>)Urun.kelimeTablosu[kelime]).Count==0)
                {
                    Urun.kelimeTablosu.Remove(kelime);
                }
            }
        }


        static void urunBilgisiDegistir(Hashtable table)
            // değiştirilmek istenen ürünün bilgilerini alıp üzerinde değişiklik yapmayı sağlayan metod.
        {
            Console.WriteLine("Düzenlemek istediğiniz ürünün bilgilerini giriniz: ");
            urunSil(urunAra(table)); 
            // ürün bilgilerini al.
            Console.WriteLine("Ürünün yeni bilgilerini giriniz: ");
            urunBilgisiAl(table);
            // yeni bilgileri ata.
        }

        static Musteri musteriOlustur (List<Musteri> musteri)
        {
            // sisteme yeni müşteri kaydı yapan metod
            // sırayla müşteri bilgilerini alır.
            Sepet sepet = new Sepet();
            Console.WriteLine("Kayıt olmak için lütfen istenilen bilgileri giriniz.");
            Console.WriteLine("Ad Soyad: ");
            string adSoyad = Console.ReadLine();
            Console.WriteLine("Yaş: ");
            int yas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Maaş: ");
            double maas = Double.Parse(Console.ReadLine());
            Console.WriteLine("Cinsiyet: ");
            string cinsiyet = Console.ReadLine();
            Console.WriteLine("Medeni Durum: ");
            string medeniDurum = Console.ReadLine();
            Console.WriteLine("Meslek: ");
            string meslek = Console.ReadLine();
            Console.WriteLine("Şehir");
            string sehir = Console.ReadLine();
            Musteri musteriKayit = new Musteri(adSoyad,yas,maas,cinsiyet,medeniDurum,meslek,sehir);
            // yeni müşteri oluşturur.
            musteri.Add(musteriKayit); 
            // generic list tipindeki müşteri listesine oluuşturulan müşteriyi ekler.
            return musteriKayit; 
            // etkin müşteri olarak oluşturulan müşteriyi geriye döndürür.
        }

        static Musteri oturumAc(List<Musteri> musteri)
        {
            // oturum açma bilgileri alınan müşterinin sisteme kayıtlı olup olmadığıni bulan ve müşteri oturum açında 
            // müşteriyi etkin müşteri olarak geriye döndüren metod.
            Console.WriteLine("Ad Soyad");
            string adSoyad = Console.ReadLine();
            Musteri etkinMusteri = null;

            int sayac = 0;
            bool anahtar = false;
            // anahtarla müşterinin kayıtlı olup olmadığını tutuyoruz.
            foreach (Musteri item in musteri)
            {
                if (item.AdSoyad == adSoyad)
                {
                    // müşteri kayıtlıysa bu kod bloğu çalışıyor ve anahtar true oluyor.
                    anahtar = true;
                    break;
                }
                sayac++;
            }
            if (anahtar)
                // anahtar true ise kayıtlı müşteriyi etkin olarak atıyor.
            {
                etkinMusteri = musteri[sayac];

            }
            return etkinMusteri; // etkin müşteriyi döndürüyor.
        }

        static void yorumEkle(Urun urun)
        {
            // müşterinin yaptığı yorumu .
            Console.WriteLine("Yorum giriniz: ");
            string yorum = Console.ReadLine();
            urun.Yorumlar.Add(yorum);
            // girilen yorumu ürünün yorumlarına ekler.
        }
        
        static void yorumYap(Musteri etkinMusteri)
        {
            // müşterinin satın aldığı ürünlerden seçtiği ürüne yorum eklemesini sağlar.
            Console.WriteLine("Eski alışverişlerinizden yorum yapmak istediğiniz ürünü seçiniz: ");
            int sayac = 0;
            foreach (Urun urun in etkinMusteri.SatinAlinanlar)
            {
                // seçilen ürünü satın alınanlarda arar.
                Console.Write("({0}) ",sayac++);
                urun.ozellikYazdir();
            }
            int secim = Int32.Parse(Console.ReadLine());

            yorumEkle(etkinMusteri.SatinAlinanlar[secim]); 
            //bulunan ürün nesnesinin yorumlarına ekler. 
        }

        static void yorumDegerlendirme(Urun urun,string[] iyiVeriSeti, string[] kotuVeriSeti)
        {
            // programdaki veri setlerini kullanarak girilen yorumların olumluluk yüzdesini bulan metod
            int iyiSayac = 0;
            int kotuSayac = 0;

            foreach (string item in urun.Yorumlar)
            {
                string[] yorumParca = item.Split();
                foreach (string item2 in yorumParca)
                {
                    if (iyiVeriSeti.Contains(item2))
                    {
                        // yorumda olumlu veri setinden bir kelime geçiyorsa iyisayacı arttırır.
                        iyiSayac++;
                    }
                    if (kotuVeriSeti.Contains(item2))
                    {
                        // yorumda olumsuz veri setinden bir kelime geçiyorsa kötü sayacı arttırır.
                        kotuSayac++;
                    }
                }

            }
            double yuzde = (double) iyiSayac / ((double)(iyiSayac + kotuSayac)) * 100;
            Console.WriteLine("Ürüne Ait Yorumlar:");
            foreach (string yorum in urun.Yorumlar)
            {
                Console.WriteLine(yorum );
            }
            Console.WriteLine("Ürünün yorumlarının olumluluk yüzdesi: " + yuzde);
            // olumluluk yüzdesini bulur ve ekrana yazdırır.

        }

        static void isimdenUrunAra(Hashtable table,Musteri musteri)
        {
            // kategori isminden ürün aramayı sağlayıp o kategori ismindeki ürünlerin listelenip satın alınabilmesini sağlayan metod.
            Console.WriteLine("Aramak istediğiniz kategori ismi?");
            string kategoriIsmi = Console.ReadLine();
            Node tmp = null;
            foreach (Tree item in table.Values)
            {
                tmp = item.IsimBul(kategoriIsmi);
                if (tmp != null)
                {
                    break;
                }
            }
            if (tmp == null)
            {
                // kategori ismi bulunamadıysa.
                Console.WriteLine("Kategori İsmi Bulunamadı");
            }
            else
            {
                // kategori ismi bulunduysa
                int sayac = 0;
                foreach (Urun item in tmp.Urunler)
                {
                    // ürünleri listeleyen döngü.
                    Console.Write("("+ sayac++ +") ");
                    item.ozellikYazdir();
                    
                }
                // listelenen ürünlerden sepete ürün eklemeyi sağlayan kod.
                Console.WriteLine("Sepete ürün eklemek istiyor musunuz?(e/h) :");
                string secim = Console.ReadLine();
                if (secim == "e")
                {
                    Console.WriteLine("Sepetinize eklemek istediğiniz ürünleri virgül ile ayırarak yazınız.(1,2):");
                    string[] alinanIndis = Console.ReadLine().Split(',');
                    foreach (string item in alinanIndis)
                    {
                        musteri.Sepet.UrunlerSepet.Add(tmp.Urunler[Int32.Parse(item)]);
                    }
                    satinAl(musteri);
                    // satınal metodunu çağırarak sepetteki ürünlerin satın alınmasını sağlayan kod.

                }

            }
        }

        static void fiyatAraligiListele(Hashtable table, Musteri musteri)
        {
            // belirli fiyat aralığındaki ürünlerin ekrana listelenip satın alınabilmesini sağlayan metod.
            Console.WriteLine("En düşük fiyat :");
            double enDusuk = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("En yüksek fiyat :");
            double enYuksek = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            // en düşük ve en yüksek fiyatları alıyor.

            List<Urun> aralıktakiUrunler = new List<Urun>();

            foreach (Tree agac in table.Values)
            {
                agac.fiyatAraligiDolas(agac.getRoot(), enDusuk, enYuksek, aralıktakiUrunler);
                // verilen fiyat aralığı dolaşılır.
            }

            if (aralıktakiUrunler.Count == 0)
            {
                Console.WriteLine("Fiyat aralığında ürün bulunamadı.");
                //fiyat aralığında ürün yok ise.
            }
            else
            {
                // fiyat aralığındaki ürünleri listeler.
                int sayac = 0;
                foreach (Urun urun in aralıktakiUrunler)
                {
                    Console.Write("(" + sayac++ + ") ");
                    urun.ozellikYazdir();
                }

                Console.WriteLine("Sepete ürün eklemek istiyor musunuz?(e/h) :");
                string secim = Console.ReadLine();
                if (secim == "e")
                {
                    Console.WriteLine("Sepetinize eklemek istediğiniz ürünleri virgül ile ayırarak yazınız.(1,2):");
                    string[] alinanIndis = Console.ReadLine().Split(',');
                    foreach (string item in alinanIndis)
                    {
                        musteri.Sepet.UrunlerSepet.Add(aralıktakiUrunler[Int32.Parse(item)]);
                        // seçilen ürünleri sepete eklemeyi sağlayan döngü.
                    }
                    satinAl(musteri);
                    // satınal metodunu çağırarak sepetteki ürünlerin satın alınmasını sağlayan kod.

                }


            }
            
        }

        static void isimFiyatListele(Hashtable table,Musteri musteri)
        {
            // verilen kategorideki belirli fiyat aralığındaki ürünleri listeleyip satın almayı sağlayan metod.
            Console.WriteLine("Aramak istediğiniz kategori ismi?");
            string kategoriIsmi = Console.ReadLine();
            Node tmp = null;
            foreach (Tree item in table.Values)
            {
                // kategori isminin var olup olmadığını arayan metod.
                tmp = item.IsimBul(kategoriIsmi);
                if (tmp != null)
                {
                    break;
                }
            }
            if (tmp == null)
            {
                // kategori ismi yok ise.
                Console.WriteLine("Kategori İsmi Bulunamadı");
            }
            else
            {
                // kategori ismi var ise 

                Console.WriteLine("En düşük fiyat :");
                double enDusuk = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.WriteLine("En yüksek fiyat :");
                double enYuksek = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                // en düşük ve en yüksek fıyatı alır.

                List<Urun> aralıktakiUrunler = new List<Urun>();

                foreach (Urun item in tmp.Urunler)
                {
                    if (item.SatisFiyati >= enDusuk && item.SatisFiyati <= enYuksek)
                    {
                        aralıktakiUrunler.Add(item);
                        //fiyat aralığındaki ürünleri urun tutan generic list e ekler.
                    }
                }
                if (aralıktakiUrunler.Count == 0)
                {
                    Console.WriteLine("Fiyat aralığında ürün bulunamadı.");
                    // generic list boş yani fiyat aralığında ürün yok ise.
                }
                else
                {
                    // belirtilen fiyat aralığında ürünler var ise.
                    int sayac = 0;
                    foreach (Urun urun in aralıktakiUrunler)
                    {
                        Console.Write("(" + sayac++ + ") ");
                        urun.ozellikYazdir();
                        // ürünleri ekrana yazdırır.
                    }

                    Console.WriteLine("Sepete ürün eklemek istiyor musunuz?(e/h) :");
                    string secim = Console.ReadLine();
                    if (secim == "e")
                    {
                        Console.WriteLine("Sepetinize eklemek istediğiniz ürünleri virgül ile ayırarak yazınız.(1,2):");
                        string[] alinanIndis = Console.ReadLine().Split(',');
                        foreach (string item in alinanIndis)
                        {
                            musteri.Sepet.UrunlerSepet.Add(aralıktakiUrunler[Int32.Parse(item)]);
                            // seçilen ürünleri sepete ekler.
                        }
                        satinAl(musteri);
                        // satınal metodunu çağırarak sepetteki ürünlerin satın alınmasını sağlayan kod.

                    }

                }
                

            }

        }

        static void satinAl(Musteri musteri)
        {
            // sepetteki ürünlerin satın alınabilmesini sağlayan metod.

            Sepet sepet = musteri.Sepet;
            Console.WriteLine("Sepetinizdeki ürünler:");
            int sayac = 0;
            foreach (Urun item in sepet.UrunlerSepet)
            {
                Console.Write("({0}) ", sayac++);
                item.ozellikYazdir();
                // sepetteki ürünleri listeler.
            }
            Console.WriteLine("Almak istediğiniz ürünleri virgül ile ayırarak yazınız.(1,2)(İşlem yapmadan çıkmak için 'q'):");
            string[] alinanIndis = Console.ReadLine().Split(',');
            // satın alınacak ürünlerin seçimi.
            if (alinanIndis[0]!="q")
            { 
                // kişi sepetteki ürünlerde ürün satın alıcaksa bu if çalışır.
                foreach (string item in alinanIndis)
                {
                    musteri.SatinAlinanlar.Add(musteri.Sepet.UrunlerSepet[Int32.Parse(item)]);
                    musteri.Sepet.UrunlerSepet[Int32.Parse(item)].Miktar--;
                    // satın alınan ürünleri müşterinin satın alınanlarına ekler ve ürün stoğunu bir azaltır.

                }

                foreach (Urun item in musteri.SatinAlinanlar)
                {
                    musteri.Sepet.UrunlerSepet.Remove(item);
                    // satın alınanları sepetten siler.
                }
            }
            

        }

        static void ekonomikDurum(List<Musteri> musteriListesi)
        {
            // firmanın gelir ve giderlerden ekonomik durumunu hesaplayan metod.
            double gelir = 0;
            double gider = 0;
            foreach (Musteri musteri in musteriListesi)
            {
                foreach (Urun urun in musteri.SatinAlinanlar)
                {
                    gider += urun.Maliyet;
                    gelir += urun.SatisFiyati;
                    // satın alınanlar dizisini dolaşır ve gelir ve giderleri toplar.
                }
            }
            Console.WriteLine("Marketin toplam geliri :" + gelir);
            Console.WriteLine("Marketin toplam gideri :" + gider);
            Console.WriteLine("Marketin toplam karı :"+ (gelir-gider));
            // geliri gideri ve karı yazdırır.
            
        }

        static void kelimedenAra(Musteri musteri)
        {
            // verilen bir kelimeyi ürün açıklamalarından arayıp satın almayı sağlayan metod.
            Console.WriteLine("Aramak istediğiniz kelime: ");
            string arama = Console.ReadLine();
            List<Urun> kelimeUrun =(List<Urun>)( Urun.kelimeTablosu[arama]);
            // açıklamaları tutan hashtale dan verilen kelimenin geçtiği ürünlere doğrudan ulaşılır.
            int sayac = 0;
            foreach (Urun urun in kelimeUrun)
            {
                Console.Write("({0}) ", sayac++);
                urun.ozellikYazdir();
                // kelimenin geçtiği ürünleri yazdırır.
            }

            Console.WriteLine("Sepete ürün eklemek istiyor musunuz?(e/h) :");
            string secim = Console.ReadLine();
            if (secim == "e")
            {
                Console.WriteLine("Sepetinize eklemek istediğiniz ürünleri virgül ile ayırarak yazınız.(1,2):");
                string[] alinanIndis = Console.ReadLine().Split(',');
                foreach (string item in alinanIndis)
                {
                    musteri.Sepet.UrunlerSepet.Add(kelimeUrun[Int32.Parse(item)]);
                    // seçilen ürünleri sepete ekler.
                }
                satinAl(musteri);
                // satınal metodunu çağırarak sepetteki ürünlerin satın alınmasını sağlayan kod.

            }


        }

        static void kategoridenAgacBilgisi(Hashtable table)
        { 
            // alınan kategoriden kategori ağacını bulup onun bilgilerini ekrana yazdıran metod.
            Console.WriteLine("Kategoriyi yazınız: ");
            string kategori = Console.ReadLine();
            if (table[kategori]==null)
            {
                Console.WriteLine("Kategori bulunamadı!");
                kategoridenAgacBilgisi(table);
                // kategori bulunamazsa veya yanlış girilirse tekrar giriş yapmayı sağlar.
            }
            else
            {
                Tree agac = (Tree)table[kategori];
                Console.WriteLine("Ağacın PreOrder Dolaşılması: ");
                agac.preOrder(agac.getRoot(), -1);
                Console.WriteLine("Ağacın InOrder Dolaşılması: ");
                agac.inOrder(agac.getRoot(), -1);
                Console.WriteLine("Ağacın PostOrder Dolaşılması: ");
                agac.postOrder(agac.getRoot(), -1);
                Console.WriteLine("Ağaç Bilgileri: ");
                agac.agacInfo();
                // ağac bilgileri ekrana yazılır.
            }
            

        }

        static void heaptenSepeteEkle(Musteri musteri,Hashtable table)
        {
            // girilen kategoriden en ucuz n adet ürünü sayın almayı sağlayan metod.
            Console.WriteLine("en ucuz N adet almak istediğiniz ürünün kategorisini yazınız: ");
            string kategoriIsmi = Console.ReadLine();
            if (kategoriVarMi(kategoriIsmi, table))
            {

                List<Urun> urunler = new List<Urun>();
                ((Tree)table[kategoriIsmi]).agacDolasHeap(((Tree)table[kategoriIsmi]).getRoot(), urunler);
                Heap fiyatHeap = new Heap(urunler.Count);
                foreach (Urun urun in urunler)
                {
                    fiyatHeap.insert(urun);
                }
                Console.WriteLine("N değerini giriniz: ");
                int n = Int32.Parse(Console.ReadLine());
                if (n <= urunler.Count)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Urun tmp = fiyatHeap.remove();
                        musteri.SatinAlinanlar.Add(tmp);
                        tmp.Miktar--;
                        // n adet ürün satın alındı ve stoklar azaltıldı.
                    }
                    // ürünleri satın alan kod.
                    Console.WriteLine("Satın Alma işleminiz başarılı menüye yönlendiriliyorsunuz...");
                    Thread.Sleep(2000);


                }
            }
                
        }

        static void kNNOneri(List<Musteri> musteriListesi,Musteri musteriEtkin)
        {
            // etkin müşteriyi diğer kayıtlı müşterilerle karşılaştırarak özellikleri en yakın müşteriyi kNN algoritmasıyla bulan 
            // ve en yakın müşterinin satın aldığı ürünleri öneri olarak sunup satın alabilmesini sağlayan metod.
            double knnEnKucuk = Double.MaxValue;
            Musteri enYakin = null;
            foreach (Musteri digerMusteri in musteriListesi)
            {
                // kayıtlı müşteriler dolaşılarak en yakın müşteri bulunur.
                if (digerMusteri!=musteriEtkin)
                {
                    if (musteriEtkin.kNN(digerMusteri)<knnEnKucuk)
                    {
                        knnEnKucuk = musteriEtkin.kNN(digerMusteri);
                        enYakin = digerMusteri;
                    }
                }
            }

            Console.WriteLine("Önerilerden sepetinize eklemek istediğiniz ürün var mı?(e/h): ");
            int sayac=0;
            // önerilen ürünleri yazdırır.
            foreach (Urun urun in enYakin.SatinAlinanlar)
            {
                Console.Write("({0}) ",sayac);
                urun.ozellikYazdir();
                sayac++;
            }
            string cevap = Console.ReadLine();
            if (cevap=="e")
                // sepete ürün eklenmek isteniyor ise
            {
                Console.WriteLine("Sepetinize eklemek istediğiniz ürünleri virgül ile ayırarak yazınız.(1,2):");
                string[] alinanIndis = Console.ReadLine().Split(',');
                foreach (string item in alinanIndis)
                {
                    musteriEtkin.Sepet.UrunlerSepet.Add(enYakin.SatinAlinanlar[Int32.Parse(item)]);
                }
                satinAl(musteriEtkin);
                //satınal metodunu çağırarak sepetteki ürünlerin satın alınmasını sağlayan kod.
            }

        }

        static void aprioriOneri(List<Musteri> musteriler,Musteri etkinMusteri)
        {
            // müşterinin aldığı ürünü aynı ürünü alan diğer müşterilerin aldığı diğer ürünlere göre frekansını hesaplayıp
            // buna göre öneride bulunan ve bu önerilerin satın alınabilmesini sağlayan metod.
            List<Urun> benzerUrunler = new List<Urun>();
            // benzerurunleri tutmak için liste oluşturuldu.
            Dictionary<Urun,int> urunFrekans = new Dictionary<Urun, int>();
            // bir dictionary oluşturuldu ve bunda her ürünün frekansı(tekrarı saklanıcak).
            foreach (Urun etkınMusteriUrun in etkinMusteri.SatinAlinanlar)
            {
                foreach (Musteri musteri in musteriler)
                {
                    if (musteri.SatinAlinanlar.Contains(etkınMusteriUrun)) 
                    {
                        foreach (Urun digerMusteriUrun in musteri.SatinAlinanlar)
                        {
                            if (digerMusteriUrun!=etkınMusteriUrun)
                            {
                                if (!urunFrekans.ContainsKey(digerMusteriUrun))
                                {
                                    urunFrekans[digerMusteriUrun] = 1;
                                    // ürün dictionary'e ilk defa ekleniyorsa.
                                }
                                else
                                {
                                    urunFrekans[digerMusteriUrun]++;
                                    // etkin müşteriyle aynı ürünü satın alan diğer müşterinin aldığı ürünler için frekansları arttırır.
                                }
                            }
                        }
                    }
                }

                int max = 0;
                Urun urunBenzer = null;
                foreach (Urun urun in urunFrekans.Keys)
                {
                    // frekansı en fazla olan ürünü bulan döngü.
                    if (urunFrekans[urun]>max)
                    {
                        
                        max = urunFrekans[urun];
                        urunBenzer = urun;
                    }
                }
                benzerUrunler.Add(urunBenzer);
                // frekansı en fazla olan ürünü benzerUrunler listesine ekleyen kod.

            }
            
            int sayac = 0;
            foreach (Urun urun in benzerUrunler)
            {
                Console.Write("({0}) " , sayac++);
                urun.ozellikYazdir();
                // listedeki ürünleri yazdırma.
            }
            Console.WriteLine("Sepetinize eklemek istediğiniz ürünleri virgül ile ayırarak yazınız.(1,2):");
            string[] alinanIndis = Console.ReadLine().Split(',');
            foreach (string item in alinanIndis)
            {
                etkinMusteri.Sepet.UrunlerSepet.Add(benzerUrunler[Int32.Parse(item)]);
                // önerilerden seçilen ürünleri sepete ekleyen döngü.
            }
            satinAl(etkinMusteri);
            // satınal metodunu çağırarak sepetteki ürünlerin satın alınmasını sağlayan kod.

        }

        static void anaMenu(Hashtable table,List<Musteri> musteriListesi,Musteri etkinMusteri,string[] iyiSet,string[] kotuSet)
        {
            // diğer metodları çağırıp programın çalışmasını sağlayan metod.
            Console.WriteLine("(1)Personel Girişi\n(2)Kullanıcı Girişi");
            string secim = Console.ReadLine();
            if (secim=="1")
            {
                personelMenu(table,musteriListesi,etkinMusteri,iyiSet,kotuSet);
            }
            else if (secim=="2")
            {
                musteriMenu(table,musteriListesi,etkinMusteri, iyiSet, kotuSet);
            }
            else
            {
                anaMenu(table,musteriListesi,etkinMusteri, iyiSet, kotuSet);
            }
        }

        static void personelMenu(Hashtable table, List<Musteri> musteriListesi,Musteri etkinMusteri, string[] iyiSet, string[] kotuSet)
        {
            // ana menüden persone menü seçildiğinde çağırılan ve personel işlemlerinin yapılmasını sağlayan metod.
            Console.WriteLine("(1)Markete Yeni İsimde ve/veya Kategoride Ürün Girişi" +
                "\n(2)Markete Yeni Bir Marka/Modelde Ürün Girişi" +
                "\n(3)Kategori İsmi,Marka ve Modelden Ürün Arama ve Silme" +
                "\n(4)Ürün Bilgilerinde Değişiklik(Kategori, Marka, Model, Miktar, Fiyat)"+
                "\n(5)Mali Durum Görüntüleme" +
                "\n(6)Ürün Değerlendirmelerini Görüntüle" +
                "\n(7)Ana Menüye Dön");

            string secim = Console.ReadLine();
            if (secim == "1" || secim =="2")
            {
                urunBilgisiAl(table);
            }
            else if (secim == "3")
            {
                urunSil(urunAra(table));
            }
            else if (secim == "4")
            {
                urunBilgisiDegistir(table);
            }
            else if (secim == "5")
            {
                ekonomikDurum(musteriListesi);
            }
            else if (secim=="6")
            {
                ArrayList aList = urunAra(table);
                yorumDegerlendirme((Urun)aList[1], iyiSet, kotuSet);
            }
            else if (secim == "7")
            {
                anaMenu(table, musteriListesi,etkinMusteri, iyiSet, kotuSet);
            }
            personelMenu(table, musteriListesi, etkinMusteri, iyiSet, kotuSet);

        }

        static void musteriMenu(Hashtable table, List<Musteri> musteriListesi, Musteri etkinMusteri, string[] iyiSet, string[] kotuSet)
        {
            // ana menüden müşteri menüsü seçildiğinde çağırılan ve müşteri işlemlerini yapmayı sağlayan metod.
            if (etkinMusteri == null)
            {
                // o an programı kullanan kullanıcı girişi yapmış bir müşteri yok ise çalışan kod.
                Console.WriteLine("Devam etmek için kayıt olmanız veya giriş yapmanız gerekmektedir." +
                "\n(1)Oturum Aç" +
                "\n(2)Kayıt Ol" +
                "\n(3)Ana Menüye Dön");
                string cevap = Console.ReadLine();
                if (cevap=="1")
                {
                    etkinMusteri=oturumAc(musteriListesi);
                    musteriMenu(table,musteriListesi,etkinMusteri,iyiSet,kotuSet);
                }

                else if (cevap == "2")
                {

                    etkinMusteri = musteriOlustur(musteriListesi);
                }
                else if (cevap=="3")
                {
                    anaMenu(table, musteriListesi, etkinMusteri, iyiSet, kotuSet);
                }

            }
            

            Console.WriteLine("(1)Adından Ürün Bilgisi Arama" +
                "\n(2)Belirli Fiyat Aralığında Arama" +
                "\n(3)Belirli İsimde ve Fiyat Aralığında Arama" +
                "\n(4)Tüm Ürünleri Listeleme(PreOrder,InOrder,PostOrder Dolaşma ve Ağaç Bilgileri)" +
                "\n(5)Kelimeden Ürün Arama" +
                "\n(6)Belirli Kategorideki N Adet En Ucuz Ürün Satın Alma" +
                "\n(7)Ağaç Dengeleme" +
                "\n(8)kNN Önerilerini Gör" +
                "\n(9)Apriori Önerilerini Gör" +
                "\n(10)Satın Aldığınız Ürüne Yorum Yapın" +
                "\n(11)Ana Menüye Dön" +
                "\n(12)Oturumu Kapat");

            string secim = Console.ReadLine();
            if (secim == "1")
            {
                isimdenUrunAra(table, etkinMusteri);
                
            }
            else if (secim == "2")
            {
                fiyatAraligiListele(table, etkinMusteri);
            }
            else if (secim == "3")
            {
                isimFiyatListele(table, etkinMusteri);
            }
            else if (secim == "4")
            {
                kategoridenAgacBilgisi(table);
            }
            else if (secim == "5")
            {
                kelimedenAra(etkinMusteri);
            }
            else if (secim == "6")
            {
                heaptenSepeteEkle(etkinMusteri, table);
            }
            else if (secim == "7")
            {
                Console.WriteLine("Bu kısım henüz geliştirme aşamasında :(");
            }
            else if (secim=="8")
            {
                kNNOneri(musteriListesi, etkinMusteri);
            }
            else if (secim=="9")
            {
                aprioriOneri(musteriListesi, etkinMusteri);
            }
            else if (secim=="10")
            {
                yorumYap(etkinMusteri);
            }
            else if (secim == "11")
            {
                anaMenu(table, musteriListesi, etkinMusteri, iyiSet, kotuSet);
            }
            else if (secim == "12")
            {
                etkinMusteri = null;
            }
            musteriMenu(table, musteriListesi, etkinMusteri, iyiSet, kotuSet);
        }


    }

    
}
