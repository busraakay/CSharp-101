using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Diktortgen dikdortgen = new Diktortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class alan hesabı: " + dikdortgen.AlanHesapla());

            Diktortgen_Struct dikdortgen_struct = new Diktortgen_Struct(3, 4);//initial değerlerini kendi atayamaz.
            Console.WriteLine("Class alan hesabı: " + dikdortgen_struct.AlanHesapla());
        }
    }

    class Diktortgen{
        public int KisaKenar;
        public int UzunKenar;

        public Diktortgen(){
            KisaKenar = 3;
            UzunKenar = 4;
        }

        public long AlanHesapla(){
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Diktortgen_Struct{
        public int KisaKenar;
        public int UzunKenar;

        public Diktortgen_Struct(int kisakenar, int uzunkenar){
            KisaKenar = kisakenar;
            UzunKenar = uzunkenar;
        }

        public long AlanHesapla(){
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
