﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı","Programlamaya başlangıç için temel kurs","Java","Python"};




            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]) ;
            }
            Console.WriteLine("For biti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu - footer");
            




        }
    }
}