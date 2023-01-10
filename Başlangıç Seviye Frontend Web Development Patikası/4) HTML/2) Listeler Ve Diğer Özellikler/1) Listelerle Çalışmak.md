# **Listeleme Etiketleri**
Listeleri iki ana başlık altında listeleyebiliriz;

- Sıralı Listeler
- Sırasız Listeler

## **Sıralı Listeler**
Sıralı listeler ardışık liste numaraları vermek için kullanılır. Sıralı listelerden yararlanmak için `<ol>` etiketi kullanılır.
```html
    <p> Gerçek <b>tereyağı</b> nasıl anlaşılır ?</p>
    <ol>
        <li>Oda sıcaklığında tamamen erimez</li>
        <li>Suyun içinde tek parça halinde çözünür</li>
        <li>Tereyağı rengi sarı yada beyaz olabilir</li>
    </ol>
```

Liste başındaki sıralandırmayı rakamdan başka roma rakamı veya alfabetik şeklinde de yapabiliriz. Bunun için type özelliğini kullanmamız gerekir.
>Roma Rakamı
```html
<ol type="I">
  <li>Javascript</li>
  <li>C#</li>
  <li>Php</li>
</ol>
```
>Alfabetik
```html
<ol type="A">
  <li>Javascript</li>
  <li>C#</li>
  <li>Php</li>
</ol>
```


## **Sırasız Listeler**
Sırasız listeler numaralandırma olmadan oluşturduğumuz listeleredir. Her bir liste elemanı bir satırı kaplayacak şekilde yani blok etiket şeklinde oluşturulur.
```html
<ul>
  <li>Çay</li>
  <li>Türk Kahvesi</li>
  <li>Süt</li>
</ul> 
```
Ekran çıktısı:

- Çay
- Türk Kahvesi
- Süt

şeklinde olur. Liste elemanlarının başındaki içi dolu daireyi değiştirebilir veya silebiliriz.

**Silmek İçin:**
```html
<ul style="list-style-type:none">
  <li>Çay</li>
  <li>Türk Kahvesi</li>
  <li>Süt</li>
</ul>
```
Ekran çıktısı:​ 

Çay

​Türk Kahvesi

​Süt

şeklinde olur. Liste başındaki içi dolu daireyi değiştirmek için ise *disc*, *square*, *circle* değerlerini kullanabiliriz.
```html
<ul style="list-style-type:square">
  <li>Telefon</li>
  <li>Bilgisayar</li>
  <li>Yazıcı</li>
</ul>
```