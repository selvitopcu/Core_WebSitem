# Core_WebSitem

## Asp.Net Core 6.0 ile Sıfırdan Hazırlanan Dinamik Kişisel Web Sitesi

Bu poje Entity Framework Core | Repository Design Pattern | Unit of Work | Deploy | Fluent Validation | Api | N Tier Architecture | Restful Api | Unit of Work | Ajax ve daha fazlası kullanılarak udemyde yayınlanan 28,5 eğitim referans alarak 243 derste hazırlanmıştır.

Admin, yazar ve vitrin panelinden oluşmaktadır.

Eğitim serisine [eğitim linki](https://www.udemy.com/share/1063qk3@mSodeojNOb3znHls4-r68LcNoQSkR4niIEmgH1HyUpTlDneUlqOxoKmwOk-wrWOI/) ulaşabilirsiniz.

Proje görselleri ise sona ek olarak eklenmiştir.



### 1.Bölüm Giriş

Katmanlı mimariye bakış yapılarak katmanlar oluşturuldu.

Entityler tanımlandı. 

Entity Core paketleri kuruldu.

Key attibuteler tanımlandı.



### 2.Bölüm Migration ve Referans İşlemleri

DbContext sınıfı ve bağlantı yapılandırması tamamlandı.

Katmanlar arası referans işlemi yapıldı.

Context sınıfı dbsetler tanımlanarak Migration işlemi tamamlandı.



### 3.Bölüm Interfaceler

Interfacelerin yazılarak Generic Interfaceler oluşturuldu.

Generic Repository ve EntityFramework Dal oluşturuldu.



### 4.Bölüm Generic Servisler

Generic Service oluşturuldu.Abstract klasöründe serviceler tanımlandı.

Manager sınıfları tanımlandı.



### 5.Bölüm Temanın Eklenmesi ve Default Kısmı

Tema dahil edilerek temada görseller düzenlendi

Partial view kullanımı çalışmaları gerçekleştirilerek. Navbar partial oluşturuldu.

ViewComponents kullanımına değinilerek Feature List, About List, Service List, Skill List, Skill, Portfolio, Experience, Testimonials alanları oluşturuldu.

İletişim alanları, iletişim bilgileri listeleme işlemleri yapıldı.

Mesaj paneli hazırlanarak mesaj gönderme işlemi gerçekleştirildi.



### 6.Bölüm Admin Teması ve Layout

Admin teması eklenerek Layout ve Render Body ayarlandı.

Partial SideBar oluşturuldu.



### 7.Bölüm Yetenekler

Yeteneklerin listelendi. Admin Layout alanlarında partial düzenlemeleri yapıldı.

Yeni yetenek ekleme işlemi gerçekleştirildi.

Layout üst menü düzenlemesi yapıldı.

Navigation kısmına sayfa adı yazdırma işlemi yapıldı.

Yetenek silme, yetenek düzenleme, güncelleme işlemleri yapıldı.



### 8.Bölüm Deneyimler

Deneyimlerin listelenmesi, yeni deneyim ekleme, güncelleme ve silme işlemleri yapıldı.



### 9.Bölüm Portfolio İşlemleri

Proje listesi oluşturuldu.

Portfolio Entity düzenlemeleri yapılarak portfolio listelenmesi, tablonun düzenlenmesi, portfolio ekleme işlemleri gerçekleştirildi.



### 10.Bölüm Fluent Validation

Fluent validation paketleri kurularak rulefor metodu ile kontroller oluşturuldu. Validasyon Backend, Message For işlemleri yapıldı.

Portfolioda silme ve portfolio güncelleme işlemleri yapıldı.



### 11.Bölüm Feature ve About

Feature ve About Düzenlemeleri yapıldı.
Service List ile Servis işlemleri tamamlandı.



### 12.Bölüm DAshboard

Dashboard işlemleri yapıldı.



### 13.Bölüm Tema Değişikliği

Bu bölümde tema değişikliğine gidildi. Yeni tema eklendi. Layout ve yetenek düzenlemeleri yapıldı.



### 14.Bölüm Yeni Temada Dashboard

Dashboard feature statistcis oluşturuldu.  

Bildirim açılma hatası vardı düzenlendi.

İstatistiklerin yazılması işlemi yapıldı.
 
Son 5 proje listesi oluşturuldu. Statik veri girişi yapıldı.

Dashboard sol menü düzenlendi. proje listesi ve mesaj paneli oluşturuldu.



### 15.Bölüm Dashboard İşlemlerinin Devamı

User tablosu oluşturularak Code First relation gerçekleştirildi. Migration revizesi yapıldı.

Örnek veri girişleri yapıldı.

Mesaj listeleme işlemi yapıldı ve mesaj panelini tamamlandı.

Include metodu kullanıldı.

Slide paneli oluşturuldu.

TodoList entity, ToDoList listesi oluşturuldu. 

Visit By Countries işlemi taşındı.



### 16.Bölüm Area

Areas tanımlanarak Configurasyon işlemi gerçekleştirildi.

Writer layout oluşturularak layoutta revizeler gerçekleştirildi.

Layout partial eklendi.



### 17.Bölüm ASP Core Identity

Register formu oluşturuldu.

Identity kütüphaneleri kuruldu Identity Db Context oluşturuldu.

Identity tabloları incelendi.

UserRegisterViewModel oluşturularak Identity işlemleri gerçekleştirildi.

Register backend işlemleri ve Register sayfa tasarımı yapıldı.

Tag Helpers kullanımına değinildi.

Register işleminin gerçekleştirilerek password hata listesi oluşturuldu.



### 18.Bölüm Login İşlemleri

Login teması eklenerek Login işlemi gerçekleştirildi.

Access Failed Count işlemi yapıldı.



### 19.Bölüm Duyurular

Duyuru tablosu oluşturularak duyurular listelendi.

Duyuru Status renklendirme işlemleri yapılarak tarih formatı düzenlendi.

Duyuru detayları oluşturuldu.



### 20.Bölüm Profil Sayfası

Profile sayfası oluşturuldu.

Profile User Manager ile bilgileri getirme işlemi yapıldı.

User Edit View Model, Update User Controller , Update user View Model oluşturularak Update işlemi gerçekleştirildi.

Dosyadan resim yükleme işlemi yapıldı.



### 21. Bölüm Webden Api İle Veri Alma

Dashboard For Writer oluşturuldu.

Giriş yapan kullanıcın ad soyad bilgisi ve kullanıcı resmi getirildi.

Yazar Dashboard istatistik oluşturuldu.

Api ile hava durumu bilgisi çekildi.

Yazar Layout düzenlendi. Bildirim ayarı yapılarak bildirimler listelendi.



### 22.Bölüm Mesajlar

Mesaj tablosu oluşturularak katman işlemleri gerçekleştirildi.

Linq Expression Filter işlemi yapıldı

Yemi metodun Manager sınıflarına eklenmesi sağlandı.

Giriş yapan kullanıcıya ait mesajlar listelendi.

Writer Message Snder Receiver metotları oluşturuldu.

Gelen ve giden mesajlar listelendi.

Layout düzenlemeleri yapıldı. Menü ikonları ayarlandı.

Gelen mesaj detayları, giden mesaj detayları ve yeni mesaj gönderme işlemleri gerçekleştirildi.

Mesaj gönderirken alıcı adının eklenmesi sağlandı.

Dashboard eksik istatistikler tamamlandı.

Şifre güncelleme, Area Route, id ile Area Route ayarları ve LogOut işlemi gerçekleştirildi.



### 23.Bölüm Admin Alanı Bazı Detaylar

Admin düzenlemeleri yapıldı.

Deneyimlerde revizeler gerçekleştirildi.

Yetenekler ve hakkımda sayfası düzenlemeleri yapıldı.

Portfolio düzenlemeleri yapıldı.

Service düzenlemeleri yapıldı.

Contact admin yapılarak silme, detay işlemleri gerçekleştirildi.

Admin Receiver Message ve Admin Sender Message oluşturuldu.

Admin mesaj işlemleri detayları oluşturuldu.

Mesaj alıcı ismi ekleme sağlandı.

Admin mesaj gönderme işlemi yapıldı.



### 24.Bölüm Sosyal Medya ve Referanslar

Testimonial Index, Testimonial details sayfaları oluşturuldu.

SubContent place oluşturuldu

Sosyal medya alanı oluşturularak listelemei ekleme, düzenleme ve silme işlemleri gerçekleştirildi.

Default sosyal medya component view oluşturularak default kısmında sosyal medya hesapları listelendi.



### 25.Bölüm Admin Üst Menü

Üst menü yeni proje ekleme paneli oluşturularak üst menü mesaj listesi tasarımı yapıldı.

Üst menü mesaj listesi ve bildirim listesi yapılarak dashboard tamamlandı.



### 26.Bölüm Rolleme

Rollerin girilmesi sağlandı.

Proje seviyesinde authorize işlemi tamamlandı.

Login path yapıldı.

Rolleme temelleri atıldı ve rol üzerinden erişim sağlandı.

Access denied sayfası oluşturuldu.

401 sayfası özelleştirildi.



### 27.Bölüm Ajax

WriterUser tanımlandı. 

Ajax'a değinilerek ajax ile statik ve dinamik verilerin console log ile gösterilmesi sağlandı.

Ajax experience oluşturuldu.

Veriler Ajax ile tabloda gösterildi.

Ajax ile deneyim ekleme ve silme işlemleri yapıldı.

Id'lerin console'da loglanması, Id'ye göre Console'da loglama yapıldı.

Return json, Ajax script required false incelendi.

Id'ye göre getirilen deneyim tabloda listelendi.




### 28.Bölüm Hata Sayfaları

Error status code page incelendi. Error page oluşturularak 404 sayfası hazırlandı



### 29.Apiler

Apilere değinilerek Api ayağa kaldırıldı.

Api Projesi İçin Db oluşturuldu.

Apilerle Get isteği, ID'ye Göre Get isteği yapıldı.

Apiler üzerinden ekleme, silme, güncelleme işlemleri yapıldı.



### 30.Postman

Postman ile Get isteği, Post isteği yapıldı.

Postman ile silme ve güncelleme işlemleri yapıldı.



### 31.Son Bakış

Default sayfasına, yazar paneline ve admin dashboarda son bakış yapıldı.

Testimonialda düzenlemeler ve Testimonial ekleme işlemi yapıldı.

Üst menüde son düzenlemeler yapıldı.

Admin açılır 3 noktalı menü düzenlendi.

Rolleme işlemi tamamlandı.



### 32.Bölüm projeyi canlıya alma aşamasıdır. Henüz tamamlanmamıştır.




## Proje Görselleri



![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaVcF.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVauwi.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVah1C.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaALG.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaJm1.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaLbT.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaP6L.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVanvo.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaqP3.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVacpK.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaU1Q.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVaFCM.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVavb7.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVcMuH.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVcf3R.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVcSvc.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVcNCy.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVcWtj.png)
![Proje Görseli](https://resmim.net/cdn/2023/08/23/SVcmpn.png)
