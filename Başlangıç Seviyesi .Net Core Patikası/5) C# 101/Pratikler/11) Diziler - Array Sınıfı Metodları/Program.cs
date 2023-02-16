namespace _11__Diziler___Array_Sınıfı_Metodları;
class Program
{
    static void Main(string[] args)
    {
        // Array sınıfının bize sunmuş olduğu birden fazla metod var. Şimdi sırayla bu metodlara bakalım.

        //*************************

        //Sort(sıralama işlemi)

        int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

        Console.WriteLine("***Sırasız Dizi***");

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("***Sıralı Dizi***");

        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }


        //*************************


        //*************************

        //Clear(Dizi içerisinde verilen indexten başlayarak verilen eleman sayısı kadar değeri sıfırlar)

        Console.WriteLine("***Array Clear***");

        Array.Clear(sayiDizisi, 2, 2);//sayiDizisi'nde 2.indexten başlayarak 2 elemanı 0 yapar.
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //*************************


        //*************************

        //Reverse(Tersine Çevirme İşlemi, verilen diziyi ortadan itibaren aynalıyormuş gibi yer değiştiriyor.)

        Console.WriteLine("***Array Reverse***");

        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //*************************


        //*************************

        //IndexOf(verilen dizi üzerinde verilen elemanın indexini döner.)

        Console.WriteLine("***Array IndexOf***");

        Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
       
        //*************************


        //*************************

        //Resize(Yeniden boyutlandırma yapar.)
          Console.WriteLine("***Array Resize***");
          Array.Resize<int>(ref sayiDizisi,9);//int tipinde referans olarak sayiDizisi arrayinin boyutunu 9 yap.
          sayiDizisi[8] = 99;//sayiDizisinin 8.indexi yani 9. elemanını 99 yap.
        
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

    }
}
