using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b=5;   //bellekte 1 byte yer kaplar
            sbyte c=5;  //1 byte yer kaplar

            short s=5;  //2 byte yer kaplar
            ushort us=5;    //2 byte unsigned

            Int16 i16= 2; // 2byte
            int i = 2;  //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte
            
            uint ui=2; //4byte
            long l = 2;     //8 byte
            ulong ul = 2;   //8 byte

            //reel sayılar
            float f = 2;      //4 byte
            double d= 1;      //8 byte
            decimal de = 16;     //16 byte

            char ch = '2';     //2 byte
            string str = "busra"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3; //her türlü değeri alır.

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Busra Akay";
            string ad = "Busra";
            string soyad = "Akay";
            string tamIsım = ad + " " + soyad;
            Console.WriteLine(tamIsım);


            //integer tanımlama şekillleri
            int inte1= 5;
            int inte2= 10;
            int carpim = inte1 * inte2;

            //boolean
            bool bool1 = 10<2;


            //Degisken donusumleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);
              
            int toplam = int20 + Convert.ToInt32(str20);
            Console.WriteLine(toplam); 

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);


            //datetime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}
