using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kerem";
            musteri1.Soyadi = "KORKMAZ";
            musteri1.TcNo = "54512";
            musteri1.Id = 1;


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "56789";
            musteri2.SirketAdi = "Gökay";
            musteri2.VergiNo = "1231651";
            musteri2.Id = 2;

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);


        }
    }
}
