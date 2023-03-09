# Hiçbir şeyini değiştirmeden önceden atılan commit içerisine yapılan güncellemeleri dahil etmek için:

```git
git commit --amend
```

# Sadece mesajını değiştirerek güncellemeleri dahil etmek için:

```git
git commit --amend -m "mesaj"
```

# Commit silmek için:

```git
git revert [commit'in id'si]
```

> NOT: Commit'lerin bilgileri `git log` ile elde edilir.
> Örneğin;

```git
~ git log
~ git revert 86232f22b3a
```

> NOT: revert esnasında yazılan id en az 7 karakter olmalıdır.

> NOT: revert'in revert'i de yapılabilir.

# Belirli bir ID sonrası commitleri commit bırakmadan silmek için:

```git
git reset --hard [commit id]
```

- Örnek:

```git
git reset --hard 86232f22b3a
```

# İki commit arasında yapılan değişiklikleri görmek için:

```git
git diff [ilk commit id]..[ikinci commit id] [dosya adı]
```

- Örnek:

```git
git diff 86232f22b3a..66cf764468af3a5 index.md
```

> NOT: [dosya adı] eklenmezse o commit ile bütün dosayalardaki yapılan değişiklikleri gösterirdi.


