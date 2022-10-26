using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz c#, hosgeldiniz.";
            string degisken3 = "dersimiz c#, hosgeldiniz.";

            Console.WriteLine("Karakter sayisi: " + degisken.Length);
            Console.WriteLine("Büyük Harf: " + degisken.ToUpper());
            Console.WriteLine("Küçük Harf: " + degisken.ToLower());
            
            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba! "));

            string degisken2 = "ders";

            //Compare to 0, 1 ,-1 Karakter sayısına göre
            Console.WriteLine(degisken.CompareTo(degisken2));

            //compare
            Console.WriteLine(String.Compare(degisken, degisken3, true));
            Console.WriteLine(String.Compare(degisken, degisken3, false));

            //Contains ->içeriyor mu
            Console.WriteLine(degisken.Contains(degisken3));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("c#"));
            Console.WriteLine(degisken.IndexOf("cs"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba "));

            //PadLeft, PadRight  ya da karakter ekliyor.
            Console.WriteLine(degisken + degisken3.PadLeft(30));
            Console.WriteLine(degisken + degisken3.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken3);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken3);

            //Remove
            Console.WriteLine(degisken.Remove(10)); // 10. indexten itibaren
            Console.WriteLine(degisken.Remove(5, 3)); //5. indexten itibaren 3 karakter
            Console.WriteLine(degisken.Remove(0, 1)); //en baştaki deger

            //Replace
            Console.WriteLine(degisken.Replace("c#", "charp"));

            //Split -> karaktere göre ayır. diziye ata.
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring -> . indexten sonuna kadar 
            Console.WriteLine(degisken.Substring(4));//-> 4. indexten sonuna kadar 
            Console.WriteLine(degisken.Substring(4, 6));//-> 4. indexten itibaren 6karakter getir 
            
        }
    }
}
