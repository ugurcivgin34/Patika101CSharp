using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            //(ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.


            List<int> asal = new List<int>();
            List<int> asalOlmayan = new List<int>();

            int sayac = 1;
            int toplamAsal = 0;
            int toplamAsalOlmayan = 0;
            do
            {
                Console.WriteLine("bir sayı giriniz : ");
                bool dogruMu = int.TryParse(Console.ReadLine(), out int sayi);
                if (dogruMu)
                {
                    if (SayiCheck(sayi))
                    {
                        sayac++;
                        if (AsalBul(sayi))
                            asal.Add(sayi);
                        else
                            asalOlmayan.Add(sayi);
                    }

                    else
                    {
                        Console.WriteLine("Lütfen pozitif sayı giriniz :");
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz");
                }

            } while (sayac <= 20);

            asal.Sort();
            asalOlmayan.Sort();

            asal.Reverse();
            asalOlmayan.Reverse();
            

            Console.WriteLine("Asal olanlar");
            foreach (var item in asal)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("------");
            Console.WriteLine("Asal olmayanlar");
            foreach (var item in asalOlmayan)
            {
                Console.Write(item + " ");
            }


            foreach (var item in asal)
            {
                toplamAsal += item;
            }

            foreach (var item in asalOlmayan)
            {
                toplamAsalOlmayan += item;
            }

            Console.WriteLine("Asal listenin elaman sayısı  "+ asal.Count + "\nAsal listenin elamanlarının toplamı : " + toplamAsal);
            Console.WriteLine("Asal olmayan listenin elaman sayısı " + asalOlmayan.Count + "\nAsal olmayan listenin elamanlarının toplamı : " + toplamAsalOlmayan);

        }//Maın Sonu

        static bool SayiCheck(int sayi)
        {
            bool dogruMu = true;
            if (sayi >= 0)
                dogruMu = true;
            else
                dogruMu = false;

            return dogruMu;
        }
        static bool AsalBul(int sayi)
        {
            bool dogrumu = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    dogrumu = false;
                    break;
                }
                else
                {
                    dogrumu = true;
                  
                }
            }
            return dogrumu;
        }
    }
}
