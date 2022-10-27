using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Ali", "Veli", "İK");
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Ali", "Veli", "İK");
            Calisan calisan3 = new Calisan("Ali", "Veli", "İK");
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: " + Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: " + Islemler.Cikar(400, 200));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan() //bir kere çalıştırılır.
        {
            calisanSayisi = 0;
        }

        public Calisan(string Isim, string Soyisim, string Departman)
        {
            this.isim = Isim;
            this.soyisim = Soyisim;
            this.departman = Departman;
            calisanSayisi++;
        }
    }

    static class Islemler{

        public static long Topla(int sayi1, int sayi2){
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2){
            return sayi1 - sayi2;
        }
    }
}
