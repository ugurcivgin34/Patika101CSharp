using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
            //ve dizinin elemanlarını sıralayan programı yazınız.
            List<char> harf = new List<char>();
            Console.WriteLine("Cümle giriniz");
            string cumle = Console.ReadLine();
            

            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i]=='a' || cumle[i] == 'e' || cumle[i] == 'ı' || cumle[i] == 'i' || cumle[i] == 'o' || cumle[i] == 'ö' ||
                    cumle[i] == 'u' || cumle[i] == 'ü'  )
                {
                    harf.Add(cumle[i]);
                   
                }
            }

            harf.Sort();

            foreach (var item in harf)
            {
                Console.Write(item + " ");
            }

        }
    }
}
