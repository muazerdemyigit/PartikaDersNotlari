# Yeni bir branch oluşturmak için:

```git
git branch [oluşacak branch ismi]
```

- Örnek:

```git
git brach header
```

> NOT: Direkt `git branch` yazılırsa o repo'daki var olan branch'leri gösterir.

# Branch'ler arası geçiş yapmak için:

```git
git checkout [branch adı]
```

- Örnek:

```git
git checkout header
```

# Yeni branch oluşturup, yeni oluşturulmuş branch'e geçiş yapmak için:

```git
git checkout -b [branch adı]
```

- Örnek:

```git
git checkout -b footer
```

# Branch silmek için:

```git
git branch -D [branch adı]
```

- Örnek:

```git
git branch -D footer
```

# Son commit'ten itibaren yapılan bütün değişiklikleri saklamak için:

```git
git stash
```

> NOT: Saklanan veri ne bir kayıt olur ne de bir yere not tutulur. Geçiçi olarak saklanır.

# Stash'leri listelemek için:

```git
git stash list
```

# Stash'leri silmek için:

```git
git stash clear
```

# Stash ile en üstteki kayıdı geri getirmek için:

```git
git stash pop
```

# Belirli bir stash'e geri dönmek için:

```git
git stash apply [stash id]
```

- Örnek:

```git
git stash apply stash@{0}
```

> NOT: `git stash pop` en üsttekini alıp uyguluyor ve listeden onu kaldırıyor, `git stash apply` değişiklikleri uygular ama listeden kaldırmaz.
