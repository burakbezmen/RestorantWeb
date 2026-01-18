[20:02, 18.01.2026] Sabri Sabri: 🚀 İlk Web Projemi Tamamladım!
Merhaba LinkedIn ailesi! 👋

Lise 11. sınıf öğrencisi olarak ilk web uygulama projemi başarıyla tamamladım ve sizlerle paylaşmak istedim.

📌 Proje: Restoran Menü Yönetim Sistemi
Bu projede bir restoranın menüsünü yönetebileceğiniz tam fonksiyonel bir web uygulaması geliştirdim.

🛠️ Kullandığım Teknolojiler:
ASP.NET Core MVC - Web framework
C# - Backend programlama dili
SQL Server - Veritabanı
Dapper - Micro ORM (Object-Relational Mapping)
Bootstrap 5 - Modern ve responsive UI tasarımı
Bootstrap Icons - Görsel zenginlik
✅ Projenin Özellikleri:
CRUD İşlemleri (Create, Read, Update, Delete)
Yeni menü ekleme
Mevcut menüleri listeleme
Menü güncelleme
Menü silme
Modern ve kullanıcı dostu arayüz
Responsive tasarım
💡 Bu projede öğrendiklerim:
MVC mimarisi
Veritabanı bağlantısı ve SQL sorguları
Backend-Frontend entegrasyonu
Kullanıcı arayüzü tasarımı
Yazılım dünyasına ilk adımlarımı atıyorum ve öğrenmeye devam ediyorum. Geri bildirimlerinizi bekliyorum! 🙏

#AspNetCore #CSharp #SQL #Dapper #Bootstrap #WebDevelopment #CRUD #İlkProje #Yazılım #LiseÖğrencisi #Coding #Programming
[20:04, 18.01.2026] Sabri Sabri: # 🍽️ Restoran Menü Yönetim Sistemi

Lise 11. sınıf öğrencisi olarak geliştirdiğim ilk web uygulaması projesidir. Bu uygulama ile bir restoranın menüsünü kolayca yönetebilirsiniz.

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

## 📌 Proje Hakkında

Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş bir restoran menü yönetim sistemidir. Temel CRUD (Create, Read, Update, Delete) işlemlerini içermektedir.

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|-----------|----------|
| *ASP.NET Core MVC* | Web framework |
| *C#* | Backend programlama dili |
| *SQL Server* | Veritabanı |
| *Dapper* | Micro ORM |
| *Bootstrap 5* | CSS framework |
| *Bootstrap Icons* | İkon kütüphanesi |

## ✨ Özellikler

- ✅ Menü listeleme
- ✅ Yeni menü ekleme
- ✅ Menü güncelleme
- ✅ Menü silme
- ✅ Modern ve responsive tasarım
- ✅ Kullanıcı dostu arayüz

## 📸 Ekran Görüntüleri

### Menü Listesi
> Tüm menüleri görüntüleyebilir, güncelleyebilir veya silebilirsiniz.

### Yeni Menü Ekleme
> Yeni yemekler ekleyebilirsiniz.

### Menü Güncelleme
> Mevcut menüleri düzenleyebilirsiniz.

## 🚀 Kurulum

### Gereksinimler
- .NET 8.0 veya üzeri
- SQL Server
- Visual Studio 2022 (önerilen)

### Adımlar

1. *Projeyi klonlayın*
bash
git clone https://github.com/kullanici-adiniz/restoran-menu-yonetim.git


2. *Veritabanını oluşturun*
sql
CREATE DATABASE Restorant;

USE Restorant;

CREATE TABLE Menü (
    Id INT PRIMARY KEY IDENTITY(1,1),
    YemekAdı NVARCHAR(100),
    Fiyat DECIMAL(10,2)
);


3. *Connection string'i güncelleyin*

MenuController.cs dosyasındaki bağlantı dizesini kendi SQL Server bilgilerinize göre düzenleyin:
csharp
string baglanti = "Server=SUNUCU_ADI;Database=Restorant;Trusted_Connection=True;TrustServerCertificate=True;";


4. *Projeyi çalıştırın*
bash
dotnet run


5. *Tarayıcıda açın*

https://localhost:7008/Menu/List


## 📁 Proje Yapısı


WebApplication3/
├── Controllers/
│   └── MenuController.cs      # CRUD işlemleri
├── Models/
│   └── Menü.cs                # Menü modeli
├── Views/
│   └── Menu/
│       ├── List.cshtml        # Menü listesi
│       ├── Create.cshtml      # Yeni menü ekleme
│       └── Update.cshtml      # Menü güncelleme
└── README.md


## 📝 API Endpoints

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | /Menu/List | Tüm menüleri listele |
| GET | /Menu/Create | Yeni menü formu |
| POST | /Menu/Create | Yeni menü ekle |
| GET | /Menu/Update/{id} | Menü güncelleme formu |
| POST | /Menu/Update | Menü güncelle |
| GET | /Menu/Delete/{id} | Menü sil |

## 🎓 Öğrendiklerim

Bu proje sayesinde:
- MVC mimarisini
- Veritabanı bağlantısı ve SQL sorgularını
- Dapper ORM kullanımını
- Bootstrap ile responsive tasarımı
- CRUD işlemlerini

öğrenme fırsatı buldum.

## 📧 İletişim

Sorularınız için benimle iletişime geçebilirsiniz.

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!
