# **Monolitik Mimari**

Monolithic; mono/tek

Monolithic yaklaşım, bir sistemin tek bir parça olacak şekilde tasarlanmasıdır. Monolithic mimari ise bu tasarımın stratejik yapılanmasıdır. Monolithic yaklaşım, üretilecek sistemin bileşenlerini(component) birbirlerine bağlı(interdependent) olarak ve kendi kendine yetecek(self-contained) şekilde tasarlanmasını sağlayan ve böylece tek bir bütünsel varlık olarak nihai sonuca varılmasını sağlayan mimaridir.

Monolithic yaklaşımı benimsemiş uygulamaların tüm fonksiyonaliteleri tek bir çatı altında geliştirilirler.

Monolitik mimariyi bir uygulama üzerinden anlatacak olursak;

- Bir sunucumuz var. Bu sunucu bir database'ye bağlanıyor. Sunucuya istekleri atan client'lerimiz var.
- Kullanıcı bir şey yapmaya çalıştığında isteklerini sunucuya yollar. Bu sunucu üzerinde çalışan projemiz bu veriyi elde etmek için database ile etkileşime girer ve bu etkileşim sonucunda kullanıcının isteğini karşılar.
- Bu mimari monolitik mimaridir. Yani serverdaki bir proje üzerinden bütün aksiyonlar ilerler.

Sunucu kısmını ele alalım;

- Monolitik mimaride sunucu üzerinde 3 katman vardır; 1.Presentation, 2.Business Layer, 3.Data Access Layer.
  - Presentation Layer: Sunum katmanıdır. Son kullanıcının gördüğü bölümün kodlarının oluşturulduğu yerdir.
  - Business Layer: Mantıksal işlemlerin yapıldığı, routinglerin yapıldığı yani kodların yazıldığı yerdir. Client'den gelen istek üzerine hangi fonksiyonun çalışacağı burada yazılır.
  - Data Access Layer: Çalışan fonksiyonun database ile iletişime geçtiği katmandır.

## Monolitik Mimari Ölçeklendirme

Uygulamamız gelen isteklere yetersiz gelmeye başladığında ölçeklendirme yaparız. Bu işlem sunucunun klonu alınarak yapılır. Load Balancer ile client'den gelen istekleri duruma göre sunucular arasında paylaştıma işine yarar.

## Monolitik Mimari Avantajları ve Dezavantajları

- **Avantajları**
  - Geliştirmesi basit.
  - Test edilebiliği kolay.
  - Deployment oldukça kolay.
  - Ölçeklenirme oldukça kolay. Yatay olarak mimarinin kopyasını Load Balancer arkasında çalıştırabilirsiniz.(Yatay bir sunucunun kopyasını alıp yanına koymak, dikey var olan sunucunun kaynaklarını artırmak.)
- **Dezavantajları**
  - Bakımı proje büyüdükçe zorlaşmaya başlar(Sürdürülebilirlik).
  - Uygulamanın boyutu başlama süresini yavaşlatır.
  - Uygulama güncelleneceği zaman tüm uygulamayı deploy etmeniz gerekir.
  - Bazen Monolitik uygulamalar ölçeklendirileceği zaman sorun çıkartabilir.
  - Ölçeklendirme tüm proje genelinde yapılır.
  - Güvenilirlik / Sağlamlık / Dayanıklılık

# **SOA(Service Oriented Architecture)**

- Özet olarak servislerin ayrı ayrı tasarlanıp, bir yapı oluşturmasını sağlar.
- Yapılar birbirlerinden bağımsız çalışabilirler(loose coupling)
- Birden çok sistemin yer aldığı yapılarda kullanılır.
- Kendi içerisinde bir çok bileşeni vardır.
  - Policies, Contracts, Services ve çok daha fazlası
- Dağıtık yazılım sistemlerinin kalitelerini arttırmayı hedefler.
  - Tekrar kullanılabilirlik(reusability)
  - Uyumluluk(adaptabiliy)
  - Bakım yeteneği(maintainability)

## SOA Avantajları ve Dezavantajları

- **Avantajları**
  - Servisleri tekrar kullanılabilir(Reusable).
  - Servislerin bakım onarım süreçleri kolaydır(Maintained).
  - Güvenilirlij / Dayanıklılık.
  - Yatay ve Dikey ölçeklendirme mümkündür.
  - Üretkenlik artar.
- **Dezavantajları**
  - Overload.
  - Yüksek maliyet.
  - Yüksek Bant Genişliği.

# **Mikro Servisler Mimarisi**

- SOA'nin bir yorumudur.
- Her bir servisin kendine ait dünyada çalışmasını hedefler(Server Stack).
- Kendine ait veritabanları vardır.
- Sadece 1 küçük işi çok iyi yapmalıdır.
- Api GW üzerinden dış ve iç dünyaya açılırlar.
- Böylece herhangi bir teknoloji ve dile ait bir kısıtlama olmaz.
- Stateless yapılardır.
- Kolay Ölçeklenebilir.

## Mikro Servisler Avantajları ve Dezavantajları

- **Avantajları**

  - Çok dilli mimari.
  - Kolay ölçeklendirme.
  - Daha iyi bir takım yönetimi.
  - Yenilik yapmak daha kolay.
  - Mikro servislerin kendine ait veri tabanı vardır.
  - Daha odaklı(Yapı, Ölçeklendirme).
  - İmplemente edilirken diğer servisleri etkilemezler.

- **Dezavantajları**
  - İmplementasyon kolay değildir(Network Calls, Service Discovery).
  - Debug kolay değildir.
  - Fault Management(Hata yönetimi) kolay değildir.
