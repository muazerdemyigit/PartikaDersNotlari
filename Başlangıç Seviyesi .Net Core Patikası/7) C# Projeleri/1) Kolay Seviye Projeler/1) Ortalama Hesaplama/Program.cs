namespace _1__Ortalama_Hesaplama;
class Program
{
    static void Main(string[] args)
    {
        /*
        Ortalama Hesaplama:
            Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

            Dikkat Edilmesi Gereken Noktalar :

            - Kod tekrarından kaçınılmalı
            - Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
        */

        Actions action = new Actions();
        Console.WriteLine("Lütfen bir pozitif tam sayı giriniz.");
        int deger = int.Parse(Console.ReadLine());
        if (deger > 0)
        {

        }
        else
        {
            Console.WriteLine("Hatalı değer girdiniz. Lütfen pozitif bir tam sayı giriniz.");
        }
        action.Fibo(deger);
    }
}
