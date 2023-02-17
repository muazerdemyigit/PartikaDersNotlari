namespace _16__Hazır_Metotlar___Datetime_ve_Math_Sınıfları;
class Program
{
    static void Main(string[] args)
    {
        //**********************************

        Console.WriteLine(DateTime.Now);//günün tarihini getiriyor.
        Console.WriteLine(DateTime.Now.Date);//günün tarihinin gün ay yıl karşılığını getiriyor.
        Console.WriteLine(DateTime.Now.Day);//günün tarihinin gün karşılığını getiriyor.
        Console.WriteLine(DateTime.Now.Month);//günün tarihinin ay karşılığını getiriyor.
        Console.WriteLine(DateTime.Now.Year);//günün tarihinin yıl karşılığını getiriyor.
        Console.WriteLine(DateTime.Now.Hour);//günün tarihinin saat karşılığını getiriyor.
        Console.WriteLine(DateTime.Now.Minute);//günün tarihinin dakika karşılığını getiriyor.
        Console.WriteLine(DateTime.Now.Second);//günün tarihinin saniye karşılığını getiriyor.
        Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın gününü string halde getiriyor.
        Console.WriteLine(DateTime.Now.DayOfYear);//yılın kaçıncı günününde olduğunu string halde getiriyor.

        //**********************************


        //**********************************

        Console.WriteLine(DateTime.Now.ToLongDateString);//tarihi uzun bir şekilde ayrıntılı getiriyor.
        Console.WriteLine(DateTime.Now.ToShortDateString);//tarihi sayısal olarak çok ayrıntı olmadan getiriyor.
        Console.WriteLine(DateTime.Now.ToLongTimeString);//saati saat dakika saniye şeklinde getiriyor.
        Console.WriteLine(DateTime.Now.ToShortTimeString);//saati saat dakika şeklinde getiriyor.

        //**********************************


        //**********************************

        Console.WriteLine(DateTime.Now.AddDays(2));//2 gün ekler
        Console.WriteLine(DateTime.Now.AddHours(2));//2 saat ekler
        Console.WriteLine(DateTime.Now.AddSeconds(2));//2 saniye ekler
        Console.WriteLine(DateTime.Now.AddMonths(2));//2 ay ekler
        Console.WriteLine(DateTime.Now.AddYears(2));//2 yıl ekler
        Console.WriteLine(DateTime.Now.AddMilliseconds(2));//2 milisaniye ekler
        
        //**********************************


        //**********************************

        // DateTime Format

        Console.WriteLine(DateTime.Now.ToString("dd"));//günün integer karşılığını getirir.
        Console.WriteLine(DateTime.Now.ToString("ddd"));//günün string karşılığının ilk 3 harfini getirir.
        Console.WriteLine(DateTime.Now.ToString("dddd"));//günün string karşılığını getirir. 

        Console.WriteLine(DateTime.Now.ToString("MM"));//ayın integer karşılığını getirir.
        Console.WriteLine(DateTime.Now.ToString("MMM"));//ayın string karşılığının ilk 3 harfini getirir.
        Console.WriteLine(DateTime.Now.ToString("MMMM"));//ayın string karşılığını getirir. 

        Console.WriteLine(DateTime.Now.ToString("yy"));//yılın integer karşılığının son iki sayısını getirir.
        Console.WriteLine(DateTime.Now.ToString("yyyy"));//yılın integer karşılığını getirir. 

        //**********************************


        //**********************************

        //Math Kütüphanesi

        Console.WriteLine(Math.Abs(-25));//verilen değerin mutlak değerini getirir.
        Console.WriteLine(Math.Sin(45));//verilen değerin sinus karşılığını verir
        Console.WriteLine(Math.Cos(45));//verilen değerin cosinus karşılığını verir
        Console.WriteLine(Math.Tan(45));//verilen değerin tanjant karşılığını verir

        //Alttaki üçlü double üzerinde çalışır, küsüratlı verilerde karar vermemize yardıdmcı olurlar.
        Console.WriteLine(Math.Ceiling(22.3));//verilen değerden büyük en küçük tam sayıyı verir.
        Console.WriteLine(Math.Round(22.3));//verilen değere en yakın tam sayıyı verir.
        Console.WriteLine(Math.Floor(22.7));//verilen değerden küçük en büyük tam sayıyı verir.

        Console.WriteLine(Math.Max(2, 6));//verilen değerlerden en büyüğünü getirir.
        Console.WriteLine(Math.Min(2, 6));//verilen değerlerden en küçüğünü getirir.

        Console.WriteLine(Math.Pow(2, 6));//verilen değerlerin üs işlemini getirir.
        Console.WriteLine(Math.Sqrt(4));//verilen değerin kare kökünü getirir.
        Console.WriteLine(Math.Log(4));//verilen değerin e tabanındaki logaritmik karşılığını getirir.
        Console.WriteLine(Math.Exp(4));//verilen değerin e üzeri değerini getirir.
        Console.WriteLine(Math.Log10(4));//verilen değerin log10 tabanındaki karşılığını getirir.

        //**********************************




    }
}
