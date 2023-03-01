public class Ucgen
{
    public static void UcgenAlan(int taban, int yukseklik)
    {
        double ucgenAlan = (taban * yukseklik) / 2;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Üçgen'in alanı: {0}", ucgenAlan);
    }
    public static void UcgenCevre(int kenar1, int kenar2, int taban)
    {
        double ucgenCevre = kenar1 + kenar2 + taban;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Üçgen'in çevresi: {0}", ucgenCevre);
    }
}