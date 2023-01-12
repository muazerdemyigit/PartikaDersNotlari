# **CSS Nedir?**


## **`CSS(Cascading Style Sheets)` Nedir?**
`CSS (Basamaklanmış Stil Katmanları)`, web sayfasını şekillendirmek için kullanılan bir kodlama türüdür. 
- CSS kullanarak web sayfasının görünümünü ve düzenini değiştirebiliriz.
- Bir web sitesinin görünümünün masaüstü bilgisayarlar, tabletler ve mobil cihazlar gibi farklı ekranlarda nasıl değiştiğini de tanımlayabiliriz. 
- CSS, C++ veya JavaScript gibi bir programlama dili değildir. Bunun nedeni, CSS'in amacının web tarayıcıları için biçimlendirmeye(HTML'e) stil vermek olmasıdır. HTML yalnızca içeriği "işaretleyen" bir dildir - yani, belgeye belirli bir görsel ve yapısal biçimlendirme verir.



Hem HTML hem de CSS doğaları gereği bildirimseldir. Bu, yalnızca bir şeyleri açıkladığı ve herhangi bir işlem yapmadığı anlamına gelir. 

Tarayıcılar CSS'i görüntüleme için yorumlarken, bunu doğrusal bir şekilde yapar. Bunun nedeni, CSS'in dosyayı yukarıdan aşağıya okuyan tarayıcıya talimatlar vermesidir. Bir kural belirlendiğinde ve daha sonra dizin aşağıya doğru değiştirildiğinde, tarayıcı ekranda görüntülenecek nihai sonuç olarak en son değerlendirmeyi alır. CSS'deki C'nin ifade ettiği şey budur. CSS'in `cascade(kaskad)`etkisi, tarayıcıyı, kuralın fiziksel olarak ne zaman gerçekleştiğine bağlı olarak, kuralları art arda ve geçersiz kılacak şekilde görüntüleyecek şekilde ayarlar.`Cascade(kaskad)`, öğe için birden çok CSS bildirimi ve birden çok stil sayfasının bir kombinasyonu olduğunda, belirli bir öğe için uygulanan stiller arasındaki çakışmayı çözme anlamına gelir. Sonuç olarak, CSS göründüğü kadar kolay değildir. Anlamadan kullanmaya çalışırsanız web geliştirmede zorluk yaşarsınız. Bu nedenle, CSS öğrenmek bir programlama dili öğrenmek kadar önemlidir.



## **`CSS Syntax`**
İlk CSS kodumuzu yazalım. Örneğin, h1 etiketinin rengini değiştirmek istiyorum.
```html
<h1>I'm a Header</h1>
```

Öncelikle, CSS'e HTML öğesini nasıl bulacağını söylememiz gerekir. Bunu `selector` denen bir özellik ile yapabiliriz. CSS'de bir selector, HTML öğelerini etiket adı, sınıf adı, kimliği ve çok daha fazlasına göre bulmak için kullanılır.

O zaman şimdi HTML öğesi için bir selector tanımlayalım ve ardından selector parantezleri arasında her biri noktalı virgülle biten CSS kurallarını bildirelim.
```css
h1 { color: red;  }
```

Böylelikle, tanımlı `selector`'e `(h1)` bağlı olarak, CSS artık yeni kuralların nereye uygulanacağını anlayabilir.

Bunların yanı sıra CSS kodlarımızı `.css` uzantılı bir dosya içerisinde tutar ve bu dosyayı HTML sayfası içerisine basit bir kodla çağırabiliriz.

Örneğin CSS dosyamızın adı "`hello.css`" olsun ve bu dosyayı Html sayfaya eklemek için HTML içine yazmamız gereken kod şu şekildedir.
```html
<head> <link rel=”stylesheet” type=”text/css” href=”hello.css” /> </head>
```
Bir CSS selector tanımlamanın birçok farklı yolu vardır, aşağıda selector türlerinin bazı örneklerini görebilirsiniz:

- **`Class Selector`**: HTML öğelerini sınıf özelliklerine göre bulur.
- **`ID Selector`**: Öğeleri belirli kimliğine göre bulur.
- **`Element Selector`**: Öğeleri etiket adlarına göre bulur.

CSS teknik olarak kolaydır. Anlaşılması gereken sınırlı sayıda kural vardır. Bununla birlikte, CSS'i zorlaştıran potansiyel kural kombinasyonudur. Görsel gereksinimler daha karmaşık hale geldikçe, CSS kurallarınızın sürdürülebilirliğini kontrol altında tutmak için yaratıcı ancak yapılandırılmış çözümlere ihtiyaç vardır