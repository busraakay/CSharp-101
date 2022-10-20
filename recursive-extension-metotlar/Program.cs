using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // rekürsif - öz yineleme
            // 3^4

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
                
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension metotlar
            string ifade = "Büşra Akay";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {9, 3, 6, 2, 1, 5, 0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayim = 5;
            Console.WriteLine(sayim.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstChracter());
            

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us){
            if(us < 2){
                return sayi;
            }
            return Expo(sayi, us-1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param){
            
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param){
            return param %2 == 0;
        }

        public static string GetFirstChracter(this string param){
            return param.Substring(0, 1);
        }
    }
}
