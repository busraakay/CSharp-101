using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle giriniz: ");
            string cumle = Console.ReadLine();
            string sesliHarfler = "aeoöuüiı"; 
            List<char> cumledekiSesli = new List<char>();

            for (int i = 0; i < cumle.Length; i++)
            {
                if(sesliHarfler.Contains(cumle[i])){
                    cumledekiSesli.Add(cumle[i]);
                }
            }
            cumledekiSesli.Sort();
            foreach (var harf in cumledekiSesli)
            {
                Console.Write(harf + " ");
            }
        }
    }
}
