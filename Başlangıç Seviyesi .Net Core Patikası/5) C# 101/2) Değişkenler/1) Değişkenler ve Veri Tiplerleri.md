# **Değişkenler**

## **Değişken Nedir?**

Değişkenler bizim uygulama geliştirirken kullandığımız veri tutucularımızdır. Kullandığımız verinin tipine ve büyüklüğüne bağlı olarak doğru veri tipini seçiyor olmak önemli. Örneğin sadece tek bir karakter tutmaya ihtiyacımız varsa o veri için `Char` veri tipinizi tanımlamak yeterli olacaktır. `String` tipinde bir değişken kullanmak gereksizdir. Uygulamanın performansı açısından doğru veri tiplerine karar verebilmek önemlidir.

- ### **Değişken tanımlama yapısı :** `(Değişken Türü) (Değişken Adı) = (Değeri)`

- ### **Değişken tanımlarken dikkat edilmesi gereken bazı hususlar şu şekilde:**

- Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
- Değişken isimleri rakamlarla başlayamaz.
- Değişken isimleri boşluk içeremez. Yalnızca "`_`" ifadesi kullanılabilir.
- Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
- `Class namespace` gibi özel isimler kullanılamaz.
- Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa `null` tanımlanmalıdır. Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.