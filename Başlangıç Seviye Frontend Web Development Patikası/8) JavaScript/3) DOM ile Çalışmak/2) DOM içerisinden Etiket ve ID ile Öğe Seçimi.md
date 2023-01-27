# **DOM içerisinden Etiket ve ID ile Öğe Seçimi**

Bu yazımızda `DOM (Document Object Model)` içerisinden öğeleri seçmek için kullanacağımız metotlardan bahsedeceğiz. `Document Object Model`'de öğeler birden fazla yöntem ile seçilebilir. Birinci yöntemimiz olan element `id`'sini kullanarak seçme metodu ile başlayalım.

## **`Get Element By ID`**

`document` objesinin `getElementById()` metodu ile sayfada bulunan `html` elementlerinin `ID`'leri referans alarak seçme işlemi yapabiliyoruz.

Örnek olarak;
```html
<div id="unicorn">🦄</div>
```
sayfada bulana bu elementi `getElementById()` metodunu kullanarak seçmeye çalışalım.
```js
const unicorn = document.getElementById('unicorn');
```
`ID`'ler büyük-küçük harf duyarlıdır. Bu sayede `HTML` document içinde biriciklik gösterir ve her zaman geriye bir eleman döndürür. Bir eşleşme bulamazsa da geriye `null` dönüşünü yapar.
```js
- document.getElementById('#root'); // null
+ document.getElementById('root'); // <div id=​"root">​…​</div>​
```
## **`Get Elements By Tag Name`**

Elemanları etiket isimlerine göre seçmek için `getElementsByTagName()` metodu kullanılır. Birden çok elemente ulaşmak amacı ile kullanılır. Girdi olarak bir `html` elementi alır ve buna uygun bir `HTMLCollection` döndürür.

Örneğin, elimizde bu şekilde bir sayfa var;
```html
<p>🐱</p>
<p>🐰</p>
<p>🐯</p>
<p>🐧</p>
```
Bu sayfadaki tüm `p` elemanlarına ulaşmak istersek;
```js
const animals = document.getElementsByTagName('p'); 
// Çıktı:  HTMLCollection(4) [p, p, p, p]
```
Yazmanız yeterli olacaktır.

Ayrıca sayfadaki tüm etiketleri bu şekilde getirebilirsiniz.
```js
document.getElementsByTagName('*')
// Çıktı: HTMLCollection(33) [html, head, meta, link#.....
```

## **`Get Elements By Name`**

Elemanları isimlerine göre getirmek içim `getElementsByName()` metodu kullanılır. Elemanların name değerlerine göre bir `NodeList` objesi döndürür.
```html
<input type="text" name="e-posta">
<input type="tel" name="telefon">
<input type="date" name="tarih">
```
E-posta adını taşıyan tüm öğeleri getirelim.
```js
const emails = document.getElementsByName('e-posta');
// Çıktı: NodeList [input]
```
Unutmayın ki `name` değeri `id`'de olduğu gibi biricik bir değer taşımaz birden fazla eleman aynı name değerini taşıyabilir. Eğer biricik (`uniq`) bir değer vermeniz gerekirse `id`'yi kullanın.'

## **`Get Elements By Class Name`**

`DOM`'da istediğimiz `class name`'i taşıyan tüm elemanları seçmek için `getElementsByClassName()` metodunu kullanırız. Bu metot bize bir `HTMLCollection` döndürür. Ve kullanırken `class` isminin başına nokta "`.`" koymamanız gerekir.
```html
<div class="baykuş kusu">🦉</div>
<div class="güvercin kusu">🐦</div>
<div class="kartal kusu">🦅</div>
<div class="kedi">🐱</div>
```
>Hatırlayalım! `class="baykuş kusu"` burada baykuş ve kusu iki ayrı class'tır.

Hadi sayfamızdaki tüm kuşları seçelim;
```js
const kuslar = document.getElementsByClassName('kusu');
// Çıktı: HTMLCollection(3) [div.baykuş.kusu, div.güvercin.kusu, div.kartal.kusu]
```
Ayrıca bu metotla birden fazla `class name` belirtip daha detaylı bir seçim yapabilirsiniz.
```js
document.getElementsByClassName('kartal kusu');
// Çıktı: HTMLCollection [div.kartal.kusu]
```

## **`Query Selector`**
`QuerySelector ()` yöntemi, `CSS` seçicilere dayalı olarak `DOM`'dan `html` elemanlarını seçmenize izin veren iki modern `JavaScript` yönteminden biridir. Bu yöntem ile hem css class'larını hem de `id`'lerini kullanabilirsiniz. Bunu yaparken `class` için ön ek olarak nokta "`.`", `id`'ler için kare "`#`" kullanmanız gerekir. Sayfada eşleşen ilk elemanı size döndürecektir. Belirtilen elemanın eşleşememesi durumunda geriye `null` dönecektir.
```js
const email = document.querySelector('#signup input[name="email"]');
```
## **`Query Selector All`**

`querySelectorAll()` metodu, `QuerySelector ()` metodu ile aynı mantık ile çalışır tek farkı eşleşen ilk elamanı döndürmek yerine eşleşen tüm elemanları bir `NodeList` objesi olarak döndürmesidir.
```js
const elems = document.querySelectorAll('.bird, .animal');
console.log(elems.length); // 4
```
Metotları bir arada kullanabilirsiniz. Yukarda öğrendiğimiz metotları bir arada kullanabiliyoruz. Önce tek bir elemanı seçerek ardından içinde ikinci bir sorguyu yapabiliyoruz.

Örneğin;
```html
<form id="signup">
    <input type="text" name="email">
    <input type="tel" name="phone">
    <input type="date" name="date-of-birth">
</form>
```
`signup id`'li elemanın içindeki tüm `input` elemanlarını seçmek istersek;
```js
const inputs = document.getElementById('signup').getElementsByTagName('input');
```
veya

```js
const inputs = document.querySelector('#signup').querySelectorAll('input');
```
Sonrasında oluşturduğumuz `inputs` değişkenine `Console` üzerinden ulaşabilirsiniz.

![Console inputs](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/javascript/javascript-temel/dom-icerisinden-etiket-ve-id-ile-oge-secimi/figures/console_inputs.png)

