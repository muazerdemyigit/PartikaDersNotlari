# **Number Veri Türü Kullanımı, Temel Aritmetik İşlemler ve İşlem Önceliği ve Arttırma ve Azaltma İşlemleri**

## **Number (Sayı) Veri Türü**
JavaScript dili `weakly-typed` yani güçsüz türlü bir dildir. Değişkenlerin ve parametrelerin türlerini bildirmek gerekmez. Tür kullanımdan dolaylı olarak çıkartılır.

Örneğin;
```js
    var x = 3;
```
Şeklinde bir kullanımda x değişkenin değeri bir tam sayıdır (`integer`), aşağıdaki örnekte ise;
```js
    var x = 3.2;
```
x değişkenin değer türü kayan sayı (`float`) türündedir. Sayının integer veya float olup olmadığı nokta (`.`) olup olmamasından anlaşılır.

## **Aritmetik Operatörler**

- Toplama: +
- Çıkarma: -
- Çarpma: *
- Üs Alma: **
- Bölme: /
- Mod Alma: %
- Arttırma: ++
- Eksiltme: --

`Toplama:` Sayıları toplama işlemini gerçekleştirir. İşlem yönü soldan sağadır.
```js
    var result = 3+5;
    console.log(result);
    //8 
```
`Çıkarma:` İki sayıyı çıkarma işlemini gerçekleştirir. İşlem yönü soldan sağadır.
```js
    var result = 5-2;
    console.log(result);
    //3
```
`Çarpma:` İki sayıyı çarpma işlemini gerçekleştirir. İşlem yönü soldan sağadır.
```js
    var result = 5*2;
    console.log(result);
    //10
```
`Üs Alma:` ECMAScript6 ile gelmiştir. Soldaki değerin, sağdaki rakam veya sayı baz alınarak kendisiyle çarpılması şeklinde gerçekleşir.
```js
    var result = 5**2;
    console.log(result);
    //25  
```
`Bölme:` İki sayıyı bölme işlemini gerçekleştirir. İşlem yönü soldan sağadır.
```
    var result = 6/3;
    console.log(result);
    //2
```
`Mod Alma:` Operatörün solundaki değerin sağdakine kalanını bulmak için kullanılmaktadır. İşlem yönü soldan sağadır.
```
    var result = 6%3;
    console.log(result);
    //0
```
`Arttırma:` Bir sayıyı arttırmak için kullanırız. Değeri 1 arttırır. For ve While döngüleri içinde sık sık kullanılır, önce veya sonra kullanılabilir. Operatörün değişkenden sonra gelmesi durumuna postfix form, değişkenden önce gelme durumuna prefix form denilmektedir. Her iki kullanımda da değer +1 arttırılır lakin prefix formu oluşan yeni değeri döndürmektedir. Postfix formu ise eski değeri döndürür, yani ekrana alert keyword (anahtar kelimesi) ile basar, ekrana basılan değer eski değerdir. Arttırma işlemi yapılmıştır ve değişkende arttırılmış hali tutulur.

Örneğin;
```js
let counter = 1;
   let a = ++counter;
   alert(a); // 2

   let counter = 1;
   let a = counter++; 
   alert(a); // 1console.log(counter); // 2 değerini verir.
```
`Azaltma:` Bir sayıyı azaltmak için kullanırız. Değeri 1 azaltır. For ve While döngüleri içinde sık sık kullanılır. Arttırma operatöründe anlatılan başa veya sonraya operatör ekleme işlemi sonunda gerçekleşen durum azaltma operatörü içinde geçerlidir.
```js
    let counter = 1;
    let a = --counter;
    alert(a); // 0
```
İşlem Önceliği Temel dört işlem kuralları, JavaScript için de geçerlidir.

