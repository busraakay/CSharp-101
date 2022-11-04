using System;

namespace inheritance
{
    public class Bitkiler : Canlilar
    {
        public Bitkiler(){
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }

        public override void UyaranlaraTepki(){
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler gunese tepki verir.");
        }

        protected void Fotosentez(){
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler : Bitkiler{

        public TohumluBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla cogalir.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler{

        public TohumsuzBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        }

        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir.");
        }
    }
}