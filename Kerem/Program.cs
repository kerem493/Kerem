using System;

namespace Kerem
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.urunAdi = "Xiaomi";
            product1.urunAciklama = "Telefon";
            product1.urunFiyat = "3000";

            Product product2 = new Product();
            product2.urunAdi = "Monster";
            product2.urunAciklama = "Bilgisayar";
            product2.urunFiyat = "9000";

            Product product3 = new Product();
            product3.urunAdi = "Apple Watch";
            product3.urunAciklama = "Saat";
            product3.urunFiyat = "2000";


            Product[] products = new Product[] {product1,product2,product3 };

            foreach (var item in products)
            {
                Console.WriteLine(item.urunAdi+" : "+item.urunAciklama+" : "+item.urunFiyat);
            }

            

        }

        public class Product
        {
            public string urunAdi { get; set; }
            public string urunAciklama { get; set; }
            public string urunFiyat { get; set; }
        }


    }
}
