using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Id = 1;
            musteri1.Adi = "Mahmut";
            musteri1.Soyadi = "Şeker";
            musteri1.Yasi = 64;
            musteri1.Meslek = "Emekli";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Mümtaz";
            musteri2.Yasi = 41;
            musteri2.Meslek = "Mühendis";

            Musteri musteri3 = new Musteri();

            musteri3.Id = 3;
            musteri3.Adi = "Hülya";
            musteri3.Soyadi = "Bal";
            musteri3.Yasi = 27;
            musteri3.Meslek = "Ressam";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.Meslek);

                Console.WriteLine("-----------------");



            }


            

            MusteriManager musteriManager = new MusteriManager();










        }
    }
}
