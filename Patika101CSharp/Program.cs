using System;

namespace Patika101CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            //Console.WriteLine("Pozitif bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());
            //int pozitifSayi = 0;

            //Console.WriteLine(sayi + " tane sayı giriniz : ");
            //for (int i = 1; i <= sayi; i++)
            //{
            //    pozitifSayi = int.Parse(Console.ReadLine());
            //    if(pozitifSayi%2==0)
            //    {
            //        Console.WriteLine("Çift sayıdır");
            //    }
            //}

            //------------------------------------------------------------------------------------------------------
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            //Console.WriteLine("Pozitif birinci sayıyı giriniz:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Pozitif ikinci sayıyı giriniz:");
            //int m = int.Parse(Console.ReadLine());
            //int sayi = 0;

            //Console.WriteLine(n + " adet sayı giriniz");

            //for (int i = 1; i <= n; i++)
            //{
            //    sayi = int.Parse(Console.ReadLine());

            //    if(sayi==m || sayi % m == 0)
            //    {
            //        Console.WriteLine("m eşittir yada m e tam bölünür");
            //    }


            //------------------------------------------------------------------------------------------------------
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            //Console.WriteLine("Sayı giriniz:");
            //bool dogruMu = false;
            //int sayi = 0;
            //do
            //{

            //    dogruMu = int.TryParse(Console.ReadLine(), out sayi);
            //    if(!dogruMu)
            //        Console.WriteLine("Lütfen sayısal değer giriniz :");
            //} while (!dogruMu);



            //string[] dizi = new string[sayi];
            //string ifade = " ";

            //Console.WriteLine(sayi + " tane kelime giriniz");

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = Console.ReadLine();

            //}

            //Console.WriteLine("Ters hali");

            //for (int i = dizi.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //------------------------------------------------------------------------------------------------------
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle giriniz");
            string ifade = Console.ReadLine();
            string[] dizi = ifade.Split(' ');
            int kelime = 0;
            int harf = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                kelime++;

            }
            for (int i = 0; i < ifade.Length; i++)
            {
                if(ifade[i]!=' ')
                {
                    harf++;
                }
            }
            Console.WriteLine("Kelime sayısı "+kelime);
            Console.WriteLine("Harf sayısı " + ((harf )));


        }
    }

}


