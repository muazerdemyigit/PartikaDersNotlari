namespace _23__Static_Sınıf_ve_Üyeler;
class Program
{
    static void Main(string[] args)
    {
        //Bir sınıf içerisindeki static olmayan fieldlara/metotlara/özelliklere o sınıftan oluşturduğumuz nesne aracılığıyla erişiyoruz. Static olan elemanlara ise o sınıfın adıyla erişiyoruz yani bir nesne oluşturmamıza gerek yok ki zaten oluşturamayız o sınıfın adı nokta erişmek istediğimiz metot/özellik diyerek erişebiliriz.(sınıfAdi.Ozellik)
        //Static olmayan classlarda static olmayan elemanlar o sınıf içerisinde nesneye özel set ve get'leniyorken, bir sınıf içerisinde static olan üyeler sınıf bazında atanır. 

        //Static sınıfların içerisinde static olmayan herhangi bir metot/property kullanamayız.
        //Static sınıflara kalıtım işlemi uygulunamaz.

        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan = new Calisan("Ayşe", "Yılmaz", "İK");

        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Calisan calisan1 = new Calisan("Deniz", "Arda", "İK");

        Calisan calisan2 = new Calisan("Muaz", "Yiğit", "İK");
        Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

        Console.WriteLine("Toplama işleminin sonucu: {0}", Islemler.Topla(100, 200));
        Console.WriteLine("Çıkarma işleminin sonucu: {0}", Islemler.Cıkar(400, 50));


    }
}
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isım;
    private string Soyisim;
    private string Departman;

    static Calisan()//static kurucuların geri erişim belirteci yoktur.
    {
        calisanSayisi = 0;
    }

    public Calisan(string ısım, string soyisim, string departman)
    {
        this.Isım = ısım;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cıkar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}