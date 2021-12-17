using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster ");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu göster  ");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");

                
            }
            else
            {
                Console.WriteLine("");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
