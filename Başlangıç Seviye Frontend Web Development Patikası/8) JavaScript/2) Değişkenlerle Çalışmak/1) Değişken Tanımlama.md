# **Değişken Tanımlama: var, ES6 ile Birlikte Gelen let ve const Değişken Tanımlama Yapısının Kullanımı, var ile Arasındaki Farklar**

Değişkenler en basit tabirle değerleri hafızada tutmak için kullanılan yapılardır. Bir tanımlayıcı ile tanımlanır. Tanımlayıcı öncesi `var`, `let` veya `const` deklarasyonlarından biri kullanılarak deklare edilir. Değişken isimlendirmede dikkat etmemiz gerekenler şunlardır.

- Değişken isimleri harf, _ veya $ işareti ile başlayabilir. Fakat ES5 (ECMAScript 5) birlikte gelen özellikle UNICODE kodları kullanılırken kaçış karakteri olarak kullanılan \ işareti ilk karakter olarak kullanılabilir.

- İlk harften sonra değişken isimlerinde rakamlar da kullanılabilir. $ ve _ dışında başka noktalama işaretleri kullanılamaz

- Değişken ismindeki harfler arasında boşluk kullanılamaz.


## **Değişkene Değer Atama ve Veri Türleri**

Değişkenlere değer atama `=` operatörü ile yapılır.



İlk olarak değişken tanımlaması yapılıp, değer ataması daha sonra yapılabilir. Değişkenler değer atanmadığı takdirde `undefined` değerini alırlar.

Tek bir satırda, deklarasyonları aynı fakat farklı tanımlayıcılar ile tanımlamış değişkenler tek bir satırda tanımlanabilir ve değer atanabilir.

JavaScript `loosely typed` bir programlama dilidir. Yani bir değişkeni tanımlarken değişkenin türünü (sayısal, metinsel, boolean) belirtmemize gerek yoktur.

Yazdığımız zaman 12 değerinin sayısal bir değer olduğunu anlar. Bir değişkene aşağıdaki veri tiplerini atayabiliriz.

- `Boolean` = Mantıksal ifadedir. `true` veya `false` değeri atanabilir

- `Number` = Sayısal ifadedir. `2^53 -1` değerine kadar sayısal değerler atanabilir.

- `BigInt` = `2^53-1` değerinden büyük değerleri atayabilir.

- `String` = Metinsel ifadelerdir. Metinsel ifade tanımlanırken ifade `“ ”` veya `‘ ’` işaretleri arasına yazılır.

- `Object` = Yukarıda ki 7 veri türü de `primitive` tiplidir. Objelerde ( nesne, dizi ) gibi referans tipler de değişkenlere atanabilir.

## **`var`**

`Global scope` veya `function scope`'ta deklarasyon sağlayamaya yarayan `keyword`'dur. Scope özelliklerini daha sonra örneklerle açıklayacağız. var ile tanımlanan değişkenlerin özellikleri şunlardır.

- Değişken değerleri değiştirilebilir.

- Aynı isimle tekrardan tanımlanabilirler.

- var ile tanımlanan değişkenler global scope veya function scope'tur. Global scope'ta tanımlanan değişkenlere her yerden ulaşılabilir. Function içerisinde tanımlanan değişkenlere ise tanımlı olduğu fonksiyonda ulaşılabilir. 

var ile tanımlanan değişkenlerin block scope olmamasından dolayı karşımıza bazı sorunlar çıkabilir.

2015 yılında ES6 çıkmasıyla beraber değişken tanımlamak için `let` ve `const` keyword'leri de kullanılmaya başlanmıştır.

## **`let`**

Değişkenleri `block scope`'ta tanımlayan deklarasyondur. `let` ile tanımlanan değişkenlerin özellikleri şunlardır.

- Değişken değerleri değiştirilebilir.

- Aynı isimle tekrardan aynı blokta tanımlanamaz. Farklı block'larda aynı isimle tanımlanabilir.

## **`const`**

Block scope da tanımlı, değeri sonradan değiştirilemez değişkenleri deklare etmek için kullanılan keyword'dür.

- `Const` ile tanımlanan objelerin özellikleri (properties) değiştirilebilir fakat objenin kendisi değiştirilemez. Diziler içinde aynısı geçerlidir. Dizi değerleri değiştirilebilir fakat dizinin kendisi değiştirilemez.


## **`Hoisting`**

Değişkenlerden bahsederken, değişkenleri kullanıp daha sonra tanımlamamızı sağlayan hoisting kavramından da bahsetmemiz gerekir. 

JavaScript’te tanımlanan değişkenler yorumlanırken tanımladığınız değişkenler fonksiyon veya ifadenin yukarısına alınarak yorumlanır. 

Buna `hoisting (yukarı alma)` denir. 

Yukarıya alınan değişkenler `var` ile deklare edildiyse atandıkları değer yerine `undefined` değerini alır. `let` veya `const` ile deklare edildi ise `ReferanceError` hatası verir. `let` ve `const` ile deklare edilen değişkenler bloğun başlangıcından itibaren tanımının yapıldığı yere kadar kadar geçici (`temporal dead zone`) bölgededir.

> `let` ile içerisindeki bilgiyi sonradan değiştirebiliyoruz ancak `const` ile içerisindeki bilgi tanımlandıktan sonra değiştirilemiyor. `var` gördüğümüz yerleri `let` ile değiştireceğimizi varsayabiliriz.