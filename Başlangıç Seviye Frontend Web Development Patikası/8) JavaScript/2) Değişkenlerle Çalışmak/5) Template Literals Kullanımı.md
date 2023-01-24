# **Template Literals Kullanımı**
`Template Literals` (önceki adıyla `Template Strings`), kod okunabilirliği ve yazım kolaylığı sağlayan `ES6` ile gelmiş bir `string` yazma şeklidir.

## **Kullanım Şekli**
```js
"Eski string"

`Bu bir yeni string örneğidir.`
```
String ifade yazarken, `"` veya `'` kullanırız. `Template Literals` ile JavaScript'te backtick (```) işareti kullanılmaya başlanmıştır.

Windows için → `Alt Gr + ,`

Mac için → `option + ,`

Yaparak bu işareti kullanabilirsiniz.

## **Sağladığı Faydalar**

### **Çok Satırlı Dize Yazımı:**
```js
//Eski kullanım:
let eskiString = "En sevdiğim yemekler:\nİskender\nMantı"

//Yeni kullanım:
let yeniString = `En sevdiğim yemekler:
İskender
Mantı`
```
- **İnterpolasyon:**

`İnterpolasyon`, metin içerisinde değişken kullanmak anlamına gelir. Normal dizeler içerisine ifadeler gömmek için kullanılır.
```js
let ad= `Aycan`;
let soyad= `Yerdelen`;

//Eski kullanım
console.log("Benim adım "+ad+" "+ soyad);

//Yeni kullanım
console.log(`Benim adım ${ad} ${soyad}`);
```
→ Örnek:
```js
let a = 99;
let b= 999;

console.log(`${a} çarpı ${b} eşittir ${a*b}`);

//Çıktı: 
//99 çarpı 999 eşittir 98901
```

- **HTML Şablonları**

Çok satırlı dizeleri kolaylıkla kullanmak ve dizelerimize içerik eklemek için de Template Literal’den faydalanabiliriz.
```js
//Değişkenlerimizi tanımlayalım
const ad =`Aycan`
const soyad =`Yerdelen`
const gozRengi =`Kahverengi`
const yas =21
```
→ Eski kullanım, Template Literals kullanmadan:
```js
const kisi = "<p>"+ad+"</p>"+
              "<p>"+soyad+"</p>"+
              "<p>"+gozRengi+"</p>"+
              "<p>"+yas+"</p>"

document.body.innerHTML = kisi;
```

→Yeni kullanım, Template Literals kullanarak:
```js
const kisi = `
<p>${ad}</>
<p>${soyad}</>
<p>${gozRengi}</>
<p>${yas}</>
`;

document.body.innerHTML = kisi;

//Bu kullanım daha az karmaşık ve okunabilir.
```

## **Kısaca**
**`Template Literals;`**

- Kod okunabilirliğini kolaylaştırır,

- Stringler içerisinde değişken yazma kolaylığını sağlar,

- Şablon etiketlerini daha az karmaşık hale getirir.
