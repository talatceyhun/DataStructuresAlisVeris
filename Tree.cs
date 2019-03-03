using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3Av1
{
    class Tree
    {
        private Node root;
        private int derinlik;
        // eleman sayısı ve eleman düzeyleri değişkenleri programın kullanıcı bölümündeki listeleme işlemlerindeki ayrıntılardan 
        // dolayı tutulmuştur.
        private int elemanSayisi;
        private int[] elemanDuzeyleri;

        public Tree()
            // boş bir tree oluşturan parametresiz konstructor.
        {
            root = null;
            derinlik = -1;
            elemanSayisi = 0;
            elemanDuzeyleri = new int[500];
        }

        public Node getRoot()
            // Tree'nin kökünü döndüren method.
        {
            return root;
        }

        public void preOrder (Node tmp,int duzey)
        {
            // Tree yi preorder dolaşan ve dolaşırken aynı anda kullanıcı bölümünde bizden istenen eleman sayısı ile düzeyi
            // hesaplayan recursive metod.
            // metod çağırılırken düzey -1 olarak verilecektir.
            if (tmp != null)
                // node null olmadıkça çalışmaya devam ediyor.
            {
                elemanSayisi++;
                duzey++;
                elemanDuzeyleri[duzey]++;
                if (duzey>derinlik)
                {
                    derinlik = duzey;
                }
                foreach (Urun item in tmp.Urunler)
                {
                    // ürünün binary search tree deki düzeylerini yazdıran döngü.
                    item.ozellikYazdir();
                    Console.WriteLine("Ürünün BST'deki Düzeyi: " + duzey);
                }
                preOrder(tmp.LeftChild,duzey);
                // preorder olduğu için ebeveyn den sonra önce sol çağırılıyor sonra da sağ.
                preOrder(tmp.RightChild,duzey);
            }
        }

        public void inOrder(Node tmp, int duzey)
        {
            // Tree yi inorder dolaşan ve ürünlerin bst deki düzeylerini yazdıran metod. (aynı zamanda bize küçükten büyüğe sıralama
            // imkanı da sağlar.)
            // metod çağırılırken düzey -1 olarak verilecektir.
            if (tmp != null)
                // node null olmadıkça çalışmaya devam edicek.
            {
                duzey++;
                inOrder(tmp.LeftChild, duzey);
                // inorder olduğu için önce sol taraf çağırıldı.
                foreach (Urun item in tmp.Urunler)
                    // ilgili node daki ürünleri dolaşıp düzeylerini yazdıran döngü.
                {
                    item.ozellikYazdir();
                    Console.WriteLine("Ürünün BST'deki Düzeyi: " + duzey);
                }
                
                inOrder(tmp.RightChild, duzey);
                // en son ise sağ taraf çağırıldı.
            }
        }

        public void postOrder(Node tmp, int duzey)
        {
            // Tree yi postorder dolaşan ve ürünlerin bst deki düzeylerini yazdıran metod.
            // Metod çağırılırken düzey -1 olarak verilecektir.
            if (tmp != null)
            {
                duzey++;
                postOrder(tmp.LeftChild, duzey);
                // önce sol taraf çağırıldı.
                postOrder(tmp.RightChild, duzey);
                // sonra sağ taraf.
                foreach (Urun item in tmp.Urunler)
                {
                    item.ozellikYazdir();
                    Console.WriteLine("Ürünün BST'deki Düzeyi: " + duzey);
                }
            }
        }

        public void agacInfo()
        {
            // kullancı girişinde ağaç hakkında bilgiler istendiği için yazılan metod.
            // derinliği elemansayısını ve her bir düzeydeki eleman sayısını yazdırır.
            // bu metod çağırılmadan önce preorder dolaşılacağından.(kullanıcı girişinin ilgili maddesinde 
            // aynı zamanda preorder dolaşma da istenildiği için önce o çağırılacağından metodun çalışmasında bir sorun oluşmamaktadır.
            Console.WriteLine("Derinlik: " + derinlik);
            Console.WriteLine("Eleman sayısı: " + elemanSayisi);
            int sayac = -1;
            foreach (int item in elemanDuzeyleri)
            {
                if (item!=0)
                {
                    sayac++;
                    Console.WriteLine(sayac + ". düzeydeki eleman sayısı: " + item);
                }
                else
                // ilgili düzeyde eleman olup olmadığını kontrol eder.
                {
                    break;
                }
            }


        }

        public void fiyatAraligiDolas(Node tmp,double dusuk, double yuksek, List<Urun> liste)
        {
            // kullanıcının belirli fiyat aralığındaki ürünleri listelemesini sağlayan metod.
            // bu metod uygulanırker ağaç preorder mantığında dolaşılmaktadır.
            if (tmp!=null)
                // node null olmadıkça çalışmaya devam eder.
            {
                foreach (Urun item in tmp.Urunler)
                    // ilgili node un ürün tipinde öğeler tutan generic list ini dolaşır.
                {
                    if (item.SatisFiyati>=dusuk && item.SatisFiyati<=yuksek)
                    {
                        // ürünün fiyatı verilen aralıktaysa listeye ürünü ekler
                        liste.Add(item);
                    }
                }

                fiyatAraligiDolas(tmp.LeftChild, dusuk, yuksek, liste);//sol taraf çağırılır(recursive).
                fiyatAraligiDolas(tmp.RightChild, dusuk, yuksek, liste);// sağ taraf çağırılır(recursive).
            }
        }

        public void YeniKategoriUrunEkle (string isim)
        {
            // kategori ağacına yeni bir kategori ismi (Bilgisayar ağacına tablet bilgisayar kategori ismini eklemek gibi) ekleyen metod.

            Node newNode = new Node();
            newNode.Isim = isim; 
            // yeni bir node oluştu ve node'ın ismi atandı.
            // alt satırlarda da node'un ismine göre konumlandırması yapılacaktır.

            if (root == null)
            {
                // root boş ise yeni eklenen node root olarak atanır ve metod sona erer.
                root = newNode;
            }
            else
            {
                // root ta eleman varsa bu kısım çalışır.
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (isim.CompareTo(current.Isim) == -1)
                        // yeni eklenen node ile current node un isimleri alfabetik olarak karşılaştırılır.
                    {
                        current = current.LeftChild;
                        if (current==null)
                        {
                            parent.LeftChild = newNode;
                            // node eklenir ve metoddan çıkılır.
                            return;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current==null)
                        {
                            parent.RightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public Node IsimBul(string isim)
            // verilen bir ismin(kategori ismi örneğin çamaşır makinesi) olup olmadığını bulan kategori isminin ait olduğu 
            // node u döndüren metod. eğer parametre olarak verilen isimle aynı bir kategori ismi yok ise null döndürür.
        {
            Node tmp = null;           
            Node current = root;
                Node parent;

            while (true)
            {
                parent = current;
                if (current==null)
                    // başlangıçta root un null olup olmadığını denetler.
                {
                    tmp=null;
                    break;
                }
                if (current.Isim.CompareTo(isim)==0)
                {
                    tmp = current;
                    // isim kategori ismine eşit ise aranan isim var demektir ve o node u döndürür.
                    break;
                }
                if (current.Isim.CompareTo(isim) == -1)
                {
                    current = parent.RightChild; 
                    // aranan alfabetik olarak sonraysa sağa gider.
                }
                else
                {
                    current = parent.LeftChild;
                    // aranan alfabetik olarak önceyse sola gider.
                }
            }
                
            // tmp yi döndürür.
            return tmp;
        }

        public void agacDolasHeap(Node tmp,List<Urun> liste)
        {
            // fiyata göre sıralama yapan heap veri yapısına eklenecek ürünleri bularak parametrede aldığı listeye ekler.
            if (tmp!=null)
            {
                foreach (Urun urun in tmp.Urunler)
                {
                    liste.Add(urun);
                }
                agacDolasHeap(tmp.LeftChild,liste);
                agacDolasHeap(tmp.RightChild, liste);
            }
        }
    }
}
