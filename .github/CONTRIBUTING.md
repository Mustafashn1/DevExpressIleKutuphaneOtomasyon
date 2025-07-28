## Katkı Rehberi

Proje geliştirme sürecinde birliğin sağlanması, kalite standartlarının korunması ve iş akışının şeffaf olması adına aşağıdaki kurallara uymanızı rica ediyoruz.

---

### 🔒 Ana Dal Koruması
- `main`, `develop` veya diğer korunan dallara **doğrudan commit atmak yasaktır**.
- Tüm geliştirmeler **ayrı bir branch** üzerinden yapılmalı ve **Pull Request (PR)** ile birleştirilmelidir.

### 🛠️ Branch Stratejisi
- Her iş (task, bug, iyileştirme) için bir `issue` açılmalı ya da mevcut bir issue referans alınmalıdır.
- Branch adı şu formatta olmalıdır:

  ```
  feature/kisa-aciklama
  bugfix/hata-aciklama-#(issue numarası)
  hotfix/kritik-duzeltme
  ```

### 📋 Pull Request Kuralları
- Her değişiklik mutlaka bir PR üzerinden yapılmalıdır.
- PR açıklamaları, `ISSUE_TEMPLATE` içinde belirlenen şablona uygun olarak doldurulmalıdır.

#### PR Şablonunda Olması Gerekenler
- [x] **Kontrol Listesi** işaretlenmeli
- [x] **İşe özel kabul kriterleri** aşağıdaki gibi markdown formatında girilmelidir:

  ```markdown
  - [ ] Modal penceresi doğru şekilde açılmalı
  - [ ] Giriş formu alan kontrolleri eksiksiz yapılmalı
  ```

> PR açıklamasında bu bilgiler eksikse, sistem otomatik olarak uyarı verir ve PR'ı geçersiz sayar.

### 🔍 Kod İnceleme Süreci (Code Review)
- Tüm PR’lar en az bir ekip üyesi tarafından incelenmelidir.
- İncelemede özellikle aşağıdaki sorulara dikkat edilmelidir:
  - Kontrol Listesi kriterleri sağlanmış mı?
  - Kod standartlara uygun mu?
  - Testler yeterli mi?
  - Geriye dönük uyumsuzluk (breaking change) var mı?

### 🚫 Merge Etme Kuralları
- Kod incelemesi tamamlanmadan ve onay verilmeden PR merge edilmemelidir.
- Otomatik testlerde başarısız olan PR’lar merge edilmemelidir.

---

Her katkı bizim için değerlidir, katkılarınız için şimdiden teşekkür ederiz!

> Bu rehber zamanla güncellenebilir. Lütfen her katkıdan önce gözden geçirin.
