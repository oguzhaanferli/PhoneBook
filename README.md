# PhoneBook
Birbirleri ile haberleşen iki microservice'in olduğu bir yapı ile telefon rehberi uygulaması.Bu uygulamada rehbere kişi ekleyip çıkarabilir, kullanıcıya birden fazla iletişim bilgisi ekleyebilir, ayrıca konuma göre kişi ve telefon sayısını getiren bir rapor oluşturabilirsiniz.


 # Core Katmanı

 Entity Class larımın bulunduğu ve Dto nesnelerimin bulunduğu katman.


 # Data Katmanı

 Entity Bağlantımın Bulunduğu katman.


 # Service Katmanı
Business kodlarının bulunduğu katman update insert ve hesaplama gibi işlemlerinin yapıldığı katman.

# Kullanılan Teknolojiler
-.NET Core
-Git
-MongoDB
-RabbitMQ

# Kurulum

Services Klasörü içerisindeki servislerin içindeki appsetting.json içerisindeki ilgili alana mongodb connectionstring yazılmalı
Report Servisine ve Web Projesinde startup dosyalarına rabbitmq url, user ve pass değiştirilmelidir.
