namespace _1__Alan_Hesaplama;
class Program
{
    static void Main(string[] args)
    {
        /*
        Alan Hesaplama
            C# Console uygulaması oluşturarak aşağıdaki gereksinimleri karşılayan uygulamayı yazınız.

            - İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
            - Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
            - Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
            - Hesap sonucunu anlaşılır şekilde geri döndürmeli.
            
            Dikkat Edilmesi Gereken Noktalar :

            - Kod tekrarından kaçınılmalı
            - Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
        */
        Console.WriteLine("Lütfen İşlem Yapmak İstediğiniz Geometrik Şekle Göre Bir Sayı Giriniz: \n 1)Daire \n 2)Üçgen \n 3)Kare \n 4)Dikdörtgen");

        int sekil = int.Parse(Console.ReadLine());
        int secim;


        switch (sekil)
        {

            case 1:

                Console.WriteLine("Daire'yi seçtiniz. \n Lütfen yarıçap bilgisi giriniz:");
                double yaricap = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu giriniz: \n 1)Çevre \n 2)Alan \n 3)Hacim");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {

                    case 1:
                        Daire.DaireCevre(yaricap);

                        break;
                    case 2:
                        Daire.DaireAlan(yaricap);

                        break;
                    case 3:
                        Daire.DaireHacim(yaricap);

                        break;

                }

                break;

            case 2:
                Console.WriteLine("Üçgen'i seçtiniz. \n Lütfen üç adet kenar uzunluğu, bir adet yükseklik uzunluğu giriniz:");

                Console.WriteLine("Kenar 1:");
                int kenar1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Kenar 2:");
                int kenar2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Taban:");
                int taban = int.Parse(Console.ReadLine());

                Console.WriteLine("Yükseklik:");
                int yukseklik = int.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu giriniz: \n 1)Çevre \n 2)Alan");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {

                    case 1:
                        Ucgen.UcgenCevre(kenar1, kenar2, taban);

                        break;
                    case 2:
                        Ucgen.UcgenAlan(taban, yukseklik);

                        break;
                }

                break;

            case 3:
                Console.WriteLine("Kare'yi seçtiniz. \n Lütfen uzunluk bilgisi giriniz:");
                int uzunluk = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu giriniz: \n 1)Çevre \n 2)Alan \n");
                secim = int.Parse(Console.ReadLine());
                switch (secim)
                {

                    case 1:
                        Kare.KareCevre(uzunluk);

                        break;
                    case 2:
                        Kare.KareAlan(uzunluk);

                        break;
                }
                break;

            case 4:
                Console.WriteLine("Dikdörtgen'i seçtiniz. \n Lütfen kısa kenar ve uzun kenar uzunluk bilgisi giriniz:");
                int kisaKenar = int.Parse(Console.ReadLine());
                int uzunKenar = int.Parse(Console.ReadLine());

                Console.WriteLine("Lütfen hesaplamak istediğiniz boyutu giriniz: \n 1)Çevre \n 2)Alan \n");
                secim = int.Parse(Console.ReadLine());
                switch (secim)
                {

                    case 1:
                        Dikdortgen.DikdortgenCevre(kisaKenar, uzunKenar);

                        break;
                    case 2:
                        Dikdortgen.DikdortgenCevre(kisaKenar, uzunKenar);

                        break;
                }

                break;

        }
    }
}
