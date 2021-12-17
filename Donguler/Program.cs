using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            string[] kurslar = new string[] {"Yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç için temel kurs", "Java"  };

            //Donguler birbirine benzeyen işlemleri tekrar etmek için kullanılan yapılardır.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                

            }
            foreach (string  kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("FOOTER"  );

        }
    }
}
