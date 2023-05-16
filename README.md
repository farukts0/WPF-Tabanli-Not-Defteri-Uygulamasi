# frkts0
1. İlk olarak, kullanacağımız .NET framework kütüphanelerini belirtmek için `using` ifadelerini ekliyoruz.

2. `NotDefteriUygulamasi` isimli bir namespace oluşturuyoruz.

3. Bu namespace içinde `MainForm` adında bir sınıf tanımlıyoruz. Bu sınıf, uygulamanın ana formunu temsil edecek ve `Form` sınıfından kalıtım alacak.

4. `MainForm` sınıfının içinde, `dosyaYolu` adında bir değişken oluşturuyoruz. Bu değişken, açılan veya kaydedilen dosyanın yolu bilgisini tutacak.

5. `MainForm` sınıfının yapıcı (constructor) metodu olan `MainForm` adında bir fonksiyon tanımlıyoruz. Bu fonksiyon, form oluşturulduğunda çalışacak ve formun başlangıç durumunu ayarlayacak.

6. `yeniToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Yeni" menü seçeneğine tıklandığında çalışacak. İşlevi, metin alanını temizlemek ve `dosyaYolu` değerini sıfırlamak olacak.

7. `acToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Aç" menü seçeneğine tıklandığında çalışacak. İşlevi, bir dosya açma iletişim kutusu görüntüleyerek kullanıcının bir metin dosyası seçmesini sağlamak. Seçilen dosyanın içeriği `File.ReadAllText` fonksiyonuyla okunacak ve metin alanına yüklenecek.

8. `kaydetToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Kaydet" menü seçeneğine tıklandığında çalışacak. İşlevi, `dosyaYolu` değeri boş değilse, dosyayı kaydetmek. Eğer `dosyaYolu` değeri boş ise, bir dosya kaydetme iletişim kutusu görüntüleyerek kullanıcının kaydetmek istediği dosya adını ve konumunu seçmesini sağlamak.

9. `farkliKaydetToolStripMenuItem_Click` adında bir olay işleyicisi tanımlıyoruz. Bu fonksiyon, "Farklı Kaydet" menü seçeneğine tıklandığında çalışacak. İşlevi, dosya kaydetme iletişim kutusu görüntüleyerek kullanıcının kaydetmek istediği dosya adını ve konumunu seçmesini sağlamak.
