using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Product product) 
        {
            Console.WriteLine("Seçmiş olduğunuz ürün : {0}," +
                " sepete eklendi.",product.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat) 
        {
            Console.WriteLine("Seçmiş olduğunuz ürün : {0}," +
                " sepete eklendi.", urunAdi);
        }
    }
}
