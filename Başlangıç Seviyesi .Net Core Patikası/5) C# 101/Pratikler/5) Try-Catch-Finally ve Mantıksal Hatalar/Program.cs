namespace _5__Try_Catch_Finally_ve_Mantıksal_Hatalar;
class Program
{
    static void Main(string[] args)
    {
        //**********************************

        /*
        Hatalar oluşma zamanına göre ikiye ayrılır;
        1) Compile Time : Kod yazılırken derleyicinin oluşturduğu hatalardır. Kod yazılırken verilen hatalardır.
        2) Run Time : Kod çalışırken oluşan hatalardır. 
        */

        //**********************************


        //**********************************

        try//hataya neden olabilecek kod buraya yazılır.
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);

        }
        catch (Exception ex)//hata ile karşılaşıldığında ne yapılacağı buraya yazılır.
        {
            Console.WriteLine("Hata: " + ex.Message.ToString());//ex bizim hatamız, ex.Message ile ekrana mesaj şeklinde yazdırabiliriz.
        }

        //**********************************

        //int.Parse() kullanıldığında karşımıza çıkabilecek hatalar:
        try
        {
            int a = int.Parse(null);

        }
        catch (ArgumentNullException ex)//Kodun vereceği hatayı önceden bildiğimiz durumlarda özel olarak o hatayı fırlatmasını sağlayabiliriz. Null girilemeyen bir ifadeyi null girersek bu hata gelir.
        {
            Console.WriteLine("Boş değer girdiniz.");
            Console.WriteLine(ex);
        }
        //-----------------------

        try
        {
            int b = int.Parse("test");
        }
        catch (FormatException ex)//Verilen veri tipleri uygun olmadığında bu hata gelir.
        {
            Console.WriteLine("Veri Tipi Uygun Değil.");
            Console.WriteLine(ex);
        }
        //-----------------------

        try
        {
            int c = int.Parse("10000000000");
        }
        catch (OverflowException ex)//Bu hata verilen değerin integerin min max değerlerinin dışında olması sonucu gelir.
        {
            Console.WriteLine("Girilen değer, girilebilecek değer aralığının dışında.");
            Console.WriteLine(ex);
        }
        finally//hata olsun olmasın mutlaka yapılması istenilen işler varsa buraya yazılır. Bu Kısım zorunlu değildir.
        {
            Console.WriteLine("İşlem başarıyla tamamlandı.");
        }


        //**********************************
    }
}

