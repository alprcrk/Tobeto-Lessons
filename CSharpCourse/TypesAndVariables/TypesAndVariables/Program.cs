internal class Program
{
    private static void Main(string[] args)
    {
        //Value Types

        //Console.WriteLine("Hello World!");
        // --------* Integer Veri Tipi *--------
        // (4-Byte ** 32-BİT) 
        // Kullanımı Alanı: Genel Kullanım, Diziler ve Koleksiyonlar, Sayaçlar ve İndisler, İşlemci Kaynakları, Dosya Boyutları, Hesaplamalar ve Matematiksel İşlemler,
        // Makine Dili ve Donanım Düşeyi Programlama, Sıralı Sayılar, Oyuncu Puanları ve Skorlar, Döngü Sayacı, ID ve Kimlik Tanımlayıcıları, Sayısal Kimlik Doğrulama, Veri Sıkıştırma ve Şifreleme 

        // int tam sayı veri tipidir. Ondalıklı olmayan sayılarımızı integer ile tutarız.
        int number1 = 2147483647;  // Pozizitif durumda integerin sınırı
        int number2 = -2147483648; // Negatif durumda integerin sınırı
        Console.WriteLine("number1 is {0}, number2 is {1}", number1, number2); // her bir süslü parantez içerisindeki değer ilgili değişkenin indexini gösterir.


        // --------* Long Veri Tipi *--------
        // (8-Byte ** 64 BİT)
        // Kullanımı Alanı: Büyük Sayılar, Zaman İşleme, Dosya Boyutları ve Bellek Yönetimi, ID Değerleri ve Tanımlayıcılar, Bilimsel Hesaplamalar ve Mühendislik,
        // Mikrosaniye Zaman Ölçümleri, Donanım Kontrolü ve Saat Sinyalleri

        //2 milyardan daha büyük bir sayıyı tutmak istersek (long) veri tipini kullanabiliriz.
        //Integerın tam 2 katı kadar bellekte yer kaplıyor.
        long number3 = 9223372036854775807; // Pozizitif durumda Long un sınırı
        long number4 = -9223372036854775808; // Negatif durumda Long un sınırı
        Console.WriteLine("number3 is {0}",number3);
        Console.WriteLine("number4 is {0}", number4);

        // --------* Short Veri Tipi *--------
        // (2-Byte ** 16 BİT)
        // Kullanımı Alanı: Bellek Tasarrufu, İşlemci Verileri, Resim İşleme, Ses İşleme, Yerel Maksimum ve Minimum Sınırlar, Performans Optimize Algoritmaları, Düşük Veri İletimi
        // Bu veri türü, bellek kullanımını azaltmak ve performansı artırmak için gerektiğinde küçük tamsayılar saklamak için kullanılır.
        short number5 = 32767;  // Pozizitif durumda Short un sınırı 
        short number6 = -32768; // Negatif durumda Short un sınırı                      
        Console.WriteLine("number5 is {0}",number5);
        Console.WriteLine("number6 is {0}", number6);

        // --------* Byte Veri Tipi *--------
        // (1-Byte ** 8 BİT)
        // Kullanım Alanı: Resim İşleme ve Ses İşleme, Veri Sıkıştırma ve Şifreleme, Dosya İşleme, Donanım İşlemleri, Ağ İşlemleri, Veri Dönüşümleri, Bellek Yönetimi
        // yalnızca pozitif tamsayı değerlerini saklayabilir ve değeri 0 ile 255 arasında değişebilir. 
        byte number7 = 255; 
        Console.WriteLine("number7 is {0}", number7);

        // --------* Bool Veri Tipi *--------
        // Kullanım Alanı: Koşullu İfadeler, Döngüler, Mantıksal İşlemler, Fonksiyonların Geri Dönüş Değerleri, Kullanıcı Girişi ve Onay Kutuları, Hata Denetimi
        //boolean (mantıksal) değerleri temsil etmek için kullanılan bir veri türüdür. Genellikle koşullu ifadelerde ve karar verme işlemlerinde kullanılır.
        //bool yalnızca iki farklı değeri saklayabilir: true (doğru) ve false (yanlış).
        bool condition = false; // true

        //ÖRNEK
        int yas = 20; // Kullanıcının yaş bilgisi
        bool yetiskinMi = (yas >= 18); // "yetiskinMi" adında bir bool değişkeni oluşturuyoruz ve yaşın 18 veya daha büyük olup olmadığını kontrol ediyoruz.
        if (yetiskinMi)
        {
            Console.WriteLine("Bu kişi yetişkindir.");
        }
        else
        {
            Console.WriteLine("Bu kişi henüz bir çocuktur.");
        }

        // --------* Char Veri Tipi *--------
        // Kullanım Alanı: Metin İşleme,Tek Karakter Girişi, Karakter Dizileri (Strings), ASCII ve Unicode Temsili, Sembolik Karakterler
        // Karakter (character) verilerini temsil etmek için kullanılan bir veri türüdür. Harf, rakam, özel bir sembol veya boşluk gibi tek bir yazı sembolünü ifade eder.
        char character = 'A';  // Kolay int olur
        char karakter = 'A';   // Tek bir karakteri temsil eden bir char değişkeni
        Console.WriteLine("Karakter : {0}",karakter);
        Console.WriteLine("Character is : {0}",(int)character);

        // --------* Double Veri Tipi *--------
        // Kullanım Alanı: Ondalık Hesaplamalar, Para ve Finansal İşlemler, Grafik ve 3B İşlemler, Bilimsel Araştırmalar
        // Integer, short byte, long dan farklı olarak ondalıklı sayıları tutabiliriz.
        double number8 = 10.4; //ondalıklı sayıları tutar
        Console.WriteLine("number8 is {0}", number8);

        // --------* Decimal Veri Tipi *--------
        // (16-Byte ** 128 BİT)
        // Kullanım Alanı: Para ve Finansal İşlemler, Vergi Hesaplamaları, Miktarlar ve Oranlar, Mühendislik ve Bilim, İlaç ve Sağlık Bilimleri
        // decimal yaklaşık olarak 28-29 basamak hassasiyetle ondalık sayıları saklayabilir. Bu, hassas finansal hesaplamalar ve diğer yüksek hassasiyet gerektiren uygulamalar için uygundur.
        decimal number9 = 100.50M; // İlk hassas ondalık sayı
        decimal number10 = 25.75M;  // İkinci hassas ondalık sayı
        Console.WriteLine("number9 is {0}", number9);
        Console.WriteLine("number10 is {0}", number10);

        // --------* Enum Veri Tipi *--------
        // Kullanım Alanı: Sabir Değerlerin Gruplandırılması, Okunabilirlik ve Düzen, Daha Güvenli Kod, Değerlerin İlişkilendirilmesi 
        // Bir grup sabit değeri temsil etmek için kullanılına bir veri türü. Durumları seçenekleri belirli bir veri türü için sınırlı bir değer kümesini temsil etmek için kullanılır.
        Console.WriteLine(Days.Friday);
        Console.WriteLine((int)Days.Friday);

        // --------* Var Keyword *--------
        // Kullanım Alanı: Veri Türü Belirsizliği, Anonymous Types, Dinamik Değişkenler
        // Genellikle değişkenlerin veri türünü belirtmek yerine derleyicinin veri türünü otomatik olarak çıkarmasına (çözümlemesine) izin vermek için kullanılır.
        // Var bir değişken değildir. değişken tutmak için kullanılan bir keyworddur.
        // Örnekte ilk olarak integer olarak tanımladığımız için ikinci atamadaki A karakterinin ASCII değerini döndürür yani integer değer olarak döndürür.
        // Başta ne veri tipinde verdiysek o şekilde devam edecektir var'da.
        var number11 = 10;
        number11 = 'A';
        //number7 = "A";
        Console.WriteLine("number11 is {0}", number11);
        Console.ReadLine(); 
    }
}
    enum Days
    {
        Monday=10,Tuesday=20, Wednesday=30,Thursday,Friday,Saturday,Sunday
        //Monday =10, Tuesday=20, Wednesday, Thursday, Friday, Saturday, Sunday ---> şeklinde değişkenin başlangıç değerini de belirleyebilir, her birine farklı değer de atayabiliriz.
    }