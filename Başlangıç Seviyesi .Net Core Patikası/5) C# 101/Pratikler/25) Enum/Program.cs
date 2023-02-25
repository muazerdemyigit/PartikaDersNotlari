namespace _25__Enum;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Cumartesi);//integer'a cast işlemi ile onun nümerik değerine erişebiliriz.

        int sıcaklık = 32;

        if (sıcaklık <= (int)HavaDurumu.Normal)
        {
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
        }
        else if (sıcaklık >= (int)HavaDurumu.Sıcak)
        {
            Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
        }
        else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
        {
            Console.WriteLine("Hadi dışarı çıkalım.");
        }


    }
}
enum Gunler
{
    Pazartesi = 1,//Günler enum'ının pazartesi üyesi ve indeksi 0. Indeksi 1 yaparsak diğerleri de ardışık olarak 1den itibaren devam eder.
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,//Cuma 23 dersek sonrakiler ardışık olarak 24'den devam eder.
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sıcak = 25,
    CokSıcak = 30
}