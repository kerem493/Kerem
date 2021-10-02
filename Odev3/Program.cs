using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            //musteri.Id = 1;
            //musteri.Ad = "Kerem ";
            //musteri.Soyad = "KORKMAZ";

            MusteriManager musteriManager = new MusteriManager();
            //musteriManager.Ekle(musteri);



            Console.WriteLine("1 : Ekle\n2 : Listele\n3 : Silme");

            int islem;
            Console.Write("Yapmak istediğiniz işlemi belirtin: ");
            islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Console.Write("İsim : ");
                musteri.Ad = Console.ReadLine();
                Console.Write("Soyisim : ");
                musteri.Soyad = Console.ReadLine();
                musteriManager.Ekle(musteri);
            }
            else if (islem == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("İsim : ");
                    musteri.Ad = Console.ReadLine();
                    Console.Write("Soyisim : ");
                    musteri.Soyad = Console.ReadLine();
                    musteriManager.Listele(musteri);
                }

            }
            else if (islem == 3)
            {
                Console.Write("İsim : ");
                musteri.Ad = Console.ReadLine();
                Console.Write("Soyisim : ");
                musteri.Soyad = Console.ReadLine();
                musteriManager.Silme(musteri);
            }
            else
            {
                Console.WriteLine("Eksik ya da hatalı giriş!");
            }


        }
    }
}
