# **12'lik Izgara(Grid) Sistemini Anlamak**
Bootstrap, sayfa düzeni `(layout)` oluşturmak için, CSS `flexbox` ile oluşturulmuş ızgara `(grid)` sistemini kullanmaktadır.

## Bootstrap ızgara sistemi 3 ana yapıdan oluşur:

- Kapsayıcı (.container)
- Satırlar (.row)
- Kolonlar (col-*) (Örnek: .col-md-8)

Her bir sütun, 12 kolondan meydana gelmekte ve `12'lik Grid sistemi` oluşturmaktadır. 12'lik ızgara sisteminde, kolon sayısı varyasyonları ile istenildiği gibi tasarım yapılabilmektedir.

![Grid Yapısı](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/12lik-izgaragrid-sistemini-anlamak/figures/izgara-sistemi.jpg)

## **Öntanımlı Kolon Sınıf Adları**

Her ölçüdeki cihaza uyumlu `(responsive)` tasarımın oluşturulması için Bootstrap'te öntanımlı kolon sınıfları `(class)` kullanılır.

## **Bootstrap kolon sınıfları**

![Kolon Sınıfları](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/12lik-izgaragrid-sistemini-anlamak/figures/ornekler.jpg)

### **Eşit Kolonlar**

Eşit kolonlu tasarım için;
```
12 adet 1'er kolon (.col-[sınıfAdı]-1)
6 adet 2'li kolon (.col-[sınıfAdı]-2)
4 adet 3'lü kolon (.col-[sınıfAdı]-3)
3 adet 4'lü kolon (.col-[sınıfAdı]-4)
2 adet 6'lı kolon (.col-[sınıfAdı]-6)
1 adet 12'li kolon (.col-[sınıfAdı]-12)
```
 oluşturulabilir.
Ya da `col` sınıfına sahip element sayısına göre (Örneğin; 3 adet `.col` sınıfı olan elementler 3 adet kolon oluşturur) otomatik olarak eşit kolonlara bölünebilir.

### **Eşit Olmayan Kolonlar**
Kolon sayılarının 12'ye tamamlanma zorunluluğu yoktur. Tasarıma göre istenilen sayıda kolonlar oluşturulabilir ve istenilen yerlerde boşluk bırakılabilir.

1 adet 2'li kolon (`.col-[sınıfAdı]-2`) ile 1 adet 10'lu kolon (`.col-[sınıfAdı]-10`) ya da 1 adet 8'li kolon (`.col-[sınıfAdı]-8`) ile 1 adet 4'lü kolon (`.col-[sınıfAdı]-4`) 12'ye tamamlanabilir.

Tek bir adet 8'li kolon (`.col-[sınıfAdı]-8`), tek bir adet 6'lı kolon (`.col-[sınıfAdı]-6`) ya da 1 adet 4'lü kolon (`.col-[sınıfAdı]-4`) ile 1 adet 5'li kolon (`.col-[sınıfAdı]-5`) kolon 12'ye tamamlanmadan bıraklabilir. Böylece eksik bırakılan kolon değeri kadar yan tarafta boşluk kalmış olur.

Verilen kolon değerlerinin toplamı 12'den fazla olması durumunda son kolon bloğu bozmayacağı için alt tarafa geçer.

 Örnek olarak;

>1 adet 8'li kolondan sonra 1 adet 6'lı kolon değeri verilir ise 8 + 6 = 14 toplam kolon sayısı 12'den büyük olacağı için 6'lı kolon 8'li kolonun altına geçer.

Kolonların arasında da boşluk bırakmak mümkün. Bunun için `col` sınıfının yanına öntanımlı `margin` ve `margin yönünü` (`ml-auto` gibi) belirten bir sınıf adı daha eklenmelidir. Kolonun solunda boşluk bırakmak için `margin (m) left (l)` yani `ml-auto` sınıfı eklemeli, aynı şekilde sağ tarfında boşluk bırakılmak istenirse `margin (m) right (r)` yani `mr-auto` sınıfı eklemelidir.

### **Kolonların Sıralanması**
Öntanımlı order-[sıra numarası] sınıfını ekleyerek kolonları sıralayabiliriz.

Örneğin; col-3 order-3 üç kolonluk bölümü üçüncü sıraya yerleştirecektir.

```html
<div class="row">
    <div class="col-3 order-3">3 Kolon</div>
    <div class="col-4 order-2">4 Kolon</div>
    <div class="col order-1">5 Kolon</div>
</div>
```

### **İç İçe Izgara sistemi**
Bir satırdaki `(row)` kolonun `(col)` içine başka bir satır eklenerek yine kolonlara bölünebilir.

Örneğin; 4'lük bir kolon (`.col-[sınıfAdı]-4`) ile 8'lik bir kolondan (`.col-[sınıfAdı]-8`) oluşan satırdaki 8'lik kolonun içinde yeni bir satır (row) eklenerek 2 adet 6'lık kolon (`.col-[sınıfAdı]-6`) oluşturulabilir.