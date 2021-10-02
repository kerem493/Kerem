using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            //musteri.Ad = Console.ReadLine();
            //musteri.Soyad = Console.ReadLine();
            Console.WriteLine("Müşteri Eklendi : {0}{1} ",musteri.Ad+" ",musteri.Soyad);
        }
        public void Listele(Musteri musteri)
        {
            //musteri.Ad = Console.ReadLine();
            //musteri.Soyad = Console.ReadLine();
            Console.WriteLine("Müşteri Listelendi : {0}{1} ", musteri.Ad + " ", musteri.Soyad);

        }

        public void Silme(Musteri musteri)
        {
            //musteri.Ad = Console.ReadLine();
            //musteri.Soyad = Console.ReadLine();
            Console.WriteLine("Müşteri Silindi : {0}{1} ", musteri.Ad + " ", musteri.Soyad);

        }

        
    }
}
