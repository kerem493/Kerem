using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 5;
            product1.Adi = "Bilgisayar";
            product1.Fiyati = 15;
            product1.Aciklama = "Laptop";

            Product product2 = new Product();
            product2.Id = 3;
            product2.Adi = "Cep telefonu";
            product2.Fiyati = 15;
            product2.Aciklama = "telefon";



            Console.WriteLine(product1.Id+
                "\n"+product1.Adi+
                "\n"+ product1.Aciklama+"\n" 
                + product1.Fiyati) ;

            Console.WriteLine("------------------Metodlar------------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            

        }
    }
}
