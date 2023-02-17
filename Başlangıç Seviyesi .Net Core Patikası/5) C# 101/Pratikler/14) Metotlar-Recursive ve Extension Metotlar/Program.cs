namespace _14__Metotlar_Recursive_ve_Extension_Metotlar;
class Program
{
    static void Main(string[] args)
    {
        //*******************

        //Rekürsif- Öz Yinelemeli fonksiyon: Kendi kendini çağıran fonksiyon. 

        //3^4'ün hesaplamasını yapan kodlar;

        //For ile
        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result = result * 3;
        }
        Console.WriteLine(result);

        //Rekürsif ile
        Islemler instance = new Islemler();
        Console.WriteLine(instance.Expo(3, 4));

        //*******************


        //*******************

        //Extension Metotlar
        //Extension classlar ve Extension metotlar static olmalı static olmazsa bunlara erişilemez.
        string ifade = "Muaz Erdem Yiğit";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if (sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
        }


        int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.IsEvenNumber());

        Console.WriteLine(ifade.GetFirstCharacter());

    }
}

public class Islemler
{
    public int Expo(int sayi, int us)
    {
        if (us < 2)
        {
            return sayi;
        }
        return Expo(sayi, us - 10) * sayi;
    }
}

public static class Extension
/*
-> Verdiğim cümle içerisinde boşluk olup olmadığını dönen bir extension method. 

-> Boşluk varsa bu boşluğu değiştiren bir extension method. 

-> Verilen ifadeyi büyük harfe çeviren bir extension method. 

-> Verilen ifadeyi küçük harfe çeviren bir extension method. 

-> Dizi elemanlarını sıralayan extension method.

-> int diziyi ekrana yazdıran extension method.

-> Verilen int sayının çift olup olmadığını ekrana yazan extension method.

-> Verilen stringin ilk karakterini kesip bana geriten extension method.
*/
{
    public static bool CheckSpaces(this string param)//boşluk bul.
    {
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");//bu diziyi boşluklara göre ayır ve diziye al.
        return string.Join("", dizi);//join ile diziyi "" ile değiştir.
    }

    public static string MakeUpperCase(this string param)//büyük harfe çevir.
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)//küçük harfe çevir.
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)//Dizi elemanlarını sırala
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param)//Diziyi ekrana yazdır.
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEvenNumber(this int param)//çift mi sayı
    {
        return param % 2 == 0;
    }
    public static string GetFirstCharacter(this string param)///ilk karakteri dön
    {
        return param.Substring(0,1);
    }
}

