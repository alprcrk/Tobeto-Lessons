internal class Program
{
    private static void Main(string[] args)
    {
        //Intro();
        string sentence = "My name is Alper Çırak";

        //Yukarıda ki cümlenin kaç karakterden oluşturduğunu verir.
        var result = sentence.Length;
        // İlgili cümlenin yani string değerin bir referansını daha oluşturmaya yarar. Adı üstüne clonlamaya yarar.
        // Bu clonlama ifadesiyle aslında biz 1 tane daha değişken oluşturmuş olduk.
        // Biz her ne kadar result2 = sentence.Clone(); desekte bizim yaptığımız şey cümleyi alıp tamamen referans
        // oluşturmak şeklinde olacağı için sentence ben değiştirsemde result2'yi değiştirememiş oluyorum.
        var result2 = sentence.Clone();
        //BU cümle örneğin yumuşak ğ ile bitiyormu şeklinde.
        // Bitiyorsa 'TRUE' bitmiyorsa 'FALSE' bir sonuç alırız.
        bool result3 = sentence.EndsWith("ğ");
        // Örneğin Bu cümle 'A' Yerine My name ile başlıyor mu gibi kullanımı vardır. 
        bool result4 = sentence.StartsWith("A");
        // Bir sitringte belli bir karakteri veya ifadeyi aramak için kullanılır
        // Sentence içinde 'name'yi arar.
        // Bulamadığında -1 değer döndürür.
        // Boşluğu bile arar 0,1,2 gibi
        var result5 = sentence.IndexOf("name");
        // LastIndexOf aramayı sondan başlar farkları budur.
        var result6 = sentence.LastIndexOf("name");
        // Bir cümleye veya string ifadeye başka bir metni yerleştirmek için kullanılır.
        var result7 = sentence.Insert(0,"Hello, " );
        // Bu metni parçalamak için kullanılır metni parçalamak demek şu metinin belli bir yerinden itibaren değeri almaktır.
        // 1. 2. 3. 4. karakterden itibaren 4 tane al gibi
        var result8 = sentence.Substring(3,4);
        // ToLower Bütün karakterleri küçük harfe çevirmeye yarar
        var result9 = sentence.ToLower();
        // ToUpper hepsini büyük harfe çevirir
        var result10 = sentence.ToUpper();
        // Bir metin içerisinde belli karakterleri değiştirmek için kullanırız yani My boşluk yerine - kullanmak istiyorum gibi.
        var result11 = sentence.Replace(" "," -");
        // Bir metinden belli bir indexten sonrasını atmak için kullanılır örneğin 'my'dan sonrasını atmak istiyoruz
        var result12 = sentence.Remove()
        //
        var result13 = sentence.
        //
        var result14 = sentence.













        Console.WriteLine(result);

        Console.ReadLine();



    }
    private static void Intro()
    {
        //--------* String İle Çalışmaya Başlamak *--------
        // String metinsel verileri tutmak için kullanılan değişken tipidir.
        // Her ne kadar string veri tipi olsada kendi başına aynı zamanda char arrayidir.
        string city = "Ankara";
        //Console.WriteLine(city[0]);
        // ÇIKTI: Alt alta a n k a r a
        foreach (var item in city)
        {
             Console.WriteLine(item);
        }

        // 2 string rahatlıkla toplayabiliyoruz.
        // 2 tane stringi yan yana getirir. Çıktı: Ankaraİstanbul  
        string city2 = "İstanbul";
        string result = city + city2;
        // Console.WriteLine da formatlı bir stringtir kabul eder. Ama bir değişkene atarken kullanabiliriz String.Format'ı
        //Console.WriteLine(String.Format("{0} {1}",city,city2));// Bu kullanım bellekte 3. bir değişkeni tanımlamamış olacak önemli bir konudur. 
        Console.WriteLine(result);

    }
}