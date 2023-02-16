namespace _10__Diziler;
class Program
{
    static void Main(string[] args)
    {
        // Aynı tipteki değişkenleri bellekte arka arkaya saklamak için diziler kullanılır.
        // Diziler sıfırıncı indexten başlar.

        //*****************************

        //Dizi Tanımlama

        string[] renkler = new string[5];// 5 tane elemanı olan ve elemanları string olan renkler isimmli bir dizi tanımladık.

        string[] hayvanlar = { "köpek", "kedi", "kuş", "maymun" };// Dizinin elemanları da belliyse böyle tanımlanıyor. 

        int[] dizi;
        dizi = new int[5]; //Dizi tanımlarken boyutunu da elemanlarını da vermek zorunda değiliz sonradan verilebilir.

        //*****************************


        //*****************************

        //Dizilere Değer Atama Ve Erişim

        renkler[0] = "Mavi";// Renkler dizisinin sıfırınıcı elemanına mavi bilgisini atadık.
        Console.WriteLine(hayvanlar[0]);//Hayvanlar dizisindeki sıfırıncı elemana eriştik.
        dizi[3] = 10;//dizinin 3. elemanına 10 değerini atadık.

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //*****************************


        //*****************************

        //Döngülerle Dizi Kullanımı


        //Klavyeden girilen n tane sayının ortalamasını alan program.

        Console.Write("Lütfen dizinin eleman sayısını giriniz:");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lütfen {0}. sayıyı giriniz:", i + 1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }

        Console.WriteLine("Ortalama : "+ toplam/diziUzunlugu);


        //*****************************
    }
}
