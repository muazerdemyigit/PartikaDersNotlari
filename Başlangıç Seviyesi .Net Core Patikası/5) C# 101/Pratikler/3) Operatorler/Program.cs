namespace _3__Operatorler;
class Program
{
    static void Main(string[] args)
    {
        //****************************
        Console.WriteLine("***********İşlemli Atama Ve Atama Operatörleri**************");
        //İşlemli Atama Ve Atama Operatörleri

        int x = 3;
        int y = 3;

        y = y + 2;
        Console.WriteLine(y);

        y += 2;
        Console.WriteLine(y);

        y /= 1;
        Console.WriteLine(y);

        x *= 2;
        Console.WriteLine(x);

        //****************************


        //****************************
        Console.WriteLine("***********Mantıksal Operatörler**************");
        //Mantıksal Operatörler

        // ||(veya), &&(ve), !(değil)

        bool isSucces = true;
        bool isCompleted = false;

        if (isSucces && isCompleted)
        {
            Console.WriteLine("Perfect");
        }

        if (isSucces || isCompleted)
        {
            Console.WriteLine("Great");
        }

        if (isSucces && !isCompleted)
        {
            Console.WriteLine("Fine");
        }

        //****************************


        //****************************
        Console.WriteLine("***********İlişkisel Operatörler**************");
        //İlişkisel Operatörler

        // <(küçüktür), >(büyüktür), <=(küçük eşittir), >=(büyük eşittir), ==(eşittir), !=(eşit değildir)

        int a = 3;
        int b = 4;
        bool sonuc = a < b;
        Console.WriteLine(sonuc);

        sonuc = a > b;
        Console.WriteLine(sonuc);

        sonuc = a >= b;
        Console.WriteLine(sonuc);

        sonuc = a <= b;
        Console.WriteLine(sonuc);

        sonuc = a == b;
        Console.WriteLine(sonuc);

        sonuc = a != b;
        Console.WriteLine(sonuc);
        //****************************


        //****************************
        Console.WriteLine("***********Aritmetik Operatörler**************");
        //Aritmetik Operatörler

        // /(bölü), *(çarpı), +(artı), -(eksi), %(mod alma)

        int sayi1 = 10;
        int sayi2 = 5;

        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1);

        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);

        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);

        sonuc1 = sayi1 - sayi2;
        Console.WriteLine(sonuc1);

        int sonuc2 = 20 % 3;
        Console.WriteLine(sonuc2);


        //****************************

    }
}

