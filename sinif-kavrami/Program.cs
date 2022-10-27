using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 16464516;
            calisan1.Departman = "Insan Kaynaklari";

            calisan1.CalisanBilgileri();
            Console.WriteLine("*************************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Büşra";
            calisan2.Soyad = "Akay";
            calisan2.No = 54646464;
            calisan2.Departman = "Yazilim";

            calisan2.CalisanBilgileri();

        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){
            Console.WriteLine("Calisan adi: " + Ad);
            Console.WriteLine("Calisan soyadi: " + Soyad);
            Console.WriteLine("Calisan numarasi: " + No);
            Console.WriteLine("Calisan departmani: " + Departman);
        }
    }
}
