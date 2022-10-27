using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalListe = new ArrayList();
            ArrayList asalOlmayanListe = new ArrayList();

            Console.WriteLine("20 adet sayı giriniz: ");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + ". sayi: ");
                string girilenDeger = Console.ReadLine();
                int sayi = 0;
                if(!Int32.TryParse(girilenDeger, out sayi)){
                    Console.WriteLine("Tam sayi girmediniz! Tekrar deneyiniz: ");
                    --i;
                    continue;
                }
                if(sayi < 0){
                    Console.WriteLine("Pozitif sayi girmediniz! Tekrar deneyiniz: ");
                    --i;
                    continue;
                }

                int sayac = 0;
                if(sayi == 0 || sayi == 1){
                    asalOlmayanListe.Add(sayi);
                }
                else{
                    for (int j = 2; j < sayi; j++)
                    {
                        if(sayi %j == 0){
                           ++sayac;
                        }
                    }
                
                    if (sayac == 0)
                    {
                       asalListe.Add(sayi);
                    }
                    else{
                        asalOlmayanListe.Add(sayi);
                    }
                }
                
            }

            Console.WriteLine("Asal liste: ");
            asalListe.Sort();
            asalListe.Reverse();
            foreach (var sayi in asalListe)
            {
                Console.Write(sayi + ", ");
            }
            
            double toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < asalListe.Count; i++)
            {
                toplam += Convert.ToInt32(asalListe[i]); 
            }
            ortalama = toplam / asalListe.Count;
            Console.WriteLine("Ortalamasi: " + ortalama);

            Console.WriteLine("\nAsal olmayan liste: ");
            asalOlmayanListe.Sort();
            asalOlmayanListe.Reverse();
            foreach (var sayi in asalOlmayanListe)
            {
                Console.Write(sayi + ", ");
            }
            toplam = 0;
            for (int i = 0; i < asalOlmayanListe.Count; i++)
            {
                toplam += Convert.ToInt32(asalOlmayanListe[i]); 
            }
            ortalama = toplam / asalOlmayanListe.Count;
            Console.WriteLine("Ortalamasi: " + ortalama);
        }
    }
}
