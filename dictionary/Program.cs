using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Büşra Akay");
            kullanicilar.Add(11, "Kübra Akay");
            kullanicilar.Add(12, "Emre Uzun");

            //Dizinin elemanlarına erişim
            Console.WriteLine("****Dizinin elemanlarına erişim*****");
            Console.WriteLine(kullanicilar[12]);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("****Count*****");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("****Contains*****");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Büşra Akay"));

            //Remove
            Console.WriteLine("****Remove*****");
            kullanicilar.Remove(12);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
