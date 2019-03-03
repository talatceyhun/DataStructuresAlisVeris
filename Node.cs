using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3Av1
{
    class Node
    {
        private string isim;
        private List<Urun> urunler ;
        private Node leftChild;
        private Node rightChild;

        public Node()
        {
            // node oluşturan parametresiz constructor.
            urunler = new List<Urun>();
        }

        
        // değişkenlerin getter ve setter ları. 
        public string Isim { get => isim; set => isim = value; }
        internal List<Urun> Urunler { get => urunler; set => urunler = value; }
        internal Node LeftChild { get => leftChild; set => leftChild = value; }
        internal Node RightChild { get => rightChild; set => rightChild = value; }

        // node u ekrana yazdıran metod.
        public void displayNode()
        {
            foreach (Urun item in urunler)
            {
                item.ozellikYazdir();
                Console.WriteLine("*************************************************************");
            }
        }
    }
}
