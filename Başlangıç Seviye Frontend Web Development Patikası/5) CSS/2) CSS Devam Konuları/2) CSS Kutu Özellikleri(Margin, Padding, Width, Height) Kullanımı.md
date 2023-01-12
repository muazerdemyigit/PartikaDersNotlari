# **CSS Kutu Özellikleri(Margin, Padding, Width, Height) Kullanımı**
CSS kutu özelliklerini iyi kavrayabilmek ve kullanabilmek için `"kutu model"` konusunu incelemek gerekir. Gelin önce `"kutu modeli"` konusuna bakalım.
>`padding` kutu içi, `margin` kutular arası, `float` kutuların dizilimini belirliyor.

**Kutu modeli margin,padding,border ve içerikten oluşur.**

- **`İçerik(content)`**: Elementin içinde olan resim, ses ya da yazıdır.

- **`Padding`**: İçerik ile border arasında olan boşluk.

- **`Border`**: Padding ile margin'i ayıran sınırdır.

- **`Margin`**: Kutunun diğer kutularla arasındaki mesafeyi ayarlayan boşluk.

Yukarıda saydığım kavramların dışında kutunun boy ve uzunluğunu belirleyen `width` ve `height` kavramları vardır. Bunları da alıştırmalarımızda göstermeye çalışacağım.

## **`width` ve `height`**
`width` ve `height` özellikleri ile elementin, yani lego parçamızın boy ve genişliğini ayarlayabiliriz. Bu özellikleri biz yazmadığımız takdirde tarayıcı kendisi ayarlar ve yapacağımız web uygulamasında istenmeyen sonuçlara neden olur. Bu özellikleri `px`, `em` veya `%` ile kullanabiliriz.`%` ile kullandığımız zaman elementimiz hangi elementin içindeyse ona göre oranlanır. Yani `800px` boyunda bir `<div>` tag'inin içinde bulunan bir elementin boyunu `50%` olarak ayarlarsanız elementin boyu 400px olur.

**`Max-width`** özelliği ise bir elementin genişliğini sınırlamak istediğimizde kullanırız. Diyelim ki bir element tarayıcı ekranından fazla geniş veya uzun. Bu durumda `scrollbar(kaydırma çubuğu)` çıkar.

Alıştırma-1: `Width ve Height` Kullanımı

```css
<style>
   p{
   width: 0;
   height: 0;
   }
<style>
```
```html
<p>
Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
</p>`
```
Bu kodda `width` ve `height`'i 0 yaptım. Paragraf tuhaf bir şekilde görünecektir. Bu alıştırmada yapmanız gereken şey paragrafın düzgün görünmesi açısından `width` ve `height`'i istediğiniz şekilde kullanın. Burada `width` ve `heigth`'i görmeniz için `%` ve `px` in ikisini de kullanmanızı tavsiye ediyoruz..

## **`margin ve padding`**
### **`margin`**

`Margin` özelliği ile elementin dışında boşluk oluşturmada kullanıldığını öğrenmiştik. Şimdi nasıl kullanıldığını açıklamaya çalışacağız.

`margin` özelliğini `50px` yaptığınızda elementin dört yanında `50px` boşluk oluşturulur. Element sağa doğru kayar. Negatif değerler de kullanılabilir. margin değerine `-50px` yazdığınız takdirde element sola doğru kayacaktır. Dört yanında değil de sadece bir yönde boşluk oluşturmak isteyebilirsiniz. Bunun için de özellikler vardır.

```css
margin-left: Soldan boşluk bırakır.
margin-top: Yukarıdan boşluk bırakır.
margin-bottom: Aşağıdan boşluk bırakır.
margin-right: Sağdan boşluk bırakır.
```
Bu değerleri tek bir satırda ayarlamanız mümkündür.

`margin: 100px 150px 60px 50px;` 


Bir elementi ortalamak için `margin:auto` değeri vermelisiniz. Bunun düzgün çalışması için de `width` özelliğinin de kullanılmasını öneririm. Böylelikle sağdan ve soldan eşit olarak ortalanmış olur. Aksi halde boyutu belli olmayan bir kutuyu ortalamayabilir.

### **`padding`**
Şimdi gelelim `padding` özelliğine. Elementin içindeki yazıların çerçeve`(border)` ile mesafesini `padding` ile ayarlarız. `margin` özelliğinde olduğu gibi `padding:50px` yaptığımızda içeriğin her tarafı için `50px` boşluk bırakıyoruz. Belirli bir tarafta `padding` bırakmak için;
```css
padding-top: içeriğin yukarısında boşluk bırakır.
padding-bottom: içeriğin aşağısında boşluk bırakır.
padding-left: içeriğin solunda boşluk bırakır.
padding-right: içeriğin sağında boşluk bırakır.
```
Bunları tek tek tanımlamak yerine tek bir satırda belirlemek mümkündür.

```css
padding: 10px 20px 30px 40px;
/* Burada üst boşluk 10px,sağ boşluk 20px,alt boşluk 30px ve sol boşluk 40px dir.*/
padding: 10px 20px 30px;
/* Üst boşluk 10px,sağ ve sol boşluk 20px,alt boşluk 30px dir. */
padding: 10px 20px;
/* üst ve alt boşluk 10px,sağ ve sol boşluk 20px */
```
