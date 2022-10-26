using System;
using System.Collections;
using System.Collections.Generic;


namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange 
            Console.WriteLine("***** AddRange ******");
            string[] renkler = { "kırmızı", "sarı", "yeşil"};
            List<int> sayilar = new List<int>{1,54,69,58,47};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //Sort
            Console.WriteLine("**** Sort ******");

            //liste.Sort();//Sıralamak için düzenleme yapılması gerekir
            ArrayList sayilar2 = new ArrayList();
            sayilar2.AddRange(sayilar);
            sayilar2.Sort();

            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }

            //BinarySearch
            Console.WriteLine("**** BinarySearch ******");

            Console.WriteLine(sayilar.BinarySearch(47));

            //Reverse Aynalama
            Console.WriteLine("**** Reverse ******");
            sayilar2.Reverse();
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }

            sayilar2.Clear();
            Console.WriteLine("**** Clear ******");
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
