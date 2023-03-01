public class Daire
{
    public static void DaireAlan(double yaricap)
    {
        double daireAlan = Math.PI * yaricap * yaricap;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Daire'nin alanı: {0}", daireAlan);
    }


    public static void DaireCevre(double yaricap)
    {
        double daireCevre = 2 * Math.PI * yaricap;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Daire'nin çevresi: {0}", daireCevre);
    }


    public static void DaireHacim(double yaricap)
    {
        double daireHacim = (4 / 3) * Math.PI * yaricap * yaricap * yaricap;
        Console.WriteLine("Girmiş olduğunuz bilgilere görer Daire'nin hacmi: {0}", daireHacim);
    }
}