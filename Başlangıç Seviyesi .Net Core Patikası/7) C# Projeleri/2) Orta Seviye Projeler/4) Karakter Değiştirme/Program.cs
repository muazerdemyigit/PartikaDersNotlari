namespace _4__Karakter_Değiştirme;
class Program
{
    static void Main(string[] args)
    {
        /*
        Algoritma
            Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

            Örnek: Input: Merhaba Hello Algoritma x

            Output: aerhabM oellH algoritmA x
        */
        Console.Write("Bir metin giriniz: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        string[] newWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 1)
            {
                newWords[i] = words[i];
            }
            else
            {
                char firstChar = words[i][0];
                char lastChar = words[i][words[i].Length - 1];

                string newWord = lastChar + words[i].Substring(1, words[i].Length - 2) + firstChar;
                newWords[i] = newWord;
            }
        }

        string output = string.Join(" ", newWords);
        Console.WriteLine($"Yeni metin: {output}");
    }
}
