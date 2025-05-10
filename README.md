# 📧 Identity Email Projesi – .NET Core 8.0

Bu proje, ASP.NET Core 8.0 kullanılarak hazırlanmış, kullanıcıların e-posta benzeri mesajlaşma işlemlerini gerçekleştirebildiği bir **Email & Chat uygulamasıdır**.

---

## 🔧 Kullanılan Teknolojiler

- ✅ ASP.NET Core 8.0  
- ✅ Entity Framework Core (Code First)  
- ✅ MS SQL Server  
- ✅ ASP.NET Core Identity  
- ✅ Bootstrap 4  
- ✅ LINQ  
- ✅ Razor Views  

---

## 🏗️ Genel Özellikler

- Tek katmanlı mimari yapısı
- UI bileşenlerinin PartialView ile yönetimi
- EF Core ile veritabanı bağlantısı
- ASP.NET Core Identity ile güvenli kullanıcı yönetimi

---

## 🖥️ Sayfa Yapısı

### 🔐 1. Kayıt Sayfası (Register)
- Kullanıcı kayıt işlemleri
- Şifreler hash’lenerek veritabanında saklanır
- Güçlü şifre doğrulaması için validator kuralları tanımlanmıştır

![Ekran görüntüsü 2025-05-10 214730](https://github.com/user-attachments/assets/a50f494f-2787-4bf4-ad33-ea03028ffc3a)

![Ekran görüntüsü 2025-05-10 214810](https://github.com/user-attachments/assets/d9284345-d391-4e96-b1e6-17f5c7fa274e)

### 🔑 2. Giriş Sayfası (Login)
- Kullanıcı kimlik doğrulama
- 5 hatalı girişten sonra 5 dakikalık geçici engelleme
  
![Ekran görüntüsü 2025-05-10 214653](https://github.com/user-attachments/assets/c0b48b69-45fd-4863-bb4d-b0205ca3eae0)

![Ekran görüntüsü 2025-05-10 214830](https://github.com/user-attachments/assets/c2068246-e00c-457e-baac-f5a84037c1e8)

### 🧑‍💼 3. Kullanıcı Paneli

- 📝 Profilim  
- 📥 Gelen Kutusu  
- 📤 Giden Kutusu  
- 🗑️ Çöp Kutusu  
- ➕ Yeni Mesaj Gönder  
- 🔍 Arama Çubuğu  
- 🚪 Çıkış Yap  

---

## ✉️ Mesaj Yönetimi Özellikleri

- Gelen ve giden mesajlar listelenebilir  
- Arama çubuğu ile filtreleme yapılabilir  
- Eşleşme yoksa boş içerik gösterilir  
- Çoklu mesaj seçilebilir  
- Seçilen mesajlar **okundu** olarak işaretlenebilir  
- Mesajlar çöp kutusuna taşınabilir  
- Sidebar’daki mesaj sayısı **anlık** olarak güncellenir  

![Ekran görüntüsü 2025-05-10 215242](https://github.com/user-attachments/assets/338a71b9-b672-4cc7-9aa5-bc800e4c42a4)

![Ekran görüntüsü 2025-05-10 215250](https://github.com/user-attachments/assets/a58422b8-a8ba-4db3-a52f-ca96368b7720)

![Ekran görüntüsü 2025-05-10 215312](https://github.com/user-attachments/assets/d3bd62ad-4d5b-4d5a-812c-3e9c039bf1b0)

---

## 📝 Yeni Mesaj Oluşturma

- Alıcı, konu ve içerik alanlarıyla mesaj gönderimi  
- Başarılı gönderim sonrası **SweetAlert** ile kullanıcı bilgilendirilir  

![Ekran görüntüsü 2025-05-10 215303](https://github.com/user-attachments/assets/fd2d015e-2768-48c9-89f1-fd8d2eb96de1)

![Ekran görüntüsü 2025-05-10 215258](https://github.com/user-attachments/assets/66e17497-4882-4445-9683-81f60f315296)

---

## 👤 Profil Sayfası

- Kullanıcının adı, soyadı, e-posta adresi ve kullanıcı adı görüntülenir  
- Gönderilen ve alınan mesaj sayıları **dinamik** olarak hesaplanır  
- Tüm kullanıcı bilgileri güncellenebilir
  
![Ekran görüntüsü 2025-05-10 215231](https://github.com/user-attachments/assets/5f48cfce-4c0c-4418-8900-bdd0ec5775a3)

![Ekran görüntüsü 2025-05-10 215324](https://github.com/user-attachments/assets/57705d50-f638-48e1-bc8e-68d4301c148a)




