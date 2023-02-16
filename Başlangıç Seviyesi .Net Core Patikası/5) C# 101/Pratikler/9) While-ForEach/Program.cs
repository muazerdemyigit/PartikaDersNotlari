namespace _9__While_ForEach;
class Program
{
    static void Main(string[] args)
    {
        //*********************

        //While
        /*
        while (true)//Buradaki ifade true olduğu sürece {} arasındaki komutları tekrar ediyor.
        {

        }
        */

        //*********************

        // 1'den başlayarak console'dan girilen sayıya kadar, sayı dahil, ortalama hesaplayıp console'a yazdır.
        Console.Write("Lütfen Bir Sayı Giriniz:");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;

        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }
        Console.WriteLine(toplam / sayi);

        //*********************


        //*********************

        //a'dan z'ye kadar tüm harfleri console'a yazdır.

        char character = 'a';
        while (character < 'z')
        {
            Console.Write(character);
            character++;
        }

        //*********************


        //*********************

        //ForeEach

        /*
         foreach (var item in collection) // collenction içindeki itemlerin her birine işlem yapmamızı sağlar.
         {

         }
        */

        //*********************


        //*********************


        string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }

        //*********************
    }
}
