using System.Collections;
using System.Collections.Generic;

namespace _18__ArrayList;
class Program
{
    static void Main(string[] args)
    {
        //ArrayList'in içine birden fazla veri tipi saklanabilir ve büyüyüp küçülebilir.
        //Namespace olarak System.Collections altında bulunur.

        ArrayList liste = new ArrayList();
        //*************************

        //liste.Add("Ayşe");
        //liste.Add(2);
        //liste.Add(true);
        //liste.Add('A');

        //*************************


        //*************************

        //içerisindeki verilere erişme

        //Console.WriteLine(liste[1]);

        //foreach (var item in liste)
        //{
        //  Console.WriteLine(item);
        //}

        //*************************


        //*************************

        //AddRange birden fazla elemanı toplu halde ekleme
        Console.WriteLine("******** Add Range ********");
        //string[] renkler = {"kırmızı", "sarı", "yeşil"};
        List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
        //liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //*************************


        //*************************

        //Sort - Sıralama

        Console.WriteLine("****** Sort *******");
        liste.Sort();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //*************************


        //*************************

        //Binary Search

        Console.WriteLine("****** Binary Search ******");
        Console.WriteLine(liste.BinarySearch(9));

        //*************************


        //*************************

        //Reverse

        Console.WriteLine("****** Reverse ******");
        liste.Reverse();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //*************************


        //*************************

        //Clear
        Console.WriteLine("****** Clear ******");

        liste.Clear();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //*************************

    }
}
