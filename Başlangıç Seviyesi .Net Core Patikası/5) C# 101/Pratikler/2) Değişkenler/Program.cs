namespace _2__Değişkenler;
class Program
{
    static void Main(string[] args)
    {
        int deger;
        deger = 2;
        Console.WriteLine(deger);

        //Değişken isimleri büyük küçük hard duyarlıdır.
        int Deger = 3;
        Console.WriteLine(Deger);

        //Değişken adları rakamla başlayamaz. örn int 3degisken = 6; yanlış bir kullanım.

        // Aynı kod bloğu içerisinde aynı değişken birden fazla kez tanımlanamaz.


        //***************************************
        byte b = 5;        // 1 byte
         Console.WriteLine(b);
        sbyte c = 5;       // 1 byte
         Console.WriteLine(c);

        short s = 5;       // 2 byte
         Console.WriteLine(s);
        ushort us = 5;     // 2 byte
         Console.WriteLine(us);

        Int16 i16 = 2;     // 2 byte
         Console.WriteLine(i16);
        int i = 2;         // 4 byte
         Console.WriteLine(i);
        Int32 i32 = 2;     // 4 byte
         Console.WriteLine(i32);
        Int64 i64 = 2;     // 8 byte
         Console.WriteLine(i64);

        uint ui = 2;       // 4 byte
         Console.WriteLine(ui);
        long l = 4;        // 8 byte
         Console.WriteLine(l);
        ulong ul = 4;      // 8 byte
         Console.WriteLine(ul);
        
        //***************************************


        // reel sayılar

        //***************************************
        float f = 5;       // 4 byte - reel sayılar
         Console.WriteLine(f);
        double d = 5;      // 8 byte
         Console.WriteLine(d);
        decimal dc = 5;    // 16 byte
         Console.WriteLine(dc);

        char ch = '2';     // 2byte
         Console.WriteLine(ch);
        string str = "Muaz"; //sınırsız
         Console.WriteLine(str);

        bool b1 = true;
         Console.WriteLine(b1);
        bool b2 = false;
         Console.WriteLine(b2);

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        //***************************************



        // string ifadeler

        //***************************************
        string str1 = string.Empty;
        str1 = "Muaz Yiğit";
        string ad = "Muaz";
        string soyad = "Yiğit";
        string tamIsim = ad + " " + soyad;

        //***************************************



        // integer tanımlama şekilleri

        //***************************************
        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        //***************************************



        //boolen
        //***************************************

        bool boll1 = 10 > 2;
         Console.WriteLine(boll1);

        //***************************************



        // Değişken dönüşümleri

        //***************************************

        string str20 = "20";
        int int20 = 20;

        string yeniDeger = str20 + int20.ToString();

        Console.WriteLine(yeniDeger); //çıktısı 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); //çıktısı 40

        int int22 = int20 + int.Parse(str20); // çıktısı 40

        //***************************************



        //datetime

        //***************************************
        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);

        //***************************************



        //saat

        //***************************************

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);

        //***************************************
    }
}
