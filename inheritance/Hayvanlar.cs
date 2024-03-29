using System;

namespace inheritance
{
    public class Hayvanlar : Canlilar
    {
        
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
    }

    public class Surungenler : Hayvanlar{

        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }

        public void SurunerekHareket(){
            Console.WriteLine("Surungenler sürünerek hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar{

        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }

        public void Ucmak(){
            Console.WriteLine("Kuslar ucar.");
        }
    }
}