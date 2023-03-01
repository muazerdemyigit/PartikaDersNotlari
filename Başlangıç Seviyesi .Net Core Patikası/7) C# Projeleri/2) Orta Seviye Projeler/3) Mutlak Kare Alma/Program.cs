namespace _3__Mutlak_Kare_Alma;
class Program
{
    static void Main(string[] args)
    {
        /*
        Algoritma
            Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

            Örnek: Input: 56 45 68 77

            Output: 33 101
        */
        System.Console.WriteLine("Kaç adet sayı gireceksiniz?");
        int sayi = int.Parse(Console.ReadLine());

        int[] sayilar = new int[sayi];

        int kucuk = 0;
        int buyuk = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            System.Console.WriteLine("{0}. sayıyı giriniz.", i + 1);
            sayilar[i] = int.Parse(Console.ReadLine());
            if (sayilar[i] < 67)
            {
                kucuk += 67 - sayilar[i];
            }
            else
            {
                buyuk += (67 - sayilar[i]) * (67 - sayilar[i]);
            }
        }

        System.Console.WriteLine("Küçük olanların toplamı = {0}\n Büyük olanların toplamı = {1}", kucuk, Math.Abs(buyuk));

    }
}
