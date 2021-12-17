using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya elmasi";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı =80;
            urun2.Aciklama = "(Diyarbakır karpuzu)";
            urun2.StokAdedi = 20;
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("******************************");
            }
            Console.WriteLine("Metotlar----------------------------------");

            SepetManager sepetManager = new SepetManager(); //instance örnek
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil armut", 12); // zor durum class kullanarak yapmak daha kolay
            sepetManager.Ekle2("muz", "sarı muz", 30);






        }
    }
}
