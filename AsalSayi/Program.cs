using System;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {

            int asalMi = 0;
            for (int i = 1; i < 100; i++)
            {
                if (asalMi % i == 0)
                {
                    asalMi++;
                }
                else if (asalMi != 0)
                {
                    Console.WriteLine(asalMi);
                }

            }


        }
    }
}
