namespace _1__Ortalama_Hesaplama;
public class Actions
{

    public void Fibo(int derinlik)
    {
        int[] fibo = new int[derinlik];
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < derinlik; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        int ortalama = fibo.Sum() / fibo.Length;
        Console.WriteLine("Fibonacci serisindeki rakamların ortalaması: {0}", ortalama);
    }



}