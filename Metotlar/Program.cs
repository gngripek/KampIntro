using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";


            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            //aslında bir ürün oluşturduk

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2 };

            //urun1 urun2 aslında veri  kaynağından gelir

            //type safe-- tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }

            //in urunler-benim urunler diye bir dizim var ya onu tek tek gez demek
            //urun-urun sayı kadar dön anlamında yani o anki elemana takma isim veriyoruz
            //soldaki Urun ise veri tipi niye yazıyoruz çünkü c# java gibi diller tip güvenlidir
            // var da yazabilirsin 

            Console.WriteLine("-----------Metotlar----------");

            // instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 10);
           

        }
    }
}


// Dont Repeat yourself-DRY- Clean Code- Best Practice
