namespace _2__Üçgen_Çizme;
class Program
{
    static void Main(string[] args)
    {
        /*
        Algoritma
            Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.

            Dikkat Edilmesi Gereken Noktalar :

            - Kod tekrarından kaçınılmalı
            - Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
        */

        Actions action = new Actions();

        Console.WriteLine("Lütfen boyut bilgisi giriniz.");
        int boyut = int.Parse(Console.ReadLine());

        action.Ucgen(boyut);
    }
}
