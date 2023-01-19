# **Time Complexity**

Kullanacağımız algoritmayı analiz etmek istiyoruz. Problem aynı olsa bile algoritmamız farklı inputlar için farklı performans senaryoları üretebilir.

Diyelim ki bir kelimenin anlamını sözlükte arıyorum. Arama için sayfalara tek tek bakıyorum. Burada algoritmam sayfalara tek tek bakmak input da aradıpım kelime.

Aradığım kelimenin boyutu aynı olsa da hangi harfle başladığına göre yapacağım işlem(sayfa çevirme) sayısı değişebilir. Yani input algoritmamın yapacağı işlem sayısını etkileyebiliyor.

Bu yüzden analizimizi 3 ana başlık altında yapabiliriz;

1. Worst Case: Vereceğimiz inputun algoritmamızı en yavaş (en fazla işlem yapacak) şekilde çalıştırdığı durum. Aradığımız kelimenin "z" ile başlaması durumu gibi. Her algoritmaya göre worst case farklıdır. 

2. Average Case: Genel olarak beklediğim durum. 

3. Best Case: Vereceğimiz inputun algoritmamızı en hızlı şekilde çalıştırdığı durum. 

> Algoritmamızın çalışmasını en iyi yansıtan average case, ama bu durumu analiz etmek diğerlerine göre çok daha zor. İnputların geldiği dağılımı bilip ona göre analiz etmek gerekiyor. 

> Worst case'e göre analiz yaparsak performansımız için üst sınırı çizmiş oluruz. Böylece worst case için bizi tatmin eden bir algoritmamız varsa, average case zaten bundan daha iyi(veya aynı) performans vereceği için o da bizi tatmin edecektir.