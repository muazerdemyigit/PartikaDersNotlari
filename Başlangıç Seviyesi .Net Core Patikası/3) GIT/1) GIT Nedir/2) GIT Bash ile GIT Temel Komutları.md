- Proje klasörüne sağ tıklayıp ***“Git Bash Here”*** seçeneğine basınca bir terminal açılacak.
- Bu projede Git’i ilk defa başlatmak istiyorsak ***“git init”*** dememiz lazım. Her yeni açılan projede git kullanmak istiyorsak bu adımın yapılması gerekiyor.
- ***“git status”*** diyince klasörün içeriği ve hangi işlemlerin yapıldığını söylüyor. İlk çalıştığı zaman hiçbir dosya takip edilmiyor diyecek.
İstediğimiz dosyayı takibe almak için ***“git add (file name)”*** kalıbını kullanmalıyız. 
- Projede yapılanları onaylamak ve bunun snapshot’unu almak istiyorsak ****“git commit”*** kalıbını kullanmalıyız. Bu kalıp kullanıldığında bilgisayarda ilk defa git kullanılıyorsa belli ayarlar yapılmasını isteyecektir.
- ***“git commit –m ‘Commit İçeriği’”*** kalıbı ile commit atılabilir.
***“git diff”*** komutu ile en son alınan snapshot sonrası yapılan değişiklikler görünecek.

## Başlıca bilmemiz gereken bazı terimler;

>untracked (izlenmeyen): GIT tarafından henüz takip edilmeyen, yani yeni oluşturulmuş dosyaları ifade eder.

>unstaged (hazırlanmamış): Güncellenmiş ancak commit’lenmek için hazırlanmamış dosyaları ifade eder.

>staged (hazırlanmış): Commit’lenmeye hazır olan dosyaları ifade eder.

>deleted (silinmiş): Projeden silinmiş ama GIT üzerinden kaldırılmamış dosyaları ifade eder.

### **git init**
Henüz versiyon kontrolü altında olmayan bir projenin dizininde, boş bir git deposu oluşturmak için kullanılır.

### **git config**
GIT’in bir çok konfigürasyon ve ayarı vardır, bunlardan ikisi *user.name* ve *user.email* olanıdır. 
- Bu ayarları yapılandırmak için aşağıdaki komutları kullanırız.
- GIT'i ilk kurduğumuzda genellikle aldığımız ilk hata bu configurasyon ayarlarını yapmadığımız için gelir.
- Burada yazdığınız isim ve email ileride GitHub benzeri bir plat forma commit attığınızda da görüneceği için bunu bilerek isimlendirme yapmak yararlı olur.

### **git add**
Yeni eklenen veya üzerinde değişiklik yapılan dosyaları staged ortamına göndermek için kullanılır.
Tek seferde bütün dosyaları eklemek için ise: ```git add .``` yazılmalıdır. **“.”** Tüm dosya uzantılarını ifade eder.

### **git status**
Üzerinde çalışılan projenin o anki durumu hakkında bilgi verir. Yapılan değişiklikler, eklenen ve silinen dosyalar gibi bilgiler listelenir.

### **git commit**
Commit, staged ortamına alınan dosyaların Local Repository’e gönderilmesidir.
- En iyi uygulama yöntemi her kayıt sırasında yapılan değişiklikleri açıklayıcı bir mesaj eklemektir.
- Ayrıca her commit benzersiz bir kimliğe ***(unique ID)*** sahip olur. Bu sayede eski bir commit'e geri dönebilirsiniz ve herhangi bir kayıp yaşama ihtimaliniz kalmaz.

### **git log**
Projedeki commit geçmişini görüntülememizi sağlar. Bütün commit'ler, id'si, yazarı, tarihi ve mesajı ile beraber listelenir.

### **git branch**
Local veya remote repository üzerinde yeni bir ***branch*** (dal) eklemek, silmek veya listelemek için kullanılır.
 
- Projenize yeni bir branch eklemek için; ```git branch <branch_name> ```

- Tüm uzak ve yerel branch'lari listelemek için; ```git branch –a```

- Bir branch'ı silmek için; ```git branch -d <branch_name>```

### **git checkout**
Branch’ler arası veya commit'ler arası geçiş yapmak istediğimizde kullanılır.

>Mevcutta var olan branch'a geçiş yapmak için;``` git checkout <branch_name>```

>Yeni bir branch oluşturup, bu branch'a geçiş yapmak için;
``` git checkout -b <branch_name>```

>Commitler arası geçiş yapmak için: (Eski bir versiyona dönmek istediğimiz zaman) ```git checkout <commit_ID>```

### **git merge**
Başka bir branch'da olan değişiklikleri, bulunduğumuz branch ile birleştirmek istediğimizde kullanılır.

``` git merge <branch_name>```

### **git clone**
Mevcut bir *Remote Repository*'de bulunan dosyaların bilgisayarımızda bir kopyasının oluşturulmasını sağlar.

``` git clone <remote_URL>```

### **git push**
Projemizde aldığımız commit'leri, remote repository'e gönderir.

``` git push origin master```


Burada bahsi geçen origin remote repository’nin kök dizinini belirtir ve sabit bir isimdir. master ise sizin çalıştığınız branch (dal)’ı belirtir.

Henüz remote repository’niz yoksa aşağıdaki komut ile local deponuzu uzak sunucudaki depoya bağlayabilirsiniz.

```git remote add origin http://uzak_deponun_adresi.git```

### **git diff**
Repository üzerinde yapılan değişikliklerden sonra dosyalar arasında oluşan farklılıkları gösterir.

>Çalışma dizini ile repository (HEAD) arasındaki farklılıkları görmek için:
 
 ``` git diff HEAD```

>İki commit arasındaki farklılıkları görmek için:

```git diff <commit_id_1>..<commit_id_2>```

>Çalışma dizini ve staged ortamı arasındaki farkları görmek için:

``` git diff --staged```