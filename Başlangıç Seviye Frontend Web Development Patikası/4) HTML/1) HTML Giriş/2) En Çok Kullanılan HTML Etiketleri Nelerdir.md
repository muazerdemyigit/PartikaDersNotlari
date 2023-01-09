# En Çok Kullanılan HTML Etiketleri Nelerdir?

- Etiketler küçüktür ve büyüktür işaretlerinin arasına yazılarak başlar (örn. `<etiket>`) içeriği yazdıktan sonra etiketi kapatmanız gerekir. 
- Etiketi kapatmak için `küçüktür, slash, etiket, büyüktür` şeklinde yazılmalı (örn. `</etiket>`) Bütün bir örnek yapmak gerekirse (örn. `<etiket> İçerik Yazılacak Alan </etiket>`)

>Not: Bazı etiketler kapanmaya ihtiyaç duymazlar (örn. `<br>, <hr>, <meta>` vs.)

## **HTML Etiketi**
- HTML etiketi, dosya içeriğinin HTML dilinde yazıldığını tarayıcımıza bildirir.
- Bu etiket, kendi altında mutlaka `<head>` ve `<body>` etiketlerini barındırmalıdır. 
- Eğer bir HTML dökümanı oluşturmak isterseniz ilk yapacağınız iş bir `<html>` etiketi oluşturmaktır. 
- Ardından HTML etiketi altına `<head>` ve `<body>` etiketlerini yazmalısınız.
```html
<html>
  <head></head> 
  <body></body>
</html>
```
## **HEAD Etiketi**
- `<head>` etiketi, site ziyaretçileri tarafından görülmesi *gerekmeyen* kodları içerir. 

- Bu etiket altına yazılan kodlar genellikle arama motorları ve örümcekler (Crawler veya Spider diye geçer) içindir.

> Head etiketi altında bütün etiketleri kullanabilmeniz mümkün değil. Kullanabileceğiniz etiketler;
```html 
<title> (Bu etiketi kullanmak şarttır)
<meta>
<style>
<script>
<noscript>
<link>
<base>
```

## **BODY Etiketi**
Web sayfamızda görmek istediğimiz bütün içerikleri `<body>` etiketi altına yazıyoruz. Anlatacağım diğer etiketleri <body> etiketi içerisine yazacağız.


>Not: Şu ana kadar oluşturduğumuz yapıyı VSC üzerinde "! + Enter" yazarak hızlıca oluşturabilirsiniz.

`<!DOCTYPE html>` : Dökümanımızın HTML dilinde olduğunu tarayıcımıza bildiren talimattır.

`<html lang="en">` : Site içeriğinin dilini belirten etiket, "en" yerine "tr" yazabilirsiniz.


## **H Etiketleri**
H etiketleri başlık etiketleridir. Büyükten küçüğe sırasıyla;
```
<h1>
<h2>
<h3>
<h4>
<h5>
<h6>
```
şeklindedir.

>Not: HTML otomatik olarak Başlık etiketlerinin öncesine ve sonrasına satır atlatır.

## **P Etiketi**
`<p>` etiketi paragraf etiketidir. Sayfa içerisinde oluşturacağımız metinleri `<p>` etiketi ile oluştururuz. 

>Not: HTML otomatik olarak Paragraf etiketinin öncesine ve sonrasına satır atlatır.


## **BR Etiketi**
`<br>` etiketi satır atlatma etiketidir ve kapatmaya ihtiyaç duymayan etiketlerden biridir. Atlatmak istediğiniz satır sayısı kadar `<br>` etiketi kullanabilirsiniz. 
>Not: BR etiketinin farklı kullanımlarını görebilirsiniz. örn.(`<br>`,`<br/>`,`<br />`) Hepsi aynı işlevi yerine getirir.


## **A Etiketi**
`<a>` etiketinin en önemli özelliği ***href*** özelliğidir. Bu etiket ile sayfaları linkleyebiliriz. Etiket içerisine yazılan içerik sayfa üzerinde gösterilecek içeriktir. href içine yazılan ise tıklandığında gideceği URL'dir.

>` <a href="https://www.kodluyoruz.org">Kodluyoruz</a>`

## **UL - OL - Li Etiketi**
`<ul>` ve `<ol>` etiketleri liste oluşturma etiketleridir. Listeyi oluşturduktan sonra içeriğini oluşturmak için `<li>` etiketini kullanıyoruz.

- `<ul>` = "unordered list" sırasız liste anlamına geliyor. 
- `<ol>` = "ordered list" sıralı liste anlamına geliyor.

   ```html
    <ul>
        <li>HTML</li>
        <li>CSS</li>
        <li>JavaScript</li>
    </ul>
    
    <ol>
        <li>HTML</li>
        <li>CSS</li>
        <li>JavaScript</li>
    </ol>
    ```
</body>
</html>

## **HR Etiketi**

`<hr>` etiketi konusal bir geçişi temsil eder. Yazı yazarken yeni bir paragrafa başlamaya benzetebiliriz. Varsayılan olarak sayfaya yatay bir çizgi ekler ama bu özelliği değiştirilebilir. Bu etiket kapatılmaya ihtiyaç duymaz.


## **STRONG ve B Etiketi**
`<strong>` etiketi bir metinin arama motorlarına önemli olduğunu bildirmek için kullanılır. Kullanıldığı zaman metini kalın yapar. Eğer sadece metini kalınlaştırmak isterseniz `<b>` etiketini kullanabilirsiniz.


## **Script Etiketi**
`<script>` etiketi JavaScript kodlarını HTML içerisine yazabilmemizi sağlar.


## **Button Etiketi**
`<button>` etiketini buton oluşturmak için kullanırız. Buton üzerine yazmak istediğiniz içeriği etiketin içine yazmanız yeterlidir.


## **img Etiketi**
Resim eklemek için `<img>` etiketini kullanıyoruz.

 `<img src=”resim.jpg” alt=”açıklama yazısı” /> src=""` kısmına eklemek istediğimiz görselin yolunu yani kaynağını yazmalıyız. Eğer görselimiz ve HTML dosyamız aynı klasörde ise görselin adını ve uzantısını yazmamız yeterlidir. `alt=""` kısmına görselin açıklamasını yazıyoruz fakat isterseniz boş bırakabilirsiniz. Bu etiket kapanmaya ihtiyaç duymaz.


## **iframe Etiketi**
Belge içinde belge gösterebilmemizi sağlayan etikettir. Genelde başka bir sitedeki belgeyi kendi sayfamızda göstermek için kullanırız. 

>örn: Youtube'dan bir videoyu sayfamızda göstermek istersek `<iframe>` kodlarını sayfamıza eklememiz yeterli.(video üzerinde sağ tıklayıp yerleştirme kodunu kopyala diyerek iframe kodunu kopyalayabiliriz.)


## **Yorum Satırı**
HTML dilinde yorum satırı `<!--` ile başlar `-->` ile biter.


```
    <!-- Örnek Yorum Satırı -->
    
    <!-- 
        2. Örnek Yorum Satırı 
    -->   
```
