# **Görsellerle Çalışmak**

HTML sayfasına resim eklemek için `<img>` tagi kullanılır.

## **`src=""` Kullanımı**

Kod bloğundaki `src=""` özelliğine görselin URL ya da dosya adresi belirtilerek resim HTML sayfasına çağırılır. (Resmi webden çağırmak için resmin URL'ini `src=”…”` parametesine eklemek yeterlidir.)
```html
<img src="ornek.jpg"/>
```
Yukarıdaki örnekte resim HTML dosyasıyla aynı dizinde(klasörde) olduğu için direkt adını ve uzantısını yazmak yeterlidir. Burada `img` uzantısına dikkat etmek önemli, HTML dosyaları nasıl `.html` ile bitiyorsa tüm resim dosyalarının sonu da `.xbm`, `.gif`, `.png` veya `.jpg` ile veya başka bir resim formatıyla bitmelidir.

## **Yaygın Image Formatları**
Diyelim ki projenin içerisinde bir dizin oluşturdunuz (images) ve resminizi bu dizine eklediniz. Bu defa çağırmak için öncelikle images dizinine gitmek gerekiyor.
```html
<img src="images/ornek.jpg"/> 
```
Ya da resim bir üst dizinde kalıyor olabilir. Bu durumda bir üst dizine çıkıp images dizinini bulup resmi çağırmak gerekiyor. (Üst dizine çıkmak için `../` kullanırız.)
```html
<img src="../images/ornek.jpg"/>
```
Bu şekilde istediğiniz kadar üst dizine çıkabilirsiniz.
```html
<img src="../../images/ornek.jpg"/>
```
## **`alt=""` Kullanımı**
`Alt text`lerin temel amacı, görüntüleri göremeyen kullanıcılar için metinler sunmaktır. Kullanıcı görseli görüntüleyemez ise (Yavaş bağlantı, src özelliğinde hata vb.) alt özelliği görüntü için alternatif bilgilendirici bir metin içerir.
```html
<img src="../images/kedi.jpg" alt="Yavru Kedi"/>
```
## **`title=""` Kullanımı**
`Title` özelliği kullanıcıyı bilgilendirme amacı taşır. `Cursor`(mouse imleci) ile görselin üzerine gelince bu özelliğe verilen text mesajı görünür. Ek açıklama gerektirecek resimlerde kullanabiliriz. Bilgilendirme amacı taşır.
```html
<img src="../images/kedi.jpg" title="image"/>	
```
>NOT: Title ve Alt parametreleri SEO açısından önem taşımaktadır.

## **`width` ve `height` Kullanımı**
Görsele istenen ölçüleri vermek için `width` ve `height` özellikleri kullanılır.

`Width` yatay genişlik, `Height` ise dikey uzunluk için kullanılır.

- Width ve Height özellikleri tanımlanmadığı zaman görsel sayfada gerçek ölçüleri ile görünür. 

- Bu ölçülerden yalnızca birine değer verildiğinde görsel oranları korunarak belirlenen ölçüde görünür.

- Her iki özelliğe de değer verildiğinde resim oranları yeni verilen ölçülerde olduğu gibi görünür. 

- Bu kullanım resim ölçüleri ile uyumlu olmadığı zaman resimde oransal bozukluklar oluşur.

```html
<img src="resim.jpg" width="300" />
<img src="resim.jpg" height="400" />
<img src="resim.jpg" width="300" height="600" />
<img src="resim.jpg" height="100%" />
```

## **`border` Kullanımı**
Görseli belirtilen kalınlıkta çerçeve içine alır. Daha gelişmiş `CSS Border` özelliği bunun yerine kullanılabilir.

Aşağıda border örneği: Görsele `3 pixel kalınlıkta border` verir.
```html
<img src="resim.jpg" border="3" />
```
## **`align` Kullanımı**
- Web sayfasında resmin gözükeceği pozisyonu belirlemede `align` özelliği kullanılır. 

- Bu özelliğe verilebilecek değerler şunlardır: `left`, `right`. 

- Görselin sağa veya sola yaslı çıkmasını sağlar.

```html
<img src="resim.jpg" align="right" />
```
## **Görsele Link Vermek**
- Görsele link vermek için `img` tag'i `a` taginin içerisinde kullanılır. 

- Yönlendirilmek istenen yerin URL'i `a` taginin `href` özelliğine yazılır. 

- Görsel ise `a` taginin açıklama kısmına eklenir.
```html
<a href="default.asp">
  <img src="smiley.gif" alt="HTML tutorial" style="width:42px;height:42px;">
</a>
```


## **`map` ve `area`**
- Görselleriniz `hyperlink` atamanız durumunda görselin tüm alanı link alanı haline dönüşecektir. 

- Görselin herhangi bir yerine tıklanılması durumunda görsel sizi tanımlanan bağlantıya gönderecektir. 

- `<img>` etiketleri için kullanılan `<map>` ve `<area>` etiketleri ile resmin içindeki koordinatlarla belirlediğimiz bir alanı sadece link haline getirebiliriz. 

- Eklediğimiz `<area>` etiketi kadar belirlenen alanı bir resim üzerinden birçok bağlantıya link verebiliriz.



## **`onload Event`'i Kullanımı**
Bu olay görsel yüklenmesi tamamlandığında çalışacak fonksiyonu belirler. Herhangi bir nedenle görsel yüklenemezse ya da belirtilen adreste resim yoksa fonksiyon çalışmaz.

Aşağıdaki örnekte görsel yüklenmesi tamamlandığında `resimYuklendi() `fonksiyonu çalışacak ve ekrana `Resim Yüklendi.` uyarısı `JavaScript` tarafından bastırılacak.

```html
<html>
    <body>
        <img src="resim.jpg" onload="resimYuklendi()" />
    </body>
    
    <script>
        function resimYuklendi(){
            alert("Resim yüklendi.");
        }
    </script>
</html>
```
## **`picture` Elementi ile Kullanım**
- `HTML5` ile gelen `picture` elementi web sayfamızda `responsive image`'ler kullanmamız konusunda büyük kolaylıklar sağlıyor. 

- Bir tane `img` ve birden fazla `source` içerebilir. 

- `picture` tagi ekran boyutlarına göre birden çok `source` kulllanmamızı sağlar bu sayede ekran boyutu değiştikçe farklı `image`'leri kullanabilirsiniz.

> Örnek: Burada ekran genişliğinin 800 pikselden küçük olduğu durumlarda başka diğer koşullarda ise başka bir görsel kullanılacak.
```html
<picture>
    <source srcset="https://cdn.sanity.io/images/9kdepi1d/production/65c832d202a503b15d99e628f4313782f3ef50db-300x62.png" media="(min-width: 800px)">
    
    <img src="/media/cc0-images/painted-hand-298-332.jpg" alt="" />
</picture>
```
Tarayıcı, her bir source öğesini inceleyip eşleşme sağlar. Eşleşme bulunamazsa veya tarayıcı `<picture>` öğesini desteklemiyorsa, `<img> `öğesinin `src URL`'si seçilir. Seçilen görüntü daha sonra `<img>` öğesinin kapladığı alanda sunulur.