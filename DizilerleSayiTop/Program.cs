using System;

namespace DizilerleSayiTop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 1, 2, 3, 4 };

            int toplam = 0;

            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Toplam : "+toplam);
        }
    }
}
