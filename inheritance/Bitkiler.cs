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

        protected void Fotosentez(){
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler : Bitkiler{

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
        }

        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir.");
        }
    }
}