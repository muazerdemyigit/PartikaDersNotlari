public class Voting_list
{
    private string name;
    private int rate;
    private static int oran = 4;
    public Voting_list() { }
    public Voting_list(string name, int rate)
    {
        this.Name = name;
        this.Rate = rate;
    }

    public string Name { get => name; set => name = value; }
    public int Rate { get => rate; set => rate = value; }
    public static int Oran { get => oran; set => oran = value; }
}