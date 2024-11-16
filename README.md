# Kütüphane Yönetim Sistemi (Linq Join)

Bu proje, **Linq Join** kullanarak bir **Kütüphane Yönetim Sistemi** oluşturur. Sistem, iki ana tablodan oluşur: **Yazarlar** ve **Kitaplar**. Bu iki tabloyu birleştirerek kitap başlıkları ve yazarlarının adlarını listeleyen bir LINQ sorgusu yazılmıştır.

## Proje Yapısı

- **Authors (Yazarlar Tablosu)**: Yazar bilgilerini tutar.
  - `AuthorId` (int) - Yazarın benzersiz kimliği
  - `Name` (string) - Yazarın adı

- **Books (Kitaplar Tablosu)**: Kitap bilgilerini tutar.
  - `BookId` (int) - Kitabın benzersiz kimliği
  - `Title` (string) - Kitabın başlığı
  - `AuthorId` (int) - Kitabın yazarının kimliği, **Authors** tablosundaki `AuthorId` ile ilişkilidir.

## Teknolojiler ve Araçlar

- C# (CSharp)
- LINQ (Language Integrated Query)
- .NET Core (veya .NET Framework)
