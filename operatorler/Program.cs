using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Atama ve işlemli atama *******");
            //Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("******** Mantıksal operatorler *******");
            //Mantıksal operatorler
            // || && !
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("perfect!");
            }

            if(isSuccess || isCompleted)
            {
                Console.WriteLine("great!");
            }

            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("fine!");
            }

            Console.WriteLine("******** İlişkisel operatörler *******");
            //İlişkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("******** Aritmetik operatorler *******");
            //Aritmetik operatorler
            // /, *, -, +
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - 1;
            Console.WriteLine(sonuc1);

            Console.WriteLine("******** % mod almak için *******");
            // % mod almak için
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);



        }
    }
}
