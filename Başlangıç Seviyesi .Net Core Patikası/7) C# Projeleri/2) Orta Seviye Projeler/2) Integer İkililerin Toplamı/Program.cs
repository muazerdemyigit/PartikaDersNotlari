namespace _2__Integer_İkililerin_Toplamı;
class Program
{
    static void Main(string[] args)
    {
        /*
        Algoritma
            Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

            Örnek Input: 2 3 1 5 2 5 3 3

            Output: 5 6 7 81
        */

        System.Console.WriteLine("Lütfen çift sayılı olacak şekilde değerler giriniz:");

        int deger = Convert.ToInt32(Console.ReadLine());
        int[] degerListesi = new int[deger];
        int sonuc = 0;

        if (deger % 2 == 0)
        {
            for (int i = 0; i < deger; i++)
            {
                Console.WriteLine("{0}. sayınızı giriniz: ", i + 1);
                degerListesi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < degerListesi.Length - 1; i++)
            {
                if (degerListesi[i] == degerListesi[i + 1])
                {
                    sonuc = (degerListesi[i] + degerListesi[i + 1]) * (degerListesi[i] + degerListesi[i + 1]);

                }
                else
                {
                    sonuc = degerListesi[i] + degerListesi[i + 1];
                }
            }
            System.Console.WriteLine(sonuc);
        }
        else
        {
            System.Console.WriteLine("Çift sayılı olacak şekilde değer girmediniz.");
        }
    }
}
