namespace _4__Algoritma;

public class Actions
{
    public void Algoritma(string ifade)
    {
        string[] input = ifade.Split(",");
        string word = input[0];
        int number = Convert.ToInt32(input[1]);
        string newWord = word.Remove(number, 1);

        Console.WriteLine(newWord);
    }
}