# **Genel Tutucu(Container), Satır Blokları(Row) ve Kolon(Col) Yapısı**

`Container`, `row` ve `column` yapısı aslında Bootstrap kullanım mantığının temellerini oluşturuyor diyebiliriz. Bu yapıyı anlamak Bootstrap ile çalışmayı çok çok kolaylaştıracaktır. Öncelikle `container` ile başlayalım.

## **`container`**
Container'ı(konteynır) isminden de biraz anlaşılacağı gibi, içine web sayfamızda bulunması gereken yazıları, resimleri, videoları veya herhangi bir içeriği koyduğumuz kapsayıcı bir çerçeve, kutu gibi düşünebiliriz. Biz içeriklerimizi bu container içerisine koyuyoruz ve bir tarayıcıdan web sayfamız görüntülendiğinde container kendisini ekranın tam ortasına gelecek şekilde ayarlıyor. 

Containerlar boyutlarını değiştirip `responsive` bir tasarım yapmamıza yardımcı oluyorlar. Yani biz bir sayfayı cep telefonu, tablet veya laptop ile görüntülediğimizde cihazların ekran boyutları farklı olacağı için, container'ımızda kendisini bu ekran boyutuna göre yeniden ölçeklendiriyor, ortalıyor veya düzenliyor. Tüm sayfayı tek bir container içerisine koyup düzenleyebileceğimiz gibi, birden fazla container veya iç içe container'da kullanılabiliyor gerektiği durumlarda.

Aşağıdaki tabloyu bootstrap'in official sayfasından bulabilirsiniz.

![Bootstrap tablo](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-genel-tutucucontainer%2C-satir-bloklarirow-ve-koloncol-yapisi/figures/container-sizes.png)

En soldaki sütunda container `class` isimlerini görüyoruz, mesela `.container` veya `.container-md` gibi. 

Class'ların kullanımını örnek ile göstermek gerekirse; 
```html
<div class="container-md"></div> 
```
şeklinde bir HTML dosyası içerisinde kullanabiliriz. HTML dosyası içerisinde class isimleri tanımlarken başındaki "`.`"(nokta)'yı kaldırmamız gerekli. Peki bu tablo bize neyi anlatıyor? `.container-md` class'ını kullanarak bu tabloyu açıklamaya çalışacağım. `.container-md` class'ına sahip bir container;

- `extra small` bir cihazda, yani 576px'den küçük olan bir cihazda, ekran boyutunun 100%'ünü kaplamaktadır.

- `small` bir cihazda, yani 576px'den büyük veya eşit olan bir cihazda, ekran boyutunun 100%'ünü kaplamaktadır.

- `medium` bir cihazda, yani 768px'den büyük veya eşit olan bir cihazda, bu containerın genişliği 720px olacaktır.

- `large` bir cihazda, yani 992px'den büyük veya eşit olan bir cihazda, bu containerın genişliği 960px olacaktır.

- `X-large` bir cihazda, yani 1200px'den büyük veya eşit olan bir cihazda, bu containerın genişliği 1140px olacaktır.

- `XX-large` bir cihazda, yani 1400px'den büyük veya eşit olan bir cihazda, bu containerın genişliği 1320px olacaktır.


Container'larımız bu tablodaki verilen boyutlara göre kendilerini ortalayacak, etrafındaki boşlukları ayarlayacak ve değişen ekran boyutlarına tepki verecektir. Genel olarak container'ların kullanımı bu şekilde diyebiliriz.

## **`Row ve Column` Yapısı**
`Row(satır)`, `column(sütun)` sistemi Bootstrap'in `grid system(ızgara sistemi)` denilen düzenini oluşturuyor. Grid system ile bir web sayfası `12` adet sütuna bölünmüş ve sayfanın içeriği bu sütunların boyutlarına göre düzenlenmiş diyebiliriz.

İçeriklerimizin genişliğini sütun yapısına göre belirliyoruz demiştik. Yani sayfamızda paylaşmak istediğimiz bir yazı, 12 sütunun 3 tanesini kapsayacak genişlikte olsun, kalan 9 sütun ise bir resim için ayrılmış olsun. 

Peki içeriklerin uzunluğunu neye göre belirliyoruz? İşte burada da satırları kullanıyoruz. Sayfamızı yukardan aşağıya satırlara bölüyoruz ve her satırın içerisinde ayrı ayrı sütun sayısı, boyutu belirleyebiliyoruz. Bu şekilde satırları ve sütunları bir `container` içerisinde kullandığımızda `grid system` uygulamış oluyoruz. Kafa karıştırıcı gibi gözükebilir ancak aşağıdaki resmi incelediğimizde her şey çok net anlaşılacaktır.

![grid sistem](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-genel-tutucucontainer%2C-satir-bloklarirow-ve-koloncol-yapisi/figures/grid-details.png)

- İlk Satır Birbirine Eşit Boyutta 12 Adet Sütundan

- İkinci Satır Birbirine Eşit Boyutta 3 Adet Sütundan

- Üçüncü Satır 2 Farklı Boyutta Sütundan

- Dördüncü Satır 2 Eşit Boyutta Sütundan

- Beşinci Satır İse Tek Bir Sütundan Oluşmaktadır.

Kod üzerinde göstermek gerekirse 3 adet sütundan oluşan bir yapı şöyle yazılmaktadır;

```html
<div class="container">     
        <div class="row">
            <div class="col-sm">
                One of three columns
            </div>
            <div class="col-sm">
                One of three columns
            </div>
            <div class="col-sm">
                One of three columns
            </div>
        </div>
    </div>
```