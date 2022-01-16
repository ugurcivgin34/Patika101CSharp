using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları
            //ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            List<int> sayilar = new List<int>();
            int sayi = 0;
            Console.WriteLine("lütfen 20 tane sayı giriniz");
            for (int i = 0; i < 20; i++)
            {
                sayi = int.Parse(Console.ReadLine());
                sayilar.Add(sayi);

            }

            sayilar.Sort();
            Console.WriteLine("En büyük 3 sayı : " + sayilar[19] +" " + sayilar[18] + " " + sayilar[17]);
            Console.WriteLine("En küçük 3 sayı : " + sayilar[0] + " " + sayilar[1] + " " + sayilar[2]);
            Console.WriteLine("Ortalamalar " + ((sayilar[19] + sayilar[18] + sayilar[17])/2)+
                ((sayilar[0] +  sayilar[1] +  sayilar[2])/2));
           
        }
    }
}
