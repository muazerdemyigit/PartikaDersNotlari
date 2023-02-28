namespace _3__Daire_Çizme;

public class Actions
{
    public void Daire(int radius)
    {
        for (double i = -radius; i < radius; i++)
        {
            for (double j = -radius; j < radius; j += 0.5)
            {
                if ((j * j) + (i * i) >= radius * radius)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
    }
}