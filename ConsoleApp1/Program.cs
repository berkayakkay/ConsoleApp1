using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "Amasya elması";
            

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //type syfe
            //foreach(var urun in urunler)
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");

            }//encapsulation
            Console.WriteLine("----Metotlar----");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2 );
        }
    }
}
