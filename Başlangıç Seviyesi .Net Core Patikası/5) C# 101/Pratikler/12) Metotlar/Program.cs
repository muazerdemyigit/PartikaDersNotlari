namespace _12__Metotlar;
class Program
{
    static void Main(string[] args)
    {
        /*
       erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
           {
               komutlar;
               return;
           }
       */

        //************************

        //erisim_belirteci ile bu metota kimlerin nereden erişebileceğini söylemiş oluyoruz.

        //geri_donustipi ile bu metot bir iş yaptıktan sonra geriye bir şey dönecek mi, çağırıldığı yerden bir şeye ihtiyaç duyuyor mu? Burada her türlü veri tipi dönülebilir. Her metotun geri dönüş tipi olmak zorunda değil. Geri dönüş tipi olmadığını söylemek için void yazmalıyız.

        //metot_adi bu metotun ismi.

        //parametreListesi bu metotun iş yaparken kullanacağı parametreler. Diğer adı argüman'dır.

        //return geri dönüş yapmak istiyorsak kullanıyoruz.

        //************************

        //Bulunduğunuz class dışında başka bir class'daki metota erişmek için o classın bir instance'sini yaratıp o instance aracılığı ile metota erişmeniz gerekli.

        //************************

        //iki sayıyı toplayan metot
        int a = 2;
        int b = 3;
        Console.WriteLine(a + b);

        int sonuc = Topla(a, b);
        Console.WriteLine(sonuc);

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));


        int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc2));
        ornek.EkranaYazdir(Convert.ToString(a + b));

    }
    static int Topla(int deger1, int deger2)//call by value ile oluşmuş olan değer tipli değişkenler sadece bulunduğu fonksiyondan erişilebilir ve o fonksiyon ile birlikte silinir.
    {
        return (deger1 + deger2);
    }
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttırVeTopla(ref int deger1, ref int deger2)//değer tipli değişkenlerin referanslarını almak için ref anahtar kelimesi kullannılır. Referans verince bu değişkenlerin değerlerini değil de bellekteki karşılıklarını iletmiş oluyoruz. Dolayısıyla referanslar üzerinde değişiklik yapılmış olur.
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }
}
