namespace _4__Algoritma;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir kelime ve bir sayı giriniz (Arada virgül olmalıdır):");
        string ifade = Console.ReadLine();

       Actions actions = new Actions();
       actions.Algoritma(ifade);
    }
}
