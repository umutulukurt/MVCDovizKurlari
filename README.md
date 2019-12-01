# MVCDovizKurlari
TCMB Günlük Döviz Kurlarının Listelendiği MVC Uygulama
Katmanlı mimari ile OOP standartları kullanılarak geliştirilmiştir.

 - BML katmanının içerisindeki DovizKuruModel nesnesi, XML dosyasındaki her bir döviz kuru modelinden gelen bilgilerin tutulması için oluşturulmuştur.
 - BML katmanının içerisindeki DovizKuruIslemleri fonksiyonu,
   https://www.tcmb.gov.tr/kurlar/today.xml adresine başvuru yaparak,
   oradaki tüm döviz kurlarını IEnumerable<DovizKuruModel> koleksiyonu
   olarak geri döndürür.
 - ConsoleTest katmanı, yapılan işlemin console ekranında testi için
   oluşturulmuştur.
 - UI katmanı, MVC projesidir. HomeController içerisindeki Index
   action'u, BML katmanındaki DovizKuruIslemleri fonksiyonundan gelen
   koleksiyonu döndürür.
 - UI katmanı içerisindeki Index.cshtml görünüm dosyasındaki model, BML
   katmanındaki DovizKuruIslemleri fonksiyonundan gelen koleksiyonu
   gösterebilmek için tanımlanmıştır.
 - UI katmanı içerisindeki DovizKuru action'u, CurrencyCode'u verilen
   döviz kurunun bilgilerini JSON formatında döndürür.
