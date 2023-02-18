using System.Collections.Generic;
namespace _19__Dictionary;
class Program
{
    static void Main(string[] args)
    {
        //system.collection.generic namespace'i altındadır.
        Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

        kullanıcılar.Add(10, "Ayşe Yılmaz");
        kullanıcılar.Add(12, "Ahmet Yılmaz");
        //kullanıcılar.Add(10, "Ayşe Yılmaz"); //eğer aynı key değerine sahipse runtime error verir. Compile time'de hata vermez dikkatili olmak lazım.
        //kullanıcılar.Add(12, "Ahmet Yılmaz");
        kullanıcılar.Add(18, "Deniz Arda");
        kullanıcılar.Add(20, "Özcan Coşar");


        //Dizinin elemanlarına erişim
        Console.WriteLine("***** Elemanlara Erişim *****");

        Console.WriteLine(kullanıcılar[12]);//kullanıcılarda 12 key'ine sahip veriyi getir.

        foreach (var item in kullanıcılar)//tüm elemanları yazar.
        {
            Console.WriteLine(item);
        }

        //Count
        Console.WriteLine("***** Count *****");
        Console.WriteLine(kullanıcılar.Count);

        //Contains
        Console.WriteLine("***** Contains *****");
        Console.WriteLine(kullanıcılar.ContainsKey(12));
        Console.WriteLine(kullanıcılar.ContainsValue("Muaz Erdem Yiğit"));

        //Remove
        Console.WriteLine("***** Remove *****");
        kullanıcılar.Remove(12);
        foreach (var item in kullanıcılar)
        {
            Console.WriteLine(item);
        }

        //Keys
        Console.WriteLine("***** Keys *****");//kullanıcılar.Keys ile sadece keyler üzerinde işlem yapılabilir.
        foreach (var item in kullanıcılar.Keys)
        {
            Console.WriteLine(item);
        }

        //Values
        Console.WriteLine("***** Values *****");//kullanıcılar.Values ile sadece keyler üzerinde işlem yapılabilir.
        foreach (var item in kullanıcılar.Values)
        {
            Console.WriteLine(item);
        }
    }
}
