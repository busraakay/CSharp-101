using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());


        }
    }
}
