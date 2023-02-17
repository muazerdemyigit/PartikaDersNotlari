namespace _13__Metotlar_Overloading;
class Program
{
    static void Main(string[] args)
    {
        //*********************
        //Out parametre: Bir fonksiyona bir iş yaptırıp onun sonucunda bir değerin set'lemesini istiyorsak ve o setlediği şeyi de kullanmak istiyorsak kullanabiliriz.

        string sayi = "999";
        //Normalde int değeri string değerden kullanmak için Parse ediyoruz. Ancak bu işlemin başarılı yapılıp yapılmadığını kontrol altına alamak isteyebiliriz. Bunun için TryParse metotu kullanılır.

         bool sonuc = int.TryParse(sayi, out int outSayi);//git sayıyı çevirip çeviremediğine bak ve sonucunda da çevirebiliyorsan çevirdiğin sayıyı bana out'tan sonra yazdığım şekilde bana geri döndür.

        if (sonuc)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız");
        }

        //*********************


        //*********************

        Metotlar instance = new Metotlar();
        instance.Topla(4, 5, out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //*********************


        //*********************

        //Metot Aşırı Yükleme - Overloading

        //Bir fonksiyonun imzasını değiştirerek birden fazla şekilde o fonksiyonu kullanabiliriz.
        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);// EkranaYazdır ilk başta string veri alıyordu ve int veri kullanmak için parse işlemi yapılmalıydı. Ancak şimdi metot overload edilerek hem string değer alan hem de int değer alan iki aynı isimde metot oluşturduk ve parse işlemi yapmamıza gerek kalmadı.

        //Bu işleme metot imzasına göre karar veriyor.
        /*
            Metot İmzası = metotAdı + parametre sayisi + parametre

            Metot İmzası yalnızca yukarıdaki üç parametre de aynıysa aynı olur bu parametrelerden birisi değişince metot imzası değişeceği için overloading yapmış oluruz.
        */
        instance.EkranaYazdir("Muaz","Yiğit");
    }
}

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2)//Aldığı iki veriyi birleştirip ekrana yazdıran metot.
    {
        Console.WriteLine(veri1+veri2);
    }
}
