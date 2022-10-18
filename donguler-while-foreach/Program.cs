using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayrak konsoldan girilen sayıya kadar sayı dahil ortalma hesaplayıp konsola yazdıran program.
            Console.WriteLine("Lütfen sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: " + toplam / sayi);

            // a dan z ye kadar tüm harfleri konsola yazdır.
            char kar = 'a';
            while(kar <= 'z'){
                Console.Write(kar + " ");
                kar++;
            }

            // foreach
            Console.WriteLine("*****Forach*****");

            string[] arabalar = {"bmw", "mercedes", "toyota", "nissan"} ;

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
