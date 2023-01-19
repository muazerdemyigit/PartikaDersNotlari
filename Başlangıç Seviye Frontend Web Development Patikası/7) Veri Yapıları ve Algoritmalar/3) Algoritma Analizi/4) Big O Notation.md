# **Big-O Notation**

İki farkklı arama yöntemi düşünelim.

- A algoritması tek tek sayfalara bakıyor

- B algoritması sözlüğün alfabetik sıralanmış olduğundan yararlanarak en başta en ortadaki sayfayı açıyor, eğer bu sayfadaki harfler aradığım kelimeden alfabetik olarak daha ilerideyse sol tarafa aynısını yoksa sağ tarafa aynısını yapıyor.

- Böylece problem her seferinde yarı boutuna inmiş oluyor.

- Birkaç durum üzerinden konuşalım. Diyelim ki  sayfalık bir sözlüğüm var. A algoritması en kötü durumda(aradığım en son sayfadaysa) kaç işlem yapacak? 100 işlem.

- B algoritması en kötü durumda kaç işlem yapar 2^n = 100 işlem.

- Bu örneğe bakarak B algoritmasının A algoritmasından daha hızlı olduğunu görebiliyoruz. 100/7 den yaklaşık olarak 15 katı hızında diyebilir miyiz? Bu genellenebilir bir şey midir?

- Pek diyemiyoruz. Şöyle düşünelim, sözlüğüm 10000 elemanlı olsa, A algoritması en kötü durumda 10000 işlem yapar ama B algoritması 2^n= 10000 den yaklaşık 13 işlem yapar. 10000/13 den yaklaşık 770 katı hızında gözüküyor.

-Bu yüzden algoritmaların sadece 1 input boyutuna göre karşolaştırmalarına bakıp karar veremeyiz. Genel yapısını bize gösterecek bir analize ihtiyacımız var. İşte bureada `Big O Notation` devreye giriyor.

- Big O Notation algoritmanın ne kadar süredde çalışacağını sölemeyecek. Bize algoritmamızın çalışma zamanının inputun boyutu ile nasıl değiştiğini söyleyecek.

- Mesela sözlük örneğimizde input size'ımıza n dersek, algritmamızın en kötü durumda n işlem yaptığını söyeyebiliriz. Inputum n boyutunda olunca çalışma süremin de en kötü durumda n olmasını O(n) diye göstereceğim. Aynı şekilde B algoritması için O(logn).

- Big O Notation'da yapılacak toplam işlem sayısının inğut size ile nasıl scale olacağına bakıyoruz. Benim için bu fonksiyon yapısı önemli.

- İşlem sayısı input size ile linear mi artıyor, karesi ile mi orantılı artıyor, logaritmik mi artıyor?

- Karekteristiği önemsediğimiz için 2n işlem yapan algoritmaya da n işlem yapan algortimaya da O(n) diyoruz, ikisi de linear şekilde artıyor. Big O Notation bakarken katsayılar önemli değil.

- Analizimizin sonucu 2n^2+3n+2 gibi bir şey çıktı diyelim. n büyüdükçe, 3n+2'nin etkisi 2n^2'in yanına önemsiz kalacak. O yüzden dominant olanı Big O Notation olarak yazabiliriz O(n^2)
