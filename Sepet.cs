using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3Av1
{
    class Sepet
    {
        private List<Urun> urunlerSepet;

        public Sepet()
        {
            // parametresiz konstructor bir sepet oluşturur ve içerisindeki ürün tutan listeyi tanımlar.
            UrunlerSepet = new List<Urun>();
        }

        internal List<Urun> UrunlerSepet { get => urunlerSepet; set => urunlerSepet = value; }
        // ürünlersepetin getter ve setter ı.
    }
}
