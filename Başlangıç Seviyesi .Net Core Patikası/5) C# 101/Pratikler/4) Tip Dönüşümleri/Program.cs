namespace _4__Tip_Dönüşümleri;
class Program
{
    static void Main(string[] args)
    {
        /* 
        İki Tip Dönüşüm vardır;

        1) Implicit Conversion (Bilinçsiz Dönüşüm) : Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanma işlemi.

        2) Explicit Conversion (Bilinçli Dönüşüm) : Bilinçli olarak yapılan dönüşümlerdir. C#'ın kendi kendine yapamadığı dönüşümlerdir, bizim dahil olmamız gereken dönüşümlerdir.

        */

        //***************************************

        //Implicit Conversion (Bilinçsiz Dönüşüm)

        Console.WriteLine("******************Implicit Conversion*******************");

        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a + b + c;
        Console.WriteLine("d:" + d);

        long h = d;
        Console.WriteLine("h:" + h);

        float i = h;
        Console.WriteLine("i:" + i);

        string e = "muaz";
        char f = 'k';
        object g = e + f + d;
        Console.WriteLine("g:" + g);
        //Arada bir kapasite uyumsuzluğu olsaydı, d daha küçük kapasiteli bir değişken olsaydı bu atama işlemi yapılamazdı.

        //***************************************


        //***************************************

        //Explicit Conversion (Bilinçli Dönüşüm)

        Console.WriteLine("******************Explicit Conversion*******************");

        int x = 4;
        byte y = (byte)x;//parantez içine hedef veri tipini yazarak parantezin sağındaki veriyi içindeki veri tipine dönüştürmeye çalışır.
        Console.WriteLine("y:" + y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" + t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v:" + v);



        // *****ToString Metodu*****
        Console.WriteLine("*****ToString Metodu*****");

        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" + yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz:" + zz);


        // *****System.Convert Metodu*****
        Console.WriteLine("*****System.Convert Sınıfı*****");

        string s1 = "10", s2 = "20";
        int sayi1, sayi2;
        int Toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);
        Toplam = sayi1 + sayi2;

        Console.WriteLine("Toplam:" + Toplam);


        // *****Parse Methodu*****

        //String ifadeleri dönüştürmek için kullanılır ve her zaman string alır. 
        Console.WriteLine("*****Parse Methodu*****");

        ParseMethod();

        //***************************************
    }
    public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10,25";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1);
        double1 = Double.Parse(metin2);
        Console.WriteLine("rakam1:" + rakam1);
        Console.WriteLine("double1:" + double1);
    }
}
