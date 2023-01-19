# **Binary Search Tree**

Bir düğüm her iki tarafa da referans verebiliyor. Sağ ve sol olarak. Sağ tarafında kendinden büyük elemanlar, sol tarafında ise kendinden küçük elemanlar bulunacak.

![binary-search-tree](https://raw.githubusercontent.com/Kodluyoruz/taskforce/main/veri-yapilari-algoritmalar/binary-search-tree/figures/binary-search-tree.png)

- `Tree`'ye eleman eklemek istediğimde `root`'dan başlıyorum. Örnek olarak ben `26` sayısını ağaç yapısına eklemek istiyorum. `Root`'a soruyorum senin değerin ne `56`. Baştaki açıklamamızı hatırlayalım. Sağ tarafında kendinden büyük, sol tarafında kendinden küçük elemanlar var. O yüzden sırasıyla `56` ve `30` a kadar ilerliyorum. `30` bana benim sol tarafıma geçmelisin çünkü sen benden küçüksün diyor. Karşıma `22` değerinde olan düğüm çıkıyor ve `22` den büyük olduğum için sağ tarafına bir köşe çekiyorum ve `26` sayısını bağlıyorum.

- Average Case'si `O(logn)` (tree dengeli olursa),
- Worst Case'si `O(n)`

> Random Access yapamıyor.