# notdefteriuygulaması

Yapacağım not defteri uygulaması basit bir arayüze sahip olacaktır. 

Kullanıcılar akıllarında kalmayan şifreleri, kullanıcı isimleri, ileri tarihli planları, unutmaması gereken bilgilere anında ulaşmak için kullanacakları bir uygulama yapmayı düşünüyorum.

Arayüzünde not ekleme, not silme, kaydetme, farklı kaydetme seçenekleri olucak.

Not ekleme seçeneği kullanıcının yazmayı istediği bilgiyi gireceği sayfaya gitmesine yardımcı olucak.

Not silme seçeneği kullanıcının silmeyi istediği bilgiyi silip anasayfaya göndericektir.

Kaydetme seçeneği yazılan notun uygulamaya kaydedilmesini sağlayacak.

Farklı kaydet seçeneği ise kullanıcının kaydetmek istedği notu dosya kaydetme iletişim kutusu görüntüleyerek kullanıcının kaydetmek istediği dosya adını ve konumunu seçmesini sağlayacaktır.


Geliştirme Adımları

1. İlk olarak, kullanacağımız .NET framework kütüphanelerini belirtmek için `using` ifadelerini ekliyoruz.

2. `NotDefteriUygulamasi` isimli bir namespace oluşturuyoruz.

3. Bu namespace içinde `MainForm` adında bir sınıf tanımlıyoruz. Bu sınıf, uygulamanın ana formunu temsil edecek ve `Form` sınıfından kalıtım alacak.

4. `MainForm` sınıfının içinde, `dosyaYolu` adında bir değişken oluşturuyoruz. Bu değişken, açılan veya kaydedilen dosyanın yolu bilgisini tutacak.

5. `MainForm` sınıfının yapıcı (constructor) metodu olan `MainForm` adında bir fonksiyon tanımlıyoruz. Bu fonksiyon, form oluşturulduğunda çalışacak ve formun başlangıç durumunu ayarlayacak.

6. `yeniToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Yeni" menü seçeneğine tıklandığında çalışacak. İşlevi, metin alanını temizlemek ve `dosyaYolu` değerini sıfırlamak olacak.

7. `acToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Aç" menü seçeneğine tıklandığında çalışacak. İşlevi, bir dosya açma iletişim kutusu görüntüleyerek kullanıcının bir metin dosyası seçmesini sağlamak. Seçilen dosyanın içeriği `File.ReadAllText` fonksiyonuyla okunacak ve metin alanına yüklenecek.

8. `kaydetToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Kaydet" menü seçeneğine tıklandığında çalışacak. İşlevi, `dosyaYolu` değeri boş değilse, dosyayı kaydetmek. Eğer `dosyaYolu` değeri boş ise, bir dosya kaydetme iletişim kutusu görüntüleyerek kullanıcının kaydetmek istediği dosya adını ve konumunu seçmesini sağlamak.

9. `farkliKaydetToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Farklı Kaydet" menü seçeneğine tıklandığında çalışacak. İşlevi, dosya kaydetme iletişim kutusu görüntüleyerek kullanıcının kaydetmek istediği dosya adını ve konumunu seçmesini sağlamak.
