# **Document Object Model (DOM) Nedir?**

`W3C(World Wide Web Consortium)`'e göre `Document Object Model`, programların ve komut dosyalarının bir belgenin içeriğine, yapısına ve stiline dinamik olarak erişmesine ve güncellemesine izin veren bir platform ve dilden bağımsız bir arayüzdür.

Bir HTML belgesini iç içe geçmiş kutular olarak hayal edebilirsiniz. `<body>` ve `</body>` gibi çevreleyen etiketler, sırayla başka etiketler veya metinler içeren diğer etiketleri kapsar.

Tarayıcının belgeyi temsil etmek için kullandığı veri yapısı bu şekli izler. Her kutu için, hangi HTML etiketini temsil ettiği ve hangi kutuları ve metni içerdiği gibi şeyleri bulmak için etkileşime girebileceğimiz bir nesne vardır. Bu temsil, `Document Object Model` veya kısaca `DOM` olarak adlandırılır.

`DOM`’da `HTML` ile hazırladığınız sayfa, `document;` bu `document`'in içine yerleştirdiğiniz her türlü öğe ise element olarak adlandırılır. `DOM`'da nesnelerin birer element olarak kullanılabilmesi için hiyerarşik bir düzen izlenerek çağrılmaları gerekir. `HTML`’deki her bir elamanın birbiri ile hiyerarşik bir yapı oluşturması ile oluşur. `DOM` bir ağaç dizini gibi bütün dokümanları birbirine bağlar.

![DOM Tree](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/javascript/javascript-temel/document-object-model-dom-nedir/figures/dom-tree.png)
```html
<!doctype html>
<html><head><title>My home page</title></head><body><h1>My home page</h1><p>Hello, I am Baran and this is my home page.</p><p>Click to review my resume
      <a href="http://balin.me/cv.pdf">balin.me</a>.</p></body>
</html>
```
Bu sayfa aşağıdaki yapıya sahiptir:

![HTML boxes](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/javascript/javascript-temel/document-object-model-dom-nedir/figures/html-boxes.jpg)

**HTML ağacı olarak:**

![HTML document as a tree](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/javascript/javascript-temel/document-object-model-dom-nedir/figures/html-boxes.jpg)

Dosya oluşturmak, elementleri ve içeriklerini silme/ekleme gibi fonsiyonları vardır.

Örneğin;
```html
<html><head><titte>Form</titte><script type="text/javascript">document.formAdi.isim.value = 'Baran Balin';
           document.getElementbyId('yas').value = '25';
       </script></head><body><form name="formAdi" method="post" action=""><input type="text" name="isim"><input type="text" id="yas"></form></body>
</html
```
HTML içerisine yerleştirilmiş öğeleri çağırmak için, içinde bulunduğu diğer öğelerin çağrılması bir yöntem iken, bir öğeye bir `id` vererek bu `id` üzerinden çağırmak da bir başka yöntemdir.

`JavaScript` kodumuzun ilk satırında metin kutusunun değeri hiyerarşik olarak çağrılmış ve değiştirilmiştir. İkinci satırda ise hiyerarşik yapı daha az önemsenerek `JavaScript` içindeki `DOM`’un temellerinden olan `getElementById` metodu kullanılmıştır.

Sonuç olarak eğer `client-side` olarak `HTML`’e daha fazla hükmetmek istiyorsanız, kullandığınız dil ne olursa olsun kesinlikle `DOM` un erişim yöntemlerini çok iyi biliyor olmanız gerekir.
