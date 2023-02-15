# **`If-Else` Yapısı ve `Ternary If`**
C programlama dillerinden tutun da Java, Python gibi programlama dillerine kadar her programlama dillerinde kullanılan karar yapıları için `If/Else` kullanılır. 

`If else` yapısı içerisinde koşulun sağlandığı kodlar `if` içerisinde yer alırken, koşulun sağlanmadığı kodlar ise `else` içerisinde yer alır.

Eğer ilk koşul yanlışsa başka bir koşul belirtmek amacıyla `else if` kullanılır. `If/Els` kullanımı aşağıdaki gibidir:
```c#
if(kosul) {
    // Bu kod satırı çalışacaktır.
}

else {
    // Bu kod satırı çalışır.
}
```

`Else` kod blokları arasında tek satırlık bir kod yazılacaksa köşeli parantez `{ }` kullanımına gerek yoktur.
```c#
if(kosul) {
    // Bu kod satırı çalışacaktır.
} 

else // tek satırlık kodu buraya yazabilirsin. 
```

## **`Ternary` Operator**
`If` kullanarak kontrol etmek istediğimiz koşullarda `ternary operator` kullanarak satır sayısı olarak avantaj sağlayabiliriz.

`Ternary` operatörünün aldığı 3 parametre şu şekildedir:

- İlk önce bir `condition` belirtiriz ve sonrasında hemen bir `?` koyarız
- Sonrasında, eğer yazdığımız `condition` doğru ise ne yapmak istediğimizi belirtir ve sonuna `:` koyarız
- Ve sıra geldi koşulumuz yanlış ise ne yapmak istediğimize.

Bu aşamaları görsel bir örnekle açıklayalım:

![Ternary Operator](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/javascript/javascript-temel/ternary-operator-kosul-dogruysa-yanlissa-ile-if-kullanimi/figures/TernaryOperator.jpg)

Gördüğümüz üzere eğer yağmur yağıyorsa `umbrella` dönecek, fakat yağmur yağmıyorsa `nothing` dönecek.

Yazdığımız `condition`'nın bize direkt olarak `false` dönmesinin yanı sıra, aynı zamanda `false` dönecek diğer ifadeler şunlardır: `null`, `NaN`, `0`, `""(boş string)` ve `undefined`.

## **Ternary Operatorleri Zincirleme**

Ternary operatörleri aynı zamanda birbiri ardına zincirleyerek (`chaining`) kullanabiliriz. Bu sayede farklı olasılıkları da katarak daha detaylı senaryoları kontrol edebiliriz.

```c#
int time = DateTime.Now.Hour;

string sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
```