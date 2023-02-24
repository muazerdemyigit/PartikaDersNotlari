namespace _21__Kurucu_Metotlar;
class Program
{
    static void Main(string[] args)
    {
        //Kurucu metotlar bir sınıfın nesnesi oluşturulduğunda yani 'new' ile yeni bir nesnesini oluşturduğumuzda, arka planda otomatik olarak çalıştılan metotlardır. 
        //Bir nesen oluşturulduğunda otomatik olarak arka planda yapılmasını istediğimiz şeyleri kurucu metot içinde yaparız.
        //Kurucu metotların isimleri mutlaka sınıf ismi ile aynı olmalıdır.
        //Kurucu metotların erişim belirleyicileri mutlaka public olmak zorunda.
        //Kurucu metotların geri dönüş tipleri yoktur. Sadece public ve class ile aynı isimde bir metot adından oluşuyor. Parametre(ler) alabilir, metot gibi gövdesi vardır.
        //Kurucu fonksiyonda o sınıfın property'lerinin hepsini setlemezsek default değer olarak atar.

        Console.WriteLine("******* Çalışan 1 *******");
        Calisan calisan1 = new Calisan("Ayşe", "Kara", 23425634, "İnsan Kaynakları");
        calisan1.CalisanBilgileri();

        Console.WriteLine("******* Çalışan 2 *******");

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Deniz";
        calisan2.Soyad = "Arda";
        calisan2.No = 25646789;
        calisan2.Departman = "Satın Alma";
        calisan2.CalisanBilgileri();

        Console.WriteLine("******* Çalışan 3 *******");
        Calisan calisan3 = new Calisan("Muaz", "YİĞİT");
        calisan3.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public Calisan(string ad, string soyad, int no, string departman)//Kurucu Fonksiyon Tanımlamak
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan(string ad, string soyad)//Kurucu Fonksiyon Tanımlamak
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    public Calisan() { }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı:{0}", Ad);
        Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
        Console.WriteLine("Çalışanın Numarası:{0}", No);
        Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
    }
}