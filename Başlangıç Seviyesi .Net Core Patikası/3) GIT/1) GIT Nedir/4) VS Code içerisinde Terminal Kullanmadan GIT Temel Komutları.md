#  VS Code içerisinde Terminal Kullanmadan GIT Temel Komutları

*	Henüz versiyon kontrolü altında olmayan bir projenin dizininde, boş bir git deposu oluşturmak için *Activity Bar* bölümünden ***Source Control***  ikonuna tıklayıp, ***Initialize Repository***  butonuna tıklamalıyız.

*	Yeni eklenen veya üzerinde değişiklik yapılan dosyaları staged ortamına göndermek için ***Stage Changes*** butonuna tıklamalıyız.

*	Birden fazla dosyamız olduğu zamanlarda eğer bütün değişiklikleri tek bir seferde staged ortamına göndermek istiyorsak ***Stage All Changes*** butonuna tıklamalıyız.

*	Staged ortamına dosyayı eklediğimizde, dosyanın yanında *"A"  (added)* yazacaktır. Staged ortamına eklemediğimiz dosyalar olursa bu dosyaların yanında da *"U" (untracked)* yazacaktır.

*	***Commit***, staged ortamına alınan dosyaların Local Repository’e gönderilmesidir. En iyi uygulama yöntemi her kayıt sırasında yapılan değişiklikleri açıklayıcı bir mesaj eklemektir. Ayrıca her commit benzersiz bir kimliğe *(unique ID)* sahip olur. Dosyalarımızı commit'lemek için *Message* bölümüne  commit'imizi açıklayıcı bir mesaj yazmalıyız ve ardından *Commit* butonuna  basmalıyız.

*	Commit'lenen dosya üzerinde değişiklik yaptığımızda, dosyanın yanında *"M"  (modified)* yazacaktır.

*	Dosyamızda yapılan değişikliği görüntülemek için, *Source Control* bölümünde, dosyanın üzerine tıkladığımızda , iki farklı bölüm karşımıza geliyor. En sağdaki bölümde  dosyamızın üzerinde yapığımız değişiklileri görüntüleyebiliriz.

*	Bu değişiklikleri eğer geri almak istersek, tekrar sol bölümdeki  gibi olmasını istiyorsak ***Discard Changes*** butonuna tıklamalıyız.

*	Eğer remote repository'e bağlıysak ve commit'lerimizi remote repository'e göndermek istersek ***Views and More Actions***  butonuna tıklayıp, *Push* seçeneğini seçmeliyiz.

