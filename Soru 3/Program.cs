using System;
using System.Collections;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sesliHarfler = "aeıioöuüAEIİOÖUÜ"; 
            string cumle = Console.ReadLine();

            List<char> sesli = new List<char>();

            for(int i = 0; i<cumle.Length; i++){
                if(sesliHarfler.Contains(cumle[i])){
                    sesli.Add(cumle[i]);
                }
            }
            System.Console.WriteLine("Cümlede ki sesli harfler:");
            foreach(var item in sesli){
                System.Console.WriteLine(item);
            }
        }
    }
}