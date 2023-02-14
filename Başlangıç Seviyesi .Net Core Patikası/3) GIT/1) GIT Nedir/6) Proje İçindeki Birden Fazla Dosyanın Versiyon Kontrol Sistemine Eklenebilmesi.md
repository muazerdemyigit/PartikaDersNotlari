#  Proje İçindeki Birden Fazla Dosyanın Versiyon Kontrol Sistemine Eklenebilmesi

.gitingore dosyamız varsa ve düzgün bir şekilde içini düzenliyorsak tüm dosyaları tek seferde ```git add``` komutu ile birlikte versiyon kontrol sistemine ekleyebiliriz.

```git add .``` komutu ile bütün dosyalar tek seferde eklenebilir.

Önceki işlemlerime geri dönüp bakmak için sol alt kısımdaki ***timeline*** bölümüne bakmalıyız. 

İşlemlerimizde değişiklik olmadan yeni işlemler yapmak için yeni bir *branche* açabiliriz. Bunun için *source control* bölümünden üç noktalı menüden ***branche> create branche*** demeliyiz.

Oluşturduğumuz branche ile *master*’i birleştirmek için öncelikle master branch’ine geçiş yapıp daha sonra terminalde ``` git merge “öbür branche adı” ``` kalıbı kullanılır.
