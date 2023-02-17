# **`ArrayList` Nedir ?**


Standart dizilerde aynı tipte verileri verileri bir arada tutabileceğimizi ve dizinin boyutunun belirtilmesi gerektiğinden bahsetmiştik. `Arraylist` tam olarak bu noktada farklılaşıyor. Farklı veri tiplerini `array list` içerisinde saklayabilirsiniz. Ve eleman ekleyerek ve çıkararak boyutunu dinamik olarak değiştirebilirsiniz.



Varsayılan boyutu başlangıç olarak 4'tür. Aşıldığında otomatik olarak 2 katına çıkarılır. Yani bir `array list`'e 5. elemanı eklemeye çalıştığınızda arka planda boyutunu 8'e çıkarır.



Örnek:
```csharp
ArrayList dizi = new ArrayList();

dizi.Add("Kedi");
dizi.Add(99);
dizi.Add(true);
```
Yukarıdaki örnekte tanımladıgımız `ArrayList` içerisine `string`, `integer` ve `bool` veri tipindeki verileri aynı koyduk.



Değişken veri tipi kullanımı kulağa ilk etapta çok konforlu gelse de risk barındır. Listeden okudugunuz verinin tipinin ne olduğunu bilmemek güvenli bir yaklaşım değildir. Tip dönüşümleri sırasında hata ihtimalini arttırır.