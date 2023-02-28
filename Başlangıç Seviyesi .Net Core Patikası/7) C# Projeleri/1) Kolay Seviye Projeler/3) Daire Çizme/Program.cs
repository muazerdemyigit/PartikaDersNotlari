namespace _3__Daire_Çizme;
class Program
{
    static void Main(string[] args)
    {
        /*
        Şekil Çizimi
            Kullanıcıdan alınan yarıçapa göre console'a Daire çizen uygulamayı yazınız.

            Dikkat Edilmesi Gereken Noktalar :

            - Kod tekrarından kaçınılmalı
            - Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
        */
        Actions actions = new Actions();
        Console.WriteLine("Lütfen Yarıçap değeri giriniz.");
        int radius = int.Parse(Console.ReadLine());

        actions.Daire(radius);
    }
}
