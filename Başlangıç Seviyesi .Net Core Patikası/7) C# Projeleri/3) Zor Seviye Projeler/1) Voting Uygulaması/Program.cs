namespace C__Projeleri_11_Voting_Uygulaması;
class Program
{
    static void Main(string[] args)
    {
        /*
        Voting Uygulaması
        
        Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir. Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir. Oylama sırasında öncelikle kullanıcının username'i istenmelidir. Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir. Kategoriler isteğe bağlı olarak belirlenebilir.

        Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri

        Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.

        Kullanılması gereken teknikler:

            - Kategoriler pre-defined kullanılabilir.*/
        Voting voting = new Voting();
        voting.Welcome();
    }


}
public class Voting
{
    List<Person> persons = new List<Person>();
    List<Voting_list> voting_lists = new List<Voting_list>();
    public Voting()
    {
        persons.Add(new Person("Muaz", "1234"));
        voting_lists.Add(new Voting_list("Spor", 1));
        voting_lists.Add(new Voting_list("Müzik", 1));
        voting_lists.Add(new Voting_list("Film", 1));
        voting_lists.Add(new Voting_list("Dizi", 1));
    }
    public void Welcome()
    {
        Console.WriteLine("**********************************");
        Console.WriteLine("Voting App'e Hoş Geldin!\n");
        Console.WriteLine(" 1 - Mevcut Oylama Durumunu Gör: ");
        Console.WriteLine(" 2 - Oy Kullan:");
        Console.WriteLine(" 3 - Üyelik işlemleri:\n");
        Console.Write(" Yapmak istediğiniz işlemi seçiniz: ");
        int secim = int.Parse(Console.ReadLine());

        switch (secim)
        {
            case 1:
                {
                    VotingStatus();
                    break;
                }
            case 2:
                {
                    Vote();
                    break;
                }
            case 3:
                {
                    MembershipCreate();
                    break;
                }
            default:
                break;
        }
    }

    public void VotingStatus()
    {
        System.Console.WriteLine("\n Şu andaki kategori sayısı: {0}", voting_lists.Count);
        System.Console.WriteLine(" Kullanılan oy sayısı: {0}", Voting_list.Oran);
        int i = 1;
        foreach (var item in voting_lists)
        {
            System.Console.WriteLine("{0} - {1} Kategorisi , Oy Oranı: %{2}", i, item.Name, ((item.Rate) * 100) / Voting_list.Oran);
            i++;
        }
    }

    public void Vote()
    {
    LogginScreen:
        System.Console.WriteLine("Oy Kullanmadan önce giriş yapmalısınız !");
        System.Console.WriteLine(" Giriş Yapmak için     (1)\n"
                                + " Hesap Oluşturmak için (2)"); int secim = int.Parse(Console.ReadLine());
        if (secim == 1)
        {
            System.Console.Write(" Kullanıcı Adı : "); string Username = Console.ReadLine().ToLower();
            int flag = 0;
            foreach (var item in persons)
            {
                if (Username == item.Username.ToLower())
                {
                    System.Console.Write(" Şifre : "); string Password = Console.ReadLine().ToLower();
                    if (Password == item.Password.ToLower())
                    {

                        VotingStatus();
                        System.Console.WriteLine("Başarıyla Giriş Yaptınız!");
                        System.Console.Write(" Oy kullanmak istediğiniz kategoriyi seçiniz : "); int oyindex = int.Parse(Console.ReadLine());

                        voting_lists[oyindex - 1].Rate += 1;
                        Voting_list.Oran += 1;
                        System.Console.WriteLine("{0} Kategorisine Oy Kullandınız.", voting_lists[oyindex - 1].Name);

                    }

                }
                else if (flag == persons.Count() - 1)
                {
                    System.Console.WriteLine("Kullanıcı Adı Hatalı !!\n"
                                            + "Yeniden dene     (1)\n"
                                            + "Üyelik oluştur   (2)"); secim = int.Parse(Console.ReadLine());
                    if (secim == 1)
                        goto LogginScreen;
                    else
                    {
                        MembershipCreate();
                        goto LogginScreen;
                    }


                }
                flag++;
            }

        }
        else { MembershipCreate(); goto LogginScreen; }
    }

    public void MembershipCreate()
    {
        System.Console.Write(" Kullanıcı Adı : "); string username = Console.ReadLine().ToLower();
        System.Console.Write(" Şifre : "); string password = Console.ReadLine().ToLower();
        persons.Add(new Person(username, password));
    }
}
