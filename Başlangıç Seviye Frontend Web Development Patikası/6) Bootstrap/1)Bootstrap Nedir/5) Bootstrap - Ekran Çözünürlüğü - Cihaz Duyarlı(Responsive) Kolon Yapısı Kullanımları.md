# **Bootstrap - Ekran Çözünürlüğü / Cihaz Duyarlı(Responsive) Kolon Yapısı Kullanımları**

Bootstrap sitesinde `Documentation` bölümünde `Layouts` sekmesinde `Grid` seçeneğine tıkladığımızda `grid options`'ların neler olduğu hakkında bilgiler veriyor.

Eğer ben bir kolon oluşturacaksam ve kolon yapısında `12'lik grid sistemi` içerisinde `col-` diyip gridin kendisini verirsem o zaman bu otomatik olarak bütün ekranlarda benim istediğim gibi responsive olacak.

Bu yerleşim şekline belirli koşullar vermek isteyebilrim. Örneğin mobil ekranımda ekranın tamamını kaplasın, small ekranda 2 kutu yan yana olsun, medium ekranda 3 kutu yan yana olsun, large ekranda 4 kutu yan yana olsun, x large ekranda 6 kutu yan yana olsun ve altta da böyle devam etsin istiyorum. 

Eğer `col-` dedikten sonra sadece 12 dersem her yerde 12 olacak şekilde sıralıyor.

Eğer `col-sm-6` dersem small ekranda 2 adet kutu olacak. Ancak `sm` ifadesi kullanıldığı için `sm` ekran boyutundan küçük ekranlarda farklı bir diziliş olacak. Yani `sm`'den önce 12'lik diziliş olacak ama `sm`'den sonra 6'lık diziliş şeklinde dizilmeye devam edecek. 

Diğer yerlede de değiştirmek için birden fazla class ismi verebilirim. Her bir kutunun nasıl görüneceğini o kutunun tanımını yaparken verebilirim. Bu şekilde de responsive yapıyı oluşturabiliyorum.

Örneğin;
```html 
<div class="container">     
        <div class="row">
            <div class="col-sm-6 col-md-4 col-lg-3 col-xl-2">
                <h1 class="text-danger">Hello, world!</h1>
                One of three columns
            </div>
        </div>
    </div>
```

Kodunda mobil ekranımda ekranın tamamını kaplasın, small ekranda 2 kutu yan yana olsun, medium ekranda 3 kutu yan yana olsun, large ekranda 4 kutu yan yana olsun, x large ekranda 6 kutu yan yana olsun diye belirttim.

Eğer `col-md-4` classını yazmasaydım medium ekranda 2 kutu yan yana olacaktı. Yani `col-sm-6` bilgisi devam ediyor olacaktı. Yani verilen bilgiden sonraki değerler girilmezse en son girilen değere göre düzenleniyorlar.