using System;

namespace kurucu_metotlar
{
     class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 1654645, "Insan Kaynaklari");
            calisan1.CalisanBilgileri();

            Console.WriteLine("*************************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Büşra";
            calisan2.Soyad = "Akay";
            calisan2.No = 54646464;
            calisan2.Departman = "Yazilim";
            calisan2.CalisanBilgileri();

            Console.WriteLine("*************************");

            Calisan calisan3 = new Calisan("Ahmet", "Kaya");
            calisan3.CalisanBilgileri();

        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad){
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri(){
            Console.WriteLine("Calisan adi: " + Ad);
            Console.WriteLine("Calisan soyadi: " + Soyad);
            Console.WriteLine("Calisan numarasi: " + No);
            Console.WriteLine("Calisan departmani: " + Departman);
        }
    }
}
