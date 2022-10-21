### Ödev 1
1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
```c#
    public static void Task1(){
        
        Console.WriteLine("Bir sayi giriniz:");
        int n = int.Parse(Console.ReadLine());
        
        int[] dizi = new int[n];
        Console.WriteLine("Girdiginiz sayi kadar pozitif sayilar giriniz: ");
        for(int i = 0; i < n; i++){
            dizi[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine ("Pozitif elemanlar: ");
        for(int i = 0; i < n; i++){
            if(dizi[i] %2 ==0){
                Console.WriteLine (dizi[i] + " ");
            }
        }
    }
```

2. Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
```c#
    public static void Task2(){
        Console.WriteLine ("Iki adet sayi giriniz:(n, m)");
        Console.WriteLine ("n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine ("m:");
        int m = int.Parse(Console.ReadLine());
        
        int[] dizi = new int[n];
        Console.WriteLine ("n kadar pozitif sayilar giriniz: ");
        for(int i = 0; i < n; i++){
            dizi[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine ("Girmis oldugunuz sayilardan m'e esit ya da tam bolunenler: ");
        for(int i = 0; i < n; i++){
            if(dizi[i] == m || dizi[i] %m == 0){
                Console.WriteLine (dizi[i] + " ");
            }
            
        }
        
    }
```

3. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
```c#
    public static void Task3(){
        Console.WriteLine("Bir sayi giriniz:");
        int n = int.Parse(Console.ReadLine());
        
        string[] dizi = new string[n];
        Console.WriteLine("Girdiginiz sayi kadar kelime giriniz: ");
        for(int i = 0; i < n; i++){
            dizi[i] = Console.ReadLine();
        }
        Array.Reverse(dizi);
        Console.WriteLine("Girdiginiz kelimelerin tersten siralanisi: ");
        foreach(var kelime in dizi){
            Console.WriteLine(kelime + " ");
        }    
    }
```

3. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
```c#
    public static void Task4(){
        Console.WriteLine("Bir cumle giriniz:");
        string cumle = Console.ReadLine();
        int harfSayisi = 0;
        for(int i = 0; i < cumle.Length; i++){
            if(cumle[i] == ' '){
                continue;
            }
            harfSayisi++;
        }
        Console.WriteLine("Cumledeki harf sayisi: " + harfSayisi);
        string[] kelimeler = cumle.Split(' ');
        Console.WriteLine("Cumledeki kelime sayisi: " + kelimeler.Length);
    }
```



```c#

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        Task4();
        
        
        
    }
    
    public static void Task1(){
        
        Console.WriteLine("Bir sayi giriniz:");
        int n = int.Parse(Console.ReadLine());
        
        int[] dizi = new int[n];
        Console.WriteLine("Girdiginiz sayi kadar pozitif sayilar giriniz: ");
        for(int i = 0; i < n; i++){
            dizi[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine ("Pozitif elemanlar: ");
        for(int i = 0; i < n; i++){
            if(dizi[i] %2 ==0){
                Console.WriteLine (dizi[i] + " ");
            }
        }
    }
    
    public static void Task2(){
        Console.WriteLine ("Iki adet sayi giriniz:(n, m)");
        Console.WriteLine ("n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine ("m:");
        int m = int.Parse(Console.ReadLine());
        
        int[] dizi = new int[n];
        Console.WriteLine ("n kadar pozitif sayilar giriniz: ");
        for(int i = 0; i < n; i++){
            dizi[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine ("Girmis oldugunuz sayilardan m'e esit ya da tam bolunenler: ");
        for(int i = 0; i < n; i++){
            if(dizi[i] == m || dizi[i] %m == 0){
                Console.WriteLine (dizi[i] + " ");
            }
            
        }
        
    }
    
    public static void Task3(){
        Console.WriteLine("Bir sayi giriniz:");
        int n = int.Parse(Console.ReadLine());
        
        string[] dizi = new string[n];
        Console.WriteLine("Girdiginiz sayi kadar kelime giriniz: ");
        for(int i = 0; i < n; i++){
            dizi[i] = Console.ReadLine();
        }
        Array.Reverse(dizi);
        Console.WriteLine("Girdiginiz kelimelerin tersten siralanisi: ");
        foreach(var kelime in dizi){
            Console.WriteLine(kelime + " ");
        }    
    }
    
    public static void Task4(){
        Console.WriteLine("Bir cumle giriniz:");
        string cumle = Console.ReadLine();
        int harfSayisi = 0;
        for(int i = 0; i < cumle.Length; i++){
            if(cumle[i] == ' '){
                continue;
            }
            harfSayisi++;
        }
        Console.WriteLine("Cumledeki harf sayisi: " + harfSayisi);
        string[] kelimeler = cumle.Split(' ');
        Console.WriteLine("Cumledeki kelime sayisi: " + kelimeler.Length);
    }
}

```


