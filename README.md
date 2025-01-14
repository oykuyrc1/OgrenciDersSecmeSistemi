#Öğrenci ve Ders Yönetim Sistemi

#Projeyi Çalıştırmak

#Uygulamayı başlatmak için aşağıdaki komutları sırasıyla kullanabilirsiniz.
dotnet restore
dotnet build
dotnet run


#Bu proje, öğrenci ve ders yönetimi yapmak için geliştirilmiş bir uygulamadır. Uygulama, öğrenci, öğretim görevlisi ve derslerle ilgili bilgileri saklar, ders seçme ve ders kaydı işlemlerini sağlar. Veriler XML formatında saklanır ve okunur.

#proje yapısı
OgrenciDersYonetimSistemi/
├── Models/
│   ├── BaseEntity.cs
│   ├── Ogrenci.cs
│   ├── OgretimGorevlisi.cs
│   ├── Ders.cs
├── Data/
│   ├── XmlHelper.cs
│   ├── MockData.cs
├── Program.cs


#Öğrenciler, öğretim görevlileri ve dersler XML dosyasına kaydedilir ve burada tutulur.
Öğrenciler ders seçim işlemi yapabilirler.
Sistem, öğrenci bilgilerini, öğretim görevlisi bilgilerini ve derslerin detaylarını listeler.
Polymorphism (Çok Biçimlilik) kullanılarak, farklı türlerdeki nesnelerle aynı metod üzerinden işlem yapılır.

#Veriler XML formatında kaydedilir ve aşağıdaki formatta bir XML dosyasına yazılır
