public class Person
{
    private string username;
    private string password;
    public Person() { }
    public Person(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }
    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }
}