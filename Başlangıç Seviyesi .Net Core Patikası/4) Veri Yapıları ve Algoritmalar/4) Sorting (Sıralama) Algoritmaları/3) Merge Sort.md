# **Merge Sort**

`Insertion Sort`'da, `Big-O` gösteriminden dolayı `input`'um arttığında `n2` olduğunda dolayı çalışma zamanı artıyor.

Peki daha hızlı bir şekilde sıralama yapılabilir mi? Evet, `Merge Sort` burada yardımımıza koşuyor. Bir listeyi her adımda parçaya ayırıp tek eleman kalıncaya kadar bölüyor. Böldükten sonra sıralı bir şekilde bize sunuyor (Performans).

![merge-sort](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/veri-yapilari-algoritmalar/merge-sort/figures/merge-sort.png)

![big-o-merge](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/veri-yapilari-algoritmalar/merge-sort/figures/big-o-merge.png)

`Insertion sort`'da, `time complexity` `O(n^2)` olduğundan ötürü çalışma zamanımız artıyordu. `Merge sort`'da ise `O(nlogn)` olduğu için açık ara performans olarak daha iyi diyebiliriz.

