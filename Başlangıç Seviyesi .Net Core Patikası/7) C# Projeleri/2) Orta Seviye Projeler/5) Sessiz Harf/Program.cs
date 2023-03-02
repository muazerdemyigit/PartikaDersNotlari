namespace _5__Sessiz_Harf;
class Program
{
    static void Main(string[] args)
    {
        /*
        Algoritma
            Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

            Örnek: Input: Merhaba Umut Arya

            Output: True False True
        */
        System.Console.WriteLine("Lütfen bir metin giriniz:");
        string metin = Console.ReadLine();

        string[] kelimeler = metin.Split(' ');
        string unsuzler = "bcdfghjklmnpqrstvwxyz";

        foreach (var item in kelimeler)
        {
            bool ardisikUnsuz = false;
            for (int i = 0; i < item.Length - 1; i++)
            {
                if (unsuzler.Contains(item[i]) && unsuzler.Contains(item[i + 1]))
                {
                    ardisikUnsuz = true;
                    break;
                }
            }
            System.Console.WriteLine(ardisikUnsuz + " ");
        }
        System.Console.WriteLine();
    }
}
