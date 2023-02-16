# **`Metot` Nedir ?**

`Metot`'ları programı küçük parçalara ayrıştırmak için kullanırız. Büyük bir işi tek bir metot içinde yazmak yerine küçük parçalara ayırarak yazmak daha doğru bir yaklaşımdır.

Bu bizi hem kod tekrarından kurtarır hem de daha okunabilir kod parçaları yazmamızı sağlar. Metotlar tek başlarına kullanılabilen yapılar değildir. Bir sınıf içerisinde yazılmalı ve ancak sınıfın nesnesi aracılığıyla erişilebilir olmalıdır. (`Static` sınıf metodlarına `sinifAdi.metotIsmi` şeklinde erişilebilir.)

Söz dizimi ise aşağıdaki gibidir:
```csharp
erişim_belirteci geri_donus_tipi metot_adi(argüman/parametre)
{
	//komutlar;
}
```

Yukarıda `public` erişim tipinde, `integer` geri dönüş tipine sahip, `Topla` isminde ve 2 tane `integer` tipinde parametre alan bir `metot` tanımı görüyoruz.

Metotlat içerisinde tanımlanan değişkenler sadece metot içerisinden erişilebilirler. Programından başından sonuna kadar yaşamazlar. Metottan çıkıldığından `lifetime`'ı yani yaşam süresi sona erer.

## **`Ref` Kullanımı**

Bir fonksiyona parametre aktarırken değer veya `referans` tipinde paramtere verebiliriz.

- Değer tipleri metoda bit bit kopyalanır. Yani `int` bir değişkeni parametre olarak değer tipinde bir fonksiyona verdiğimizde; fonksiyon çalışırken bellekten integer bir değişkeni saklayabilecek kadar yer ayrılır ve gönderilen parametre orada saklanır. Fonksiyon içerisinde parametre üzerinde değişiklik yapıldığında ana değişken değişmez. Sadece kopyası üzerinde değişiklik yapılmış olur. Fonksiyon sonlandığındaysa bellekten silinir. Yani yaşam süresi sona erer.

**Değer Tipleri** şu şekildedir: 

```csharp
int, long, float, double, decimal, char, bool, byte, short, struct, enum
```

Referans olarak bir atama yapıldığında ise fonksiyona ilgili değişkenin bellekteki adresi gönderilmiş gibi düşünebilirsiniz. Dolayısıyla fonksiyon asıl değişken üzerinde değişiklik yapar. Fonksiyon içerisinde bir değişiklik yapıldığında çağırıldığı yerdeki değişken de değişikliğe uğramış olur. Yani değeri değişir. Bu nedenle `ref` anahtar kelimesini kullanırken çok dikkatli olunmalıdır.

### **`Ref` Kullanımının Özellikleri:**

Referans olarak iletilmek istenen değişkenin önüne "`ref`" yazılmalıdır.
`ref` olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır.

Örnek `ref` kullanımı ise şu şekildedir :

```csharp
int x = 3;
int y = 4;
int sonuc = instance.ArttırVeTopla(ref x, ref y);

public int ArttırVeTopla (ref int x, ref int y)
{
    x+=1;
    y+=y;
    return (x+y);
}
```