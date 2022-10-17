using System;
using System.Collections;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                
                System.Console.Write("Lütfen pozitif bir {0}.sayı Giriniz: ", i+1);
                if ((int.TryParse(Console.ReadLine(), out int sayi)) && sayi>1){
                    if(sayi==2){
                        asalSayilar.Add(sayi);
                    }

                    for (int j = 2; j < sayi; j++)
                    {
                        if(sayi % j == 0){
                            asalOlmayanSayilar.Add(sayi);
                            break;
                        }else{
                            if(j+1==sayi){
                                asalSayilar.Add(sayi);
                            }
                        }
                    }  
                }else{
                    i -= 1;
                    System.Console.WriteLine("Hatalı giriş yaptınız tekrar deneyiniz...");
                }
                
            }

            asalSayilar.Sort();
            asalOlmayanSayilar.Sort();

            asalSayilar.Reverse();
            asalOlmayanSayilar.Reverse();

            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            System.Console.WriteLine("-- Asal Sayılar --");
            if(!(asalSayilar.Count==0)){
                foreach (int item in asalSayilar)
                            {
                                System.Console.WriteLine(item);
                                asalToplam += item;

                            }
            System.Console.WriteLine("Asal Sayıların Eleman Sayısı: {0}",asalSayilar.Count);
            System.Console.WriteLine("Asal Sayıların Ortalaması: {0}",((decimal)asalToplam/asalSayilar.Count).ToString("0.000"));
            }else{
                System.Console.WriteLine("Asal Sayı listede yok.");
                System.Console.WriteLine("Asal Sayıların Eleman Sayısı: {0}",asalSayilar.Count);
                System.Console.WriteLine("Asal Sayıların Ortalaması: 0");
            }
            

            System.Console.WriteLine("-- Asal Olmayan Sayılar --");
            if(!(asalOlmayanSayilar.Count==0)){
                foreach (int item in asalOlmayanSayilar)
                {
                    System.Console.WriteLine(item);
                    asalOlmayanToplam += item;

                }
                System.Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı: {0}",asalOlmayanSayilar.Count);
                System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması: {0}",((decimal)asalOlmayanToplam/asalOlmayanSayilar.Count).ToString("0.000"));}
            else{
                System.Console.WriteLine("Asal olmayan sayı listede yok.");
                System.Console.WriteLine("Asal Olmayan Sayıların Eleman Sayısı: {0}",asalOlmayanSayilar.Count);
                System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması: 0");
                }
        }

            

            
    }
}
