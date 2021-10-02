using System;

namespace DışardanVeriyleKategori
{
    class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category();

            Console.WriteLine("Sayı Girin : ");
            category.sayi = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < category.sayi; i++)
            {                
                Console.WriteLine("İsim Girin : ");
                category.name = Console.ReadLine();

                Console.WriteLine(category.name);

            }

            

        }

        class Category
        {
            public string name;
            public int sayi;
        }
    }
}
