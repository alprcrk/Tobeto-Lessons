internal class Program
{
    private static void Main(string[] args)
    {
        // --------* IF Bloklarıyla Çalışmak *--------
        var number = 11;
        // Kullanım Alanı: Koşullu İşlemler, Kod Parçalarını Kontrol Etme, Hata Kontrolü, Kullanıcı Girişi Kontrolü, Koşullu Döngülerle Kullanım, Menü ve Seçenekler
        // Hava Durumu Uygulamaları, Eğitim, Alışveriş, Sosyal Medya, Otomasyon, Trafik Kuralları, Müzik ve Medya Çalarlar, Spor ve Egzersiz, Restoran Siparişleri.
        // Programlamada koşullu ifadeleri değerlendirmek ve programın çalışma akışını belirli koşullara göre yönlendirmek için kullanılan bir kontrol yapıdır.
        // Bir koşulu kontrol eder ve bu koşulun doğru (true) veya yanlış (false) olduğuna bağlı olarak belirli bir kod bloğunu çalıştırır veya çalıştırmaz.
        /*
        if (number == 10)
        {
            Console.WriteLine("Number is 10");
        }
        else if (number == 20) 
        {
            Console.WriteLine("Number is 20");
        }
        else 
        {
            Console.WriteLine("Number is not 10");
        }
        */
        // Ternary operatör, belirli bir koşulu değerlendiren ve bu koşula göre farklı değerleri döndüren bir ifadeyi kısa ve okunaklı bir şekilde yazmanızı sağlar.
        // Aynı işlemi gerçekleştiren bir if-else ifadesinin kısaltmasıdır.
        //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
        //'?' İşareti, ternary operatörün başlangıcını işaretler. Bu işaret koşulu ve sonuçları ayırır. ':' işareti, koşul false ise döndürülecek değeri ayırır.


        // --------* Switch Bloğuyla Çalışmak *--------
        // Kullanım Alanı: Menüler ve Seçenekler, Durum Makineleri, Hava Durumu Uygulamaları, Dil Desteği, Otomasyon ve Kontrol Sistemleri, Sınav Skorları ve Değerlendirmeler, Oyun Geliştirme, İşletim Sistemleri ve Uygulama Geliştirme.
        // Bir programın akışını kontrol etmek ve farklı koşullara göre işlemler gerçekleştirmek için kullanılan bir kontrol yapısıdır. Genellikle çoklu seçenekler arasında seçim yapmak için kullanılır.

        //switch (number)
        //{
        //    case 10:
        // durum1 için yapılacak işlemler
        //        Console.WriteLine("Number is 10");
        //        break;

        //    case 20;
        // durum2 için yapılacak işlemler
        //        Console.WriteLine("Number is 20");
        //        break;

        //    default:
        // hiçbir case ile eşleşmezse yapılacak işlemler
        //        Console.WriteLine("Number is not 10 or 20");
        //        break;
        //}

        // --------* Çoklu Şartlarda Çalışmak *--------
        // Çoklu şartlarla çalışmak, birden fazla koşulu aynı anda değerlendirmek ve bu koşullara göre kararlar almak anlamına gelir
        // ÖRNEK: Bir sayının yüzlük dilimlerde nereye geldiğini bulmaya çalışıcaz.

        //if (number >= 0 && number <= 100) 
        //{   sayının 0 ile 100 (dahil) arasında olup olmadığını kontrol eder. number değişkeninin değeri bu aralığa giriyorsa, "Number is between 0-100" ifadesi ekrana yazdırılır
        //    Console.WriteLine("Number is between 0-100"); 
        //}     
        //else if (number > 100 && number <= 200)
        //{   sayının 101 ile 200 (dahil) arasında olup olmadığını kontrol eder. Eğer number bu aralığa giriyorsa, "Number is between 101-200" ifadesi ekrana yazdırılır.  
        //    Console.WriteLine("Number is between 101-200")   
        //}
        //else if (number > 200 || number < 0) 
        //{   ifadesi, sayının 0'dan küçük veya 200'den büyük olduğu durumu ele alır. Sayı 0 ile 200 aralığında değilse, "Number is less than 0 or greater than 200" ifadesi ekrana yazdırılır.  
        //    Console.WriteLine("Number is lees than 0 or greater than 200");
        //}

        // --------* Nested if / İç içe if blokları *--------
        // "Nested if" veya iç içe if blokları, bir if ifadesinin içinde başka bir if ifadesinin yer aldığı bir kontrol yapısıdır.
        // Daha karmaşık koşulları ele almak ve iç içe geçmiş koşullara göre kararlar almak için kullanılır.

        //if (number < 100)
        //{
        //    if (number >= 90 && number < 95)
        //    {
        //        break;
        // Eğer number 90 ile 94 arasında ise bu koşul gerçekleşir.
        // Bu iç içe geçmiş if bloğunun içindeyken "break" kullanılarak döngüden veya döngü dışındaki bir kontrol yapısından çıkış yapılabilir.  
        //    }
        //    else
        //    {
        //        break;
        // Eğer number 90 ile 94 arasında değilse bu koşul gerçekleşir.
        // Yine iç içe geçmiş if bloğunun içindeyken "break" kullanılarak döngüden veya döngü dışındaki bir kontrol yapısından çıkış yapılabilir.
        //    }
        //}


        Console.ReadLine();
    }
}