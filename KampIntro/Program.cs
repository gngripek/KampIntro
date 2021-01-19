using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety- tip güvenliği
            //do not repeat yourself- Kendini tekrarlama
            //değer tutucu,alias

            string kategoriEtiketi = "Kategoriler";
            
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
            
    }
}
