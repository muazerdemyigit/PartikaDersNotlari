namespace _6__If_ElseIf_Ternary_If;
class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if (time >= 6 && time < 11)//eğer time 6 ile 11 arasındaysa buraya girer
        {
            Console.WriteLine("Günaydın");
        }

        else if (time >= 11 && time < 18)//eğer time 11 ile 18 arasındaysa buraya girer
        {
            Console.WriteLine("Tünaydın");
        }
        else//18den büyükse buraya girer
        {
            Console.WriteLine("İyi Geceler");
        }

        string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";//time 18 den küçük eşitse iyi günler, değilse iyi geceler yaz. ? ise, : değilse anlamına geliyor.

        sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);
    }
}
