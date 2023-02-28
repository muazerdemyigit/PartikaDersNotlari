namespace _2__Üçgen_Çizme;

public class Actions
{
    public void Ucgen(int boyut)
    {
        Console.WriteLine("Çizilen Üçgen : ");
        for (int i = 0; i < boyut; i++)
        {
            Console.Write("\n");
            for (int j = i; j < boyut; j++)
            {
                Console.Write("*");
            }
        }

    }
}
