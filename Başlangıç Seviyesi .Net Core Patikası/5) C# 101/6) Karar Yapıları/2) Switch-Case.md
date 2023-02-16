# **`Switch-Case` Yapısı**

`Switch-Case` deyimi `if-else` deyimleri gibi karar kontrol yapılarıdır. `Switch-Case` ifadeleri yapabileceğiniz her şeyi `if-else` blokları ile de yapabiliriz. Bir ifade üç veya daha fazla koşula göre ayrıştırıldığında genel olarak `if-else`'e alternatif olarak `switch case` kullanılır.

Örnek bir `switch-case` ifadesi :

```csharp
switch(degisken)
{
    case sabit1:
        komutlar;
        break;
    case sabit2:
        komutlar;
        break;
    case sabit3:
        komutlar;
        break;
    default:
        komutlar;
        break;
}
```

Yukarıdaki örnekte, değişken adıyla girdi alınan veri kontrol edilir. Eğer değişken `sabit1`'e eşit ise bazı komutlar çalıştırılır ve `switch` ifadesi sonlandırılır.

Bir koşul sağlandığında gerekli komutlar çalıştırıldıktan sonra `break;` ifadesi ile kontrol sonlandırılır. Bu demek oluyor ki her `case` ifadesi birbirinden farklı olmalıdır. Ve bir `switch-case` ifadesinde yalnızca bir `case` çalışmalıdır.

Peki kontrol edilen değişken hiçbir sabit ifadeye eşit değilse ne olacak?

Tam da bu noktada `default case`'ini görüyoruz. Bu durumda kod `default` kısmında belirtilen kod bloğunu çalıştırır.

`Switch-Case` ifadelerinde dikkat edilmesi gereken durumlar aşağıdaki gibidir:

- `Case` ifadelerinin sırası önemli değildir.
- Bilinenin aksine `default` ifadesi en son yazılmak zorunda değildir.
- `Default` ifadesi zorunlu değildir. Yazılmasa da olur.