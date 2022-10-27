using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yilmaz";
            ogrenci.No = 293;
            ogrenci.Sinif = 3;

            ogrenci.OgrenciBilgileriGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 532, 1);
            ogrenci2.OgrenciBilgileriGetir();

            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriGetir();

        }
    }

    class Ogrenci{
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim { 
            get => isim; 
            set => isim = value; 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif { 
            get => sinif; 
            set{
                if(value < 1){
                    Console.WriteLine("Sinif en az 1 olabilir!");
                    sinif = 1;
                }
                else
                {
                    sinif = value; 
                }
            } 
        }

        public Ogrenci(){}

        public Ogrenci(string isim, string soyisim, int no, int sinif){
            Isim = isim;
            Soyisim = soyisim;
            No = no;
            Sinif = sinif;
        }

        public void OgrenciBilgileriGetir(){
            Console.WriteLine("********Öğrenci Bilgileri*******");
            Console.WriteLine("Ogrenci adi: " + this.Isim);
            Console.WriteLine("Ogrenci soyadi: " + this.Soyisim);
            Console.WriteLine("Ogrenci no: " + this.No);
            Console.WriteLine("Ogrenci sinifi: " + this.Sinif);
        }

        public void SinifAtlat(){
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur(){
            this.Sinif = this.Sinif - 1;
        }
    }
}
