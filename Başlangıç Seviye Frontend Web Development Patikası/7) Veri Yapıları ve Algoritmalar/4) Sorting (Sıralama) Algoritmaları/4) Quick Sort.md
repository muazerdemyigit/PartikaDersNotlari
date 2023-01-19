# **Quick Sort**

Hızlı sıralama günümüzde çok yaygın olarak kullanılan bir sıralama algoritmasıdır. `N` tane sayıyı `average case` e göre `big-o` `O(nlogn)`, `worst case` e göre `big-o` `O(n^2)` karmaşıklığı ile sıralanır.

![QuickSort](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/veri-yapilari-algoritmalar/quick-sort/figures/Quicksort.png)



İlk olarak bir pivot belirler bu pivota göre pivottan küçük ve eşitler sol kısmına, pivottan büyük ve eşitler sağ kısmına yazılır. Parçalanmış kısımlar yeni bir pivot belirlenerek parça pinçik edilir.
