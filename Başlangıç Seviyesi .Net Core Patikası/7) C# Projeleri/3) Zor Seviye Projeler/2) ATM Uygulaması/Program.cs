namespace C__Projeleri_12_ATM_Uygulaması;
class Program
{
    static void Main(string[] args)
    {
        /*
        ATM uygulaması
        Uygulama ilk çalıştığında kullanıcıdan yapmak istediği işlemi öğrenmelidir. Bunlar ATM üzerinden yapılabilecek temel işlemledir. Para çekme, para yatırma, ödeme yapma vs..İsteğe bağlı olarak genişletilebilir. Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.

        Uygulamada bir de gün sonu seçeneği olmalıdır. Gün sonu alınmak istendiğinde, gün içerisinde yapılan transaction ların logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir. Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.

        Kullanılması gereken teknikler:

            - Dosyaya Yazma
            - Dosyadan Okuma
            - İşlem listesi pre-defined olarak kullanılabilir.
        */

        Dictionary<string, double> accounts = new Dictionary<string, double>();
        accounts.Add("1234", 1000);
        accounts.Add("5678", 2000);
        accounts.Add("9012", 3000);

        string userId = Login(accounts);

        if (userId != null)
        {
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1 - Para Çekme");
                Console.WriteLine("2 - Para Yatırma");
                Console.WriteLine("3 - Ödeme Yapma");
                Console.WriteLine("4 - Çıkış Yap");
                Console.WriteLine("5 - Gün Sonu İşlemi");

                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Withdraw(userId, accounts);
                        break;
                    case 2:
                        Deposit(userId, accounts);
                        break;
                    case 3:
                        Pay(userId, accounts);
                        break;
                    case 4:
                        Logout();
                        break;
                    case 5:
                        EndOfDay(accounts);
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem, lütfen tekrar deneyin.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Hatalı giriş, çıkış yapılıyor...");
        }
    }
    static string Login(Dictionary<string, double> accounts)
    {
        Console.Write("Kullanıcı adı: ");
        string username = Console.ReadLine();

        Console.Write("Parola: ");
        double password;
        if (!double.TryParse(Console.ReadLine(), out password))
        {
            Console.WriteLine("Parola yanlış formatta. Giriş başarısız.");
            return null;
        }

        double userId;
        if (accounts.TryGetValue(username, out userId) && password == userId)
        {
            Console.WriteLine("Giriş başarılı.");
            return username;
        }

        Console.WriteLine("Giriş başarısız. Kullanıcı adı veya parola yanlış.");
        return null;

    }

    static void Withdraw(string userId, Dictionary<string, double> accounts)
    {
        Console.Write("Lütfen çekmek istediğiniz tutarı girin: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount > accounts[userId])
        {
            Console.WriteLine("Hesapta yeterli bakiye yok.");
        }
        else
        {
            accounts[userId] -= amount;
            Console.WriteLine("Yeni bakiye: {0}", accounts[userId]);
        }
    }

    static void Deposit(string userId, Dictionary<string, double> accounts)
    {
        Console.Write("Lütfen yatırmak istediğiniz tutarı girin: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        accounts[userId] += amount;
        Console.WriteLine("Yeni bakiye: {0}", accounts[userId]);
    }

    static void Pay(string userId, Dictionary<string, double> accounts)
    {
        Console.Write("Lütfen ödemek istediğiniz tutarı girin: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        if (amount > accounts[userId])
        {
            Console.WriteLine("Hesapta yeterli bakiye yok.");
        }
        else
        {
            accounts[userId] -= amount;
            Console.WriteLine("Ödeme yapıldı. Yeni bakiye: {0}", accounts[userId]);
        }
    }
    static void Logout()
    {
        Console.WriteLine("Çıkış yapılıyor...");
        Environment.Exit(0);
    }

    static void EndOfDay(Dictionary<string, double> accounts)
    {
        string log = "Transaction Log\n\n";

        foreach (KeyValuePair<string, double> account in accounts)
        {
            log += String.Format("{0}: {1}\n", account.Key, account.Value);
        }

        string errorLog = "Error Log\n\n";
        errorLog += "Hatalı giriş denemeleri logları burada yer alacak.";

        Console.WriteLine(log);
        Console.WriteLine(errorLog);

        string filePath = @"C:\ATM\EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
        File.WriteAllText(filePath, log + errorLog);
    }
}
