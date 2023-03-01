public class Kare
{
    public static void KareAlan(int uzunluk)
    {
        double kareAlan= uzunluk * uzunluk;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Kare'nin alanı: {0}", kareAlan);
    }

    
    public static void KareCevre(int uzunluk)
    {
        double kareCevre = uzunluk * 4;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Kare'nin çevresi: {0}", kareCevre);
    }

}