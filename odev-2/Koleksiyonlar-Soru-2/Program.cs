using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.Write((i + 1) + ". sayiyi giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                liste.Add(sayi);
            }
            liste.Sort();
            double toplam = 0;
            double ortalama = 0;
            Console.Write("En küçük 3 sayi: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(liste[i] + ", ");
                toplam += Convert.ToInt32(liste[i]);
            }
            ortalama = toplam / 3;
            Console.WriteLine("Toplami: " + toplam);
            Console.WriteLine("Ortalamasi: " + ortalama);

            liste.Reverse();
            toplam = 0;
            Console.WriteLine("En büyük 3 sayi: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(liste[i] + ", ");
                toplam += Convert.ToInt32(liste[i]);
            }
            ortalama = toplam / 3;
            Console.WriteLine("Toplami: " + toplam);
            Console.WriteLine("Ortalamasi: " + ortalama);

        }
    }
}
