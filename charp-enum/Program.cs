using System;

namespace charp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 20;

            if(sicaklik <= (int)HavaDurumu.Normal){
                Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekleyelim.");
            }
            else if(sicaklik >= (int)HavaDurumu.Sicak){
                Console.WriteLine("Disariya cikmak icin cok sicak bir gün.");
            }
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak){
                Console.WriteLine("Hadi disari cikalim.");
            }
            
        }
    }

    enum Gunler{
        Pazartesi = 1,
        Sali,
        Carsamba,
        Persembe = 24,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
