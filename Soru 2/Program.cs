using System;
using System.Collections;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            for (int i= 0; i<20; i++){
                System.Console.Write("Lütfen pozitif bir {0}.Sayıyı Giriniz:",i+1);
                if(int.TryParse(Console.ReadLine(), out int sayi) && sayi>0){
                    sayilar[i] = sayi;

                }else{
                    i-=1;
                    System.Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz...");
                }
            }

            Array.Sort(sayilar);
            
            int kucukToplam= 0;
            int buyukToplam= 0;
            System.Console.WriteLine("-- Küçük Sayılar --");
            for(int i = 0; i<3; i++){
                System.Console.WriteLine(sayilar[i]);
                kucukToplam += sayilar[i];
            }

            Array.Reverse(sayilar);
            System.Console.WriteLine("-- Büyük Sayılar --");
            for(int i = 0; i<3; i++){
                System.Console.WriteLine(sayilar[i]);
                buyukToplam += sayilar[i];
            }

            System.Console.WriteLine("Küçük sayıların toplamı: {0}",kucukToplam);
            System.Console.WriteLine("Büyük sayıların toplamı: {0}",buyukToplam);
            
            System.Console.WriteLine("Küçük sayıların ortalaması: {0}",((decimal)kucukToplam/3).ToString("0.000"));
            System.Console.WriteLine("Büyük sayıların ortalaması: {0}",((decimal)buyukToplam/3).ToString("0.000"));



        }
    }
}