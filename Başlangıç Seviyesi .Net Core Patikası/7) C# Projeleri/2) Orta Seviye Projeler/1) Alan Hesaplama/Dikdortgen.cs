public class Dikdortgen
{
    public static void DikdortgenAlan(int kisaKenar, int uzunKenar)
    {
        double dikdortgenAlan = kisaKenar * uzunKenar;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Dikdörtgen'in alanı: {0}", dikdortgenAlan);

    }
    public static void DikdortgenCevre(int kisaKenar, int uzunKenar)
    {
        double dikdortgenCevre = 2 * (kisaKenar + uzunKenar);
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Dikdörtgen'in çevresi: {0}", dikdortgenCevre);
    }

}