namespace arayuzler_ornek
{
    public class NewCivic : Otomobil{

        public override Marka HangiMarkaninAraci(){
            return Marka.Honda;
        }

        public Renk StandartRengiNe(){
            return Renk.Gri;
        }
    }
}