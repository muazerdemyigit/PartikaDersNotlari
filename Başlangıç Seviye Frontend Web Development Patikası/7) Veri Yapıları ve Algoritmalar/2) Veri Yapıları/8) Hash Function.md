# **Hash Function**

`Hash Function (Karma Fonksiyonu)`, karma fonksiyonu olabilmesi için bazı temel şartlar vardır.Bunlar;

1. Gönderdiğimiz anahtarlar (keys) farklı olmasına rağmen bize aynı sonuçları veriyorsa bu bir hash function değildir.

2. Fonksiyona gönderilen anahtarlar aynı fakat sonuç farklı ise hash function değildir.

3. Hash Table için kullanılan dizinin boyutu verilen sonuçların sayısı kadar olmalı.

> Hash Function aynı girdiye aynı sonucu vermesi lazım.

> Farklı girdilere farklı sonuçlar vermesi lazım.

> Array'in boyutu Hash Function'un çıktılarının sınırlarında (range) olmalı.

> Maalesef her zaman farklı girdiler farklı çıktılar vermiyor. Bu olaya `collision` deniyor. Bir sonraki derste bu kavramı işleyeceğiz.