# **DOM'a CSS Class Bilgisi Eklemek veya Çıkarmak**

## **`ClassList`**

JavaScrip’te `CSS class`'larını manipüle etmenin en iyi yollarından biri `classList` kullanmaktır. `classList` bir öğenin sınıf isimlerini `DOMTokenList` olarak döndürür. `classList` özelliği tüm modern browserlarda çalışır.

## **`Syntax`**
```js
const elementClasses = elementNodeReference.classList;
```
## **`Properties`**
```html
<div id="content" class="main red">JavaScript classList</div>
```

- `add()` : `HTML` öğesine bir veya daha fazla `class` ekler.

```js
let div = document.querySelector('#content');
div.classList.add('info');
```
Yukarıda `content id`'li ögeyi seçtik ve ona `info class`'ını ekledik.

```js
let div = document.querySelector('#content');
div.classList.add('info','visible','block');
```
Tek seferde birden fazla da `class` ekleyebiliriz.

- `remove()` : `HTML` öğesinden bir veya daha fazla `class`'ı siler.
```js
let div = document.querySelector('#content');
div.classList.remove('info');
```
Yukarıda `content id`'li ögeyi seçtik ve ona ait `info class`'ını kaldırdık.

- `item()` : `HTML` de `class`'ı verilen `index` sırasına göre döndürür. Eğer `index`, `class length`'inden (sayısından) daha büyük veya `length`'ine eşit olursa `undefined` döner.
```js
let div = document.querySelector('#content');
div.classList.item(0);
```
Yukarıda `content id`'li ögeyi seçtik ve ona ait ilk `class`'ı çağırdık.

- `contains()` : Element verilen `class`'ı içeriyorsa `true`, içermiyorsa `false` döner. Bu sayede bir işlem yaptırmadan önce kontrol edebiliriz.
```js
let div = document.querySelector('#content');
div.classList.contains('warning');  
```
- `Toggle()` : `classList.add()` ve `classList.remove()` yöntemini aynı anda çağırmak yerine `classList.toggle()` yöntemini kullanılabilir.
Bu metodu kullanmadan önce `contains()` metodu ile sınıfın var olup olmadığını manuel olarak kontrol etmek gerekir.
```js
let div = document.querySelector('#content');
div.classList.toggle('visible');
```
- `replace()` : Bir `CSS` sınıfını başka bir sınıfla değiştirmek için kullanılır.
```js
let div = document.querySelector('#content');
div.classList.replace('info','block');
```
- `length()` : Bir öğede bulunan sınıf sayısını bilmemizi sağlar.

