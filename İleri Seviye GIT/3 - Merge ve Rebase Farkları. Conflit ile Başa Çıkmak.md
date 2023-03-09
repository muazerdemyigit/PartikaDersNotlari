# İki branch'in birleştirilmesi için:

```git
git merge [birleştirilmek istenen branch ismi]
```

- Bulunduğu branch ile belirtilen branch birleştirilir.
- Örnek:

```git
git merge header
```

> NOT: Merge iki branch'in ortak commit'ini buluyor ve her iki branch'in son commit'ine gidiyor ve bu ikisi arasındaki değişikliği aktif olarak içinde bulunduğumuz branch'e uyguluyor.

# Birleşim sonrasında son olarak commit yapabilmek için:

```git
git merge --squash [birleştirilmek istenen branch ismi]
```

- Örnek:

```git
~ git merge --squash footer
~ git commit -m "Commit"
```

# A dalındaki her bir commit B dalına sanki commit işlemi B dalında yapılmış gibi yeniden yazıldırmak için:

```git
git rebase [branch ismi]
```

- Örnek:

```git
git rebase header
```

> NOT: İki kişi aynı dosyayı ve aynı satırı değiştirirse ve git otomatik olarak merge edemezse bu durumda conflict yani çakışma olacaktır. Bu durumda çakışma yaşayan kişi kendisi çakışmayı çözmeye çalışır, gerekirse ekipteki diğer kişi ile beraber oturup çakışmayı çözdükten sonra merge işlemine devam etmelidir.

# Merge işlemini geri almak için:

```git
git merge --abort
```
