namespace _8__For_Loop_ve_Break_Continue_Ifadeleri;
class Program
{
    static void Main(string[] args)
    {
        //Belirli bir kod bloğunun belirli şartlara bağlı kalarak birden fazla kez çalışmasını istiyorsak For Loop kullanıyoruz.

        /*
        for (int i = 0; i < length; i++)//i sıfırdan başlayarak ve her döngü içinde i'yi bir artırarak length'den küçük olduğu sürece çalış.
        {
            //komutlar
        }
        */

        //*********************************

        //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.

        Console.Write("Lütfen bir sayı giriniz:");
        int sayac = int.Parse(Console.ReadLine());
        for (int j = 0; j <= sayac; j++)
        {
            if (j % 2 == 1)
            {
                Console.WriteLine(j);
            }
        }

        //*********************************



        //*********************************

        //1 ile 1000 tek ve çeift sayıların toplamını hesaplayıp ekrana yazdır.

        int tekToplam = 0;
        int ciftToplam = 0;

        for (int k = 1; k <= 1000; k++)
        {
            if (k % 2 == 1)
            {
                tekToplam += k;
            }
            else
            {
                ciftToplam += k;
            }

        }
        Console.WriteLine("Tek toplam = " + tekToplam);
        Console.WriteLine("Çift toplam = " + ciftToplam);

        //*********************************


        //*********************************

        //break: Eğer bir döngü içerisinde bir case'ye bağlı olarak loop'tan çıkmak isteniyorsa kullanılır. Yani bütün döngüden çıkar.
        //continue: Eğer bir şarta bağlı olarak mevcut döngünün sadece o bloğunun atlanması isteniyorsa kullanılır. Yani istenilen döngü adımını atlar.

        for (int m = 1; m < 10; m++)
        {
            if (m==4)
            {
                break;
            }
            Console.WriteLine(m);

        }
         for (int n = 1; n < 10; n++)
        {
            if (n==4)
            {
                continue;
            }
            Console.WriteLine(n);

        }

        //*********************************
    }
}
