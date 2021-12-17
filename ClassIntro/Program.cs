using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Nurullah";
            int yas = 21;
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin";
            kurs1.KursAdi = "Java";
            kurs1.IzlenmeOranı = 55;

            Kurs kurs2 = new Kurs();
            kurs2.IzlenmeOranı = 44;
            kurs2.Egitmen = "Nurullah";
            kurs2.KursAdi = "python";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C";
            kurs3.Egitmen = "odtülü hoca";
            kurs3.IzlenmeOranı = 99;
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":"+kurs.Egitmen);
            }




        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOranı { get; set; }

        }
    }
}
