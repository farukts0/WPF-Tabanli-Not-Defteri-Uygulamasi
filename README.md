# notdefteriuygulaması

Uygulama, bir ana formdan oluşacak ve aşağıdaki özelliklere sahip olacak:

1. Menü çubuğu: Uygulama, bir menü çubuğu içerecek. Menü çubuğunda "Dosya" başlığı altında "Yeni", "Aç", "Kaydet" ve "Farklı Kaydet" seçenekleri bulunacak.

2. Metin alanı: Ana form üzerinde bir metin alanı (TextBox) olacak. Bu alan, kullanıcının metin girişi yapabileceği ve metin dosyalarını görüntüleyebileceği bir bölüm olacak.

3. Yeni dosya oluşturma: "Yeni" seçeneğine tıklandığında, metin alanı temizlenecek ve dosya yolu sıfırlanacak. Kullanıcı yeni bir dosya oluşturduğunda, mevcut metin kaybolacak.

4. Dosya açma: "Aç" seçeneğine tıklandığında, bir dosya açma iletişim kutusu görüntülenecek.

5. Dosya kaydetme: "Kaydet" seçeneğine tıklandığında, eğer 'dosyaYolu' değeri boş değilse, mevcut metin dosyası üzerine kaydedilecek. Eğer 'dosyaYolu' değeri boş ise, bir dosya kaydetme iletişim kutusu görüntülenecek ve kullanıcı kaydetmek istediği dosya adını ve konumunu seçecektir.

6. Farklı kaydetme: "Farklı Kaydet" seçeneğine tıklandığında, dosya kaydetme iletişim kutusu görüntülenecek ve kullanıcı kaydetmek istediği dosya adını ve konumunu seçecektir. Bu seçenek, mevcut metni yeni bir dosyaya kaydetmek için kullanılacak.


Uygulama temel olarak şu bileşenlere sahip olacak:

1. Menü çubuğu: Ana formun en üstünde bir menü çubuğu bulunacak. Bu menü çubuğu, "Dosya" başlığı altında "Yeni", "Aç", "Kaydet" ve "Farklı Kaydet" gibi seçenekleri içerecek. Kullanıcı bu seçeneklere tıklayarak ilgili işlemleri gerçekleştirebilecek.

2. Metin alanı: Ana formda bir metin alanı (TextBox) bulunacak. Bu metin alanı, kullanıcının metin girişi yapabileceği ve mevcut metin dosyasının içeriğini görüntüleyebileceği bir alandır. Metin alanı, genellikle formun büyük bir bölümünü kaplayacak şekilde yerleştirilecektir.

3. Diğer bileşenler: Bunların yanı sıra, uygulama tasarımına bağlı olarak başka bileşenler de eklenebilir. Örneğin, bir toolbar (araç çubuğu) eklenerek kullanıcının bazı işlevlere hızlı erişim sağlanabilir. Ayrıca, durum çubuğu gibi bir bileşen de eklenerek kullanıcıya bilgi sağlanabilir, örneğin mevcut dosyanın adı veya dosyanın kaydedilip kaydedilmediği gibi bilgiler gösterilebilir.

4. Tasarımın kullanıcı dostu ve kullanılabilir olması için, temiz bir arayüz, düzenli yerleşim, uyumlu renkler ve okunaklı yazı tipleri gibi unsurları kullanmayı düşünüyorum.



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
