using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(3);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            foreach(var sayi in sayiListesi){
                Console.WriteLine(sayi);
            }

            foreach(var renk in renkListesi){
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi =>Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Listeden elemean çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.ForEach(sayi =>Console.WriteLine(sayi));
            renkListesi.ForEach(renk =>Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi =>Console.WriteLine(sayi));
            renkListesi.ForEach(renk =>Console.WriteLine(renk));

            //Listede arama
            if(sayiListesi.Contains(10)){
                Console.WriteLine("Liste içerisinde bulunuyor.");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));
            
            //Diziyi Listeye çevirme
            string[] hayvanlar={"kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Liste temizleme
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kul1 = new Kullanicilar();
            kul1.Isim = "Büşra";
            kul1.Soyisim = "Akay";
            kul1.Yas = 23;

            Kullanicilar kul2 = new Kullanicilar();
            kul2.Isim = "Kubra";
            kul2.Soyisim = "Akay";
            kul2.Yas = 21;

            kullaniciListesi.Add(kul1);
            kullaniciListesi.Add(kul2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 25
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: " + kullanici.Yas);
            }

            yeniListe.Clear();


        }
    }

    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
