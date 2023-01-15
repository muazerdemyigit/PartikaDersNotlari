# **Bootstrap Sıralama Özellikleri Kullanarak Responsive Yapıya Göre Tepkilerin Düzenlenmesi**

Bootstrap'de sıralama özelliği(`order`), içeriklerin HTML'de yazılan sırayla değil (kodlar yukarıdan aşağı okunarak sıralanır) bizim belirlediğimiz sıraya göre sıralamamızı sağlayan bir kavramdır. 

Genellikle responsive yapılar oluştururken kullanılır. Kullanırken kapsayıcı div'imizin `display:flex` classının yani '`d-flex`' olması gerekmektedir, kapsayıcı div'in içinde en fazla 5 tane içeriği sıralayabileceğimizi unutmamamız gerekiyor.

Order kavramı Bootstrap bütün kırılma noktaları(`xs-sm-md-lg-xl-xxl`) için tanımlanmış class'lara sahiptir.

Bunlar:
```
order-0
order-1
order-2
order-3
order-4
order-5
order-sm-0
order-sm-1
order-sm-2
order-sm-3
order-sm-4
order-sm-5
order-md-0
order-md-1
order-md-2
order-md-3
order-md-4
order-md-5
order-lg-0
order-lg-1
order-lg-2
order-lg-3
order-lg-4
order-lg-5
order-xl-0
order-xl-1
order-xl-2
order-xl-3
order-xl-4
order-xl-5
order-xxl-0
order-xxl-1
order-xxl-2
order-xxl-3
order-xxl-4
order-xxl-5
```
İstediğiniz kırılma noktalarında istediğiniz sıralamayı gerçekleştirebilirsiniz, tek kullanım şekli bu değildir.

Aşağıdaki class'ları kullanarak da sıralama işlemlerinizi gerçekleştirebilirsiniz.
```
order-first
order-last
order-sm-first
order-sm-last
order-md-first
order-md-last
order-lg-first
order-lg-last
order-xl-first
order-xl-last
order-xxl-first
order-xxl-last
```
Bir örnek gerçekleştirelim Bootstrap ile hazırladığımız yapı ilk haliyle şu şekil olsun
```html
		<div class="container-fluid">
			<div class="row">
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex ">
						<h3>1.İçerik</h3>
				</div>
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex ">
						<h3>2.İçerik</h3>
				</div>
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex ">
						<h3>3.içerik</h3>
				</div>
			</div>
		</div>
```
![ilkicerigimiz](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-siralama-ozellikleri-kullanarak-responsive-yapiya-gore-tepkilerin-duzenlenmesi/figures/ilk.png)

`Medium` kırılma noktasından daha küçük genişliklerde 3.içeriğimizin ilk sıraya geçmesini istiyoruz. Fakat daha büyük genişliklerde bu sırayla kalmasını istiyoruz bunun için:
```html
<div class="container-fluid">
			<div class="row">
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-3 order-md-1 ">
						<h3>1.İçerik</h3> 
				</div> 
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-2 order-md-2 ">
						<h3>2.İçerik</h3> 
				</div> 
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-1 order-md-3 ">
						<h3>3.içerik</h3>
				</div>
			</div>
		</div>
```
![ilkicerikdüzenlenmishali](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-siralama-ozellikleri-kullanarak-responsive-yapiya-gore-tepkilerin-duzenlenmesi/figures/ikinci.png)

Kodumuzu Bootstrap'i dahil ettiğiniz bir projede deneyebilirsiniz. Bu şekilde tüm kırılma noktaları için ayrı ayrı sıralamalar gerçekleştirebiliriz.

Peki bu kodu biraz daha karmaşıklaştırmaya ne dersiniz? İç içe içeriklerimiz olsun.

Örneğin:
```html
<div class="container-fluid">
			<div class="row">
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-3 order-md-1 ">
						<div class="row">
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
								<h3>1.İçeriğin 1.maddesi</h3>
							</div>
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
								<h3>1.İçeriğin 2.maddesi</h3>
							</div>
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
								<h3>1.İçeriğin 3.maddesi</h3>
							</div>
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
								<h3>1.İçeriğin 4.maddesi</h3>
							</div>
						</div>
				</div> 
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-2 order-md-2 ">
					<div class="row">
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>2.İçeriğin 1.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>2.İçeriğin 2.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>2.İçeriğin 3.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>2.İçeriğin 4.maddesi</h3>
						</div>
					</div>
				</div> 
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-1 order-md-3 ">
					<div class="row">
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>3.İçeriğin 1.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>3.İçeriğin 2.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>3.İçeriğin 3.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex">
							<h3>3.İçeriğin 4.maddesi</h3>
						</div>
					</div>
				</div>
			</div>
		</div>
```
![karisikicerigimiz](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-siralama-ozellikleri-kullanarak-responsive-yapiya-gore-tepkilerin-duzenlenmesi/figures/ikinciicerik.png)

Örneğimizi daha iyi anlamak için lütfen bir editöre kodumuzu kopyalayıp yapıştıralım. Gördüğünüz gibi şuan iç içe içeriklerimizin olduğu bir yapı var ben `xs` kırılma noktasında farklı, `md`'da farklı ve `lg`'da şuanki görüntüsüyle sıralanmasını istiyorum.

Şimdi kodumuzu buna göre düzenleyelim.
```html
	<div class="container-fluid">
			<div class="row">
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-3 order-md-1 ">
						<div class="row">
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-3 order-md-2 order-lg-1">
								<h3>1.İçeriğin 1.maddesi</h3>
							</div>
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-2 order-md-3 order-lg-2">
								<h3>1.İçeriğin 2.maddesi</h3>
							</div>
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-4 order-md-1 order-lg-3">
								<h3>1.İçeriğin 3.maddesi</h3>
							</div>
							<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-1 order-md-4 order-lg-4">
								<h3>1.İçeriğin 4.maddesi</h3>
							</div>
						</div>
				</div> 
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-2 order-md-2 ">
					<div class="row">
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-2 order-md-4 order-lg-1">
							<h3>2.İçeriğin 1.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-4 order-md-1 order-lg-2">
							<h3>2.İçeriğin 2.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-3 order-md-3 order-lg-3">
							<h3>2.İçeriğin 3.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-1 order-md-2 order-lg-4">
							<h3>2.İçeriğin 4.maddesi</h3>
						</div>
					</div>
				</div> 
				<div class="col-md-4 col-12 bg-dark text-white border-danger border d-flex order-1 order-md-3 ">
					<div class="row">
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-2 order-md-4 order-lg-1">
							<h3>3.İçeriğin 1.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-4 order-md-1 order-lg-2">
							<h3>3.İçeriğin 2.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-1 order-md-2 order-lg-3">
							<h3>3.İçeriğin 3.maddesi</h3>
						</div>
						<div class="col-md-4 col-12 bg-info text-white border-primary border d-flex order-3 order-md-3 order-lg-4">
							<h3>3.İçeriğin 4.maddesi</h3>
						</div>
					</div>
				</div>
			</div>
		</div>
```
![karisikicerikdüzenlenmishali](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/bootstrap/bootstrap-siralama-ozellikleri-kullanarak-responsive-yapiya-gore-tepkilerin-duzenlenmesi/figures/ikinciicerikduzenlenmis.png)

Kodumuzu artık istediğimiz düzeye getirmiş olduk.