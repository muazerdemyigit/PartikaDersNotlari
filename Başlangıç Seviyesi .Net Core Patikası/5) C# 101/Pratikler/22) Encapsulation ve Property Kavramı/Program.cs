namespace _22__Encapsulation_ve_Property_Kavramı;
class Program
{
    static void Main(string[] args)
    {
        //Bir nesnenin bazı özelliklerini veya işlevlerini, metotlarını diğer classlardan veya diğer nesnelerden korumak anlamına geliyor. Bu işlem erişim belirliyicilerle yapılıyor.
        //Property'ler yardımıyla encapsulation kulanarak biz sınıfın üyelerini/field'larını kapatabiliriz, onların değişmelerini engelleyebilir ya da koruyabiliriz.
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ayşe";
        ogrenci.Soyisim = "Yılmaz";
        ogrenci.OgrenciNo = 293;
        ogrenci.Sinif = 3;
        ogrenci.OgrenciBilgileriniGetir();
        ogrenci.SınıfAtlat();
        ogrenci.OgrenciBilgileriniGetir();

        Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
        ogrenci1.SınıfDusur();
        ogrenci1.SınıfDusur();
        ogrenci1.OgrenciBilgileriniGetir();
    }
}

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim
    {
        get { return isim; }//get => isim; bu ikisi aynı şey
        set { isim = value; }//set => isim = value;
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir.");
                sinif = 1;
            }
            else
            {
                sinif = value;
            }
        }
    }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("***********Öğrenci Bilgileri*******");
        Console.WriteLine("Öğrenci Adı         :{0}", this.Isim);
        Console.WriteLine("Öğrenci Soyadı      :{0}", this.Soyisim);
        Console.WriteLine("Öğrenci No          :{0}", this.OgrenciNo);
        Console.WriteLine("Öğrenci Sınıf       :{0}", this.Sinif);
    }

    public void SınıfAtlat()
    {
        this.Sinif = this.Sinif + 1;
    }
    public void SınıfDusur()
    {
        this.Sinif = this.Sinif - 1;
    }
}
