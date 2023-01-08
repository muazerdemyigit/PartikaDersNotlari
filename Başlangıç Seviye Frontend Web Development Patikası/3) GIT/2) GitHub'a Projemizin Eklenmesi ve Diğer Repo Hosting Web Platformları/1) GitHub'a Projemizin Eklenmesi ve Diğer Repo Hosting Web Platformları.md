# GitHub'a Projemizin Eklenmesi ve Diğer Repo Hosting Web Platformları

- Github hesabımıza giriş yapıp sağ üstteki artı butonuna basıyoruz. 

- Çıkan seçeneklerden ***“New Repository”*** seçeneğini seçiyoruz.

- Repo ismini, açıklamayı, özel mi genel mi olacağını, readme-gitignore-lisans seçeneklerinden hangisini istediğimizi seçip ***“Create Repository”*** seçeneğine tıklıyoruz. 

- Gelen ekranda git komutlarıyla nasıl githuba uygulamamızı yükleyebileceğimiz hakkında bilgiler verilmiş. Bu adımları takip ederek yükleyebiliriz. 

---

GitHub'da repo oluşturabilmek için hesap oluşturma aşamalarından sonra profilimizde bulunan ***"Repositories"*** menüsünden sağ kısımda bulunan **"New"** butonu ile repo oluşturma kısmına erişebiliriz.

>**Owner**: Reponun sahibinin seçiyoruz.

>**Repository name**: Oluşturduğumuz reponun adını belirliyoruz.

>**Description**: Repomuz için bir açıklama girebiliriz.

>**Public**: Repomuzun tüm herkesin erişimini sağlar.

>**Private**: Bu seçenek sayesinde repomuzu gizli bir şekilde oluşturabiliriz.

>**Add a README file**: Repomuza öncesinde README dosyası oluşturmuş oluruz, dilersek daha sonrasında kendimiz ekleyebilir ve güncelleyebiliriz.

>**Add .gitignore**:** Repomuza öncesinde .gitignore dosyası oluşturabilir ve göndermek istemediğimiz dosyaları seçebiliriz, daha sonrasında aynı işlemi yapabilir ve .gitignore dosyamızı güncelleyebiliriz.

>**Choose a license**: Reponuz için bir lisans seçimi yapabilmenizi sağlar.

- Gerekli işlemleri tamamladıktan sonra ***"Create repository"*** diyerek repomuzu oluşturmuş oluruz.

Oluşturmuş olduğumuz repomuza bilgisayarımızdan erişebilmek için gerekli işlemleri yapmaya başlayalım.

- Bilgisayarımızda oluşturmuş olduğumuz klasörümüze konsol ekranımızdan veya kullandığımız IDE yardımı ile erişim sağladıktan sonra ```git init``` komutumuzu çalıştıralım.

- Klasörümüz hazır, öncelikle *README.md* dosyamızı oluşturalım ve repomuza ilk push işlemini yapabilmek için adımları tamamlayalım.

- Eklemiş olduğumuz README dosyasını repomuza gönderebilmek için ```git add README.md``` komutumuzu ile README dosyasının GitHub repomuza göndermek üzere hazırlayalım.

- Repomuza son yapılan değişikleri göndermeden önce ```git commit -m "ilk Commit"``` komutu ile neler yaptığımızı yazalım.

- Bize belirtilen şekilde ```git branch -M main``` komutunu konsol ekranımızda çalıştıralım ve *main branch* oluşturalım.

- Son aşamaya gelmeden önce ise ```git remote add origin 'repo-link'``` komutu ile *remote* bağlantımızı ekleyelim.

- Son aşama olarak  ```git push -u origin main``` komutu ile repomuza dosyalarımızı gönderelim.

- Ve ilk push işlemimiz ile birlikte tüm değişikliklerimizi GitHub repomuza göndermiş olduk. Github sayfamızı yenilediğimizde dosyalarımızı görebileceğiz.

- Böylece README dosyamızı repomuza göndermiş olduk. Sağ tarafta bulunan ***"1 commit"*** yazısının üstüne tıklayarak ise commit ile ilgili detayları görmüş oluruz.

- Daha fazla detay görmek için ise sağ tarafta görünen mavi renk ile belirtilmiş commit işlemimiz için özel olarak random şekilde atanmış benzersiz yazı kısmının üstüne gelerek tıklamanız yeterli olacaktır.

- Bu kısımda ise commit hakkında yorum yazabilir ve detaylı olarak değişiklikleri gözden geçirebilirsiniz.

## Github Benzeri Repo Hosting Platformları
### **GitLab**
- **“GitLab nedir?”** sorusunun yanıtı GitLab ile GitHub arasındaki farkın daha iyi anlaşılması açısından oldukça önemli. 
- GitLab *web tabanlı bir Git depo uygulaması* olarak tanımlanabilir. Bu depo servisi ***sürekli entegrasyon (CI)***, ***sürekli teslimat (CD)***, ***hata kayıt***, ***kod gözden geçime*** ve ***wiki desteği***yle çalışıyor. 
- Başlangıçta GitLab’in büyük bir çoğunluğu *Ruby* ile yazılmıştır.

### **Bitbucket**
- Bitbucket, 2010 yılında *Atlassian* firması tarafından satın alınması ile beraber *Mercurial* ile birlikte Git desteği de vermeye başlayan ve günümüzde de hala sadece Git ve Mercurial versiyon kontrol sistemlerini (VCS) destekleyen, yazılım projeleri kodları için web tabanlı bir depolama servisidir.
