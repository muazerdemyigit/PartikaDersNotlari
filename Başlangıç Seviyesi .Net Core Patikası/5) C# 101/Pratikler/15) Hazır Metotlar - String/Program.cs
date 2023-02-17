namespace _15__Hazır_Metotlar___String;
class Program
{
    static void Main(string[] args)
    {
        //*****************************************

        //Normalde birden fazla kod satırında yapılan büyük işlemleri string kütüphanesinin özelliklerinden faydalanarak çok daha kısa kod satırlarında, çok daha okunabilir şekilde yazabiliriz.

        string degisken = "Dersimiz CSharp, Hoşgeldiniz.";
        string degisken2 = "CSharp";

        //*****************************************


        //*****************************************

        // Length ile karakter sayısına ulaşılınır.
        Console.WriteLine(degisken.Length);

        //*****************************************


        //*****************************************

        //ToUpper , ToLower verilen stringin tüm karakterlerini büyük(ToUpper) veya küçük(ToLower) harf yapar.
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //*****************************************


        //*****************************************

        //Concat birleştirme özelliğidir.
        Console.WriteLine(String.Concat(degisken, "Merhaba!"));

        //*****************************************


        //*****************************************

        //Compare , CompareTo  
        Console.WriteLine(degisken.CompareTo(degisken2));//birinci değişken ikinci değişkene eşit olursa sıfır döner. Birinci değişken ikinci değişkenden daha büyük bir karakter sayısına sahipse 1 döner, daha küçük karakter sayısına sahipse -1 döner.
        Console.WriteLine(String.Compare(degisken, degisken2, true));// iki değişken karşılaştırılır, true denirse büyük küçük harfe duyarsız olur

        //*****************************************


        //*****************************************

        //Contains içeriyor mu demek. İlk değişkenin içerisinde ikinci değişken var mı? Bool sonuç döner.
        Console.WriteLine(degisken.Contains(degisken2));

        //*****************************************


        //*****************************************

        //EndWith belirtilen koşul ile bitiyor mu?
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz."));//true
        Console.WriteLine(degisken.StartsWith("Merhaba."));//false
        
        //*****************************************


        //*****************************************

        //IndexOf değişken içerisinde belirtilen değerin Index'ini döner.
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine(degisken.IndexOf("Muaz."));//Bulamazsa -1 döner.

        //*****************************************


        //*****************************************

        //LastIndexOf belirtilen değerin en son hangi Index'te bulunduğunu döner.
        Console.WriteLine(degisken.LastIndexOf("i"));

        //*****************************************


        //*****************************************

        //Insert belirtilen Index'ten sonra belirtilen şey eklenir.
        Console.WriteLine(degisken.Insert(0, "Merhaba! "));

        //*****************************************


        //*****************************************

        //PadLeft , PadRight değişkenin sonuna belirtilen Index'e tamamlayacak kadar belirtilen şeyi ekler.
        Console.WriteLine(degisken + degisken2.PadLeft(30));//Değişken2'nin soluna 30'a tamamlayacak kadar belirtilen şeyi ekler
        Console.WriteLine(degisken + degisken2.PadLeft(50, '*'));//Değişken2'nin solunda 50'den sonra * ekle.
        Console.WriteLine(degisken.PadRight(50, '-') + degisken2);//Değişken1'in sağında 50'den sonra - ekle.

        //*****************************************


        //*****************************************

        //Remove belirtilen Index'teki karakterden sonraki karakterleri siler.
        Console.WriteLine(degisken.Remove(10));//10.Index'ten başlayarak sonuna kadar siler.
        Console.WriteLine(degisken.Remove(5, 3));//5.Index'ten başlayarak 3 karakter siler.

        //*****************************************


        //*****************************************

        //Replace İlk belirtilen değeri ikinci belirtilen değer ile değiştirir
        Console.WriteLine(degisken.Replace("CSharp", "C#")); // CSharp'ı C# ile değiştir.
        Console.WriteLine(degisken.Replace(" ", "*"));//Boşlukalrı * yap.

        //*****************************************


        //*****************************************

        //Split belirtilen koşula göre parçalar ve bir diziye atar, istenilen Index'teki veriyi döner.
        Console.WriteLine(degisken.Split(' '[1]));//Boşluklara göre parçala ve 1.Index'i getir.

        //*****************************************


        //*****************************************

        //Substring belirtilen Index'ten başlayarak son Index'e kadar getirir.
        Console.WriteLine(degisken.Substring(4));//4.Index'ten başlayarak son Index'e kadar getirir.

        //*****************************************


        //*****************************************

        Console.WriteLine(degisken.Substring(4, 6));//4.Index'ten başlayarak 6 karakter getirir.

        //*****************************************
    }
}
