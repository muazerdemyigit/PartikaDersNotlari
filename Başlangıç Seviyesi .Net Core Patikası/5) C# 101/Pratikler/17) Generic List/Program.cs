using System.Collections.Generic;
namespace _17__Generic_List;
class Program
{
    static void Main(string[] args)
    {
        //List<T> class syntax'ı
        //System.Collections.Generic namespace'si altından geliyor.
        //T-> object türündedir. Listenin içindeki nesnelerin tipini belirtiyor.

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);



        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");


        //Count liste içerisinde kaç eleman olduğunu söyler.
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //ForEach ve List.ForEach ile elemanlara erişim
        foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }
        foreach (var renk in renkListesi)
        {
            Console.WriteLine(renk);
        }


        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));


        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Liste içerisinde arama

        if (sayiListesi.Contains(10))
        {
            Console.WriteLine("10 liste içerisinde bulundu");
        }


        //Eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        //Diziyi List'e çevirme
        string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
        List<string> hayvanlarListesi = new List<string>(hayvanlar);

        //Listeyi temizleme
        hayvanlarListesi.Clear();


        //Liste içerisinde nesne tutmak
        List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

        Kullanıcılar kullanıcı1 = new Kullanıcılar();
        kullanıcı1.Isim = "Ayşe";
        kullanıcı1.SoyIsim = "Yılmaz";
        kullanıcı1.Yas = 26;

        Kullanıcılar kullanıcı2 = new Kullanıcılar();
        kullanıcı2.Isim = "Özcan";
        kullanıcı2.SoyIsim = "Çalışkan";
        kullanıcı2.Yas = 35;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);


        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
        yeniListe.Add(new Kullanıcılar()
        {
            Isim = "Deniz",
            SoyIsim = "Arda",
            Yas = 24,
        });

        foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
        {
            Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.SoyIsim);
            Console.WriteLine("Kullanıcı Yaş: " + kullanıcı.Yas);
        }
    }
}

public class Kullanıcılar
{
    private string isim;
    private string soyIsim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string SoyIsim { get => soyIsim; set => soyIsim = value; }
    public int Yas { get => yas; set => yas = value; }

}
