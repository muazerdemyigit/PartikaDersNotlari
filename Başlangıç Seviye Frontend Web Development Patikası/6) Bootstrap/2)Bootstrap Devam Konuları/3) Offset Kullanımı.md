# **Offset Kullanımı**

Web sayfamızı tasarlarken sütunlarda yani `col` sınıfına sahip `div` elementlerinde boşluk oluşturma amacıyla sütunun sağ ve sol kısımlardan ittirilmesi için `offset` sınıfı kullanılır. Bir `Grid(Izgara)` yapısı 12 birimden oluşur, bundan dolayı yapıda taşma oluşmaması için `offset` sınıfı için verilecek değerde sütunun sahip olduğu `grid` boyutu da göz önüne alınmalıdır. `Offset` değer belirleme durumunun daha iyi kavranması açısından aşağıdaki örnekleri inceleyiniz.

>Not: `offset` ile `push` sınıfları birbiri ile karıştırılmamalıdır. Benzer bir kullanıma sahip olan `push` sınıfın `offset`'ten farkı sütun yapısında yalnızca soldan bir itme uygulamasıdır.

Örneğin:
```html
<div class="container">
    <div class="row bg-secondary mt-5" style="height: 100px;">
        <div class="col-md-10 offset-md-1 bg-warning font-weight-bold text-center pt-4" style="font-size: 20px;">
            .col-md-10 .offset-md-1
        </div>
    </div>
</div>
```
Yukarıda verilen kodun çıktısı:

![img1](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-offset-kullanimi/figures/img1.JPG)

Yukarıdaki örnekte `offset` için sağdan ve soldan toplam 2 birim ayrıldı. Eğer ki sütunun boyutu 8 birim olarak ayarlansaydı `offset` için verilebilecek en uygun değer 2 birim olacaktı. (Yani 2 birim baştan boşluk 8 birim sütun boyutu ve 2 birimde sondan boşluk olacak şekilde toplam 12!)

Örneğin:
```html
<div class="container">
    <div class="row bg-dark " style="height: 100px;">
        <div class="col-md-10 offset-md-2 bg-danger font-weight-bold text-center pt-4">.col-md-10 .offset-md-2</div>
    </div>
</div>
```
Yukarıda verilen kodun çıktısı;

![img2](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-offset-kullanimi/figures/img2.JPG)

Yukarıdaki örnekte sütun genişliği 8 birim, `offset` değeri ise sağdan 4 birim ve soldan 4 birim olarak verilmiştir. Fakat verilen değerler toplamı `Grid` yapısının alabileceği maksimum değerden fazla olduğu için `offset` ile sütuna yalnızca sol taraftan bir itme uygulanmıştır. Bunun yanı sıra `offset` için eğer 4'ten fazla bir değer girilseydi de sağ taraftan yapı dışına bir taşma söz konusu olacaktı.
