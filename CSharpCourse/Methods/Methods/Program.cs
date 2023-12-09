internal class Program
{
    private static void Main(string[] args)
    {
        // --------* Neden Metot Kullanıyoruz? *--------
        //Kullanım Alanı: Kodun Parçalara Ayrılması, Yeniden Kullanılabilirlik, Bakım Kolaylığı, Kodun Anlaşılırlığı, Kod Düzeni
        //Metotlar bizim için 'Don't repeat yourself' DRY Dediğimiz yazılım geliştirme prensibinin en iyi implementasyonlardan biridir.
        //Metotlarla bir işlemi yaptığımız zaman o işlemi bir daha kullanacağımız zaman aynı methodu kullanıo tek merkezden kontrol edebilme imkanı buluyoruz.

        //Add();
        //Add();
        //Add();
        //Add();
        //var result = Add2(20,30)

        // var result = Add2(20); burada default parametre atadığımız için number2'ye değer girilmezse default değer 30 olarak kabul edilerek toplama işlemi yapar.
        //Console.WriteLine(result);


        //int number1 = 20; // ref kullanımı için bu şekilde değer atanmalı
        //int number2 = 100;
        //var result2 = Add3(ref number1,number2);
        // Önemli : number1 değeri her ne kadar metot içinde 30 olsa da bu scopetaki değeri 20'dir.
        // ama ref değeri verirsek başına o zaman bu scopetaki değeri de number1'in her ne kadar 20 yazsa da metottaki ref değeri olan 30 olur.

        //var result2 = Add3(out number1, number2); Ref'in bir diğer alternatifi "out" keyword'udur. ref yazan yerlere out yazabiliriz.

        //Console.WriteLine(result2);
        //Console.WriteLine(Multiply(2, 4));
        //Console.WriteLine(Multiply(2, 4,5));

        //Console.WriteLine(Add4(1,2,3,4,5,6); Params metodu ile buraya dilediğimiz kadar sayı yazabiliriz tipleri aynı olma şartıyla. 

        Console.ReadLine();
    }

    static void Add()
    {
        Console.WriteLine("Added!!!");
    }

    static int Add2(int number1, int number2)
    {
        var result = number1 + number2;
        return result;
    }
    // --------* Default Parametreli Metotlar *--------
    // Metotların tanımlandığı sırada parametrelere varsayılan değerler atanmasını sağlayan bir özelliktir.
    // Bu, belirli bir parametre belirtilmediğinde varsayılan bir değerin kullanılmasını sağlar.

    //static int Add2(int number1, int number2)
    //{
    //    var result = number1 + number2;
    //    return result;
    //}

    static int Add2(int number1=20, int number2=30) // Default Parametreli
    {
        var result = number1 + number2;
        return result;
    }
    
    static int Add3(ref int number1, int number2) 
    {
        number1 = 30;
        return number1 + number2;
    }

    // --------*  Method Overloading *--------
    // Aynı isme sahip bir metodu farklı parametre listeleriyle birden fazla kez tanımlama yeteneğidir.
    // Bu, aynı isme sahip ancak farklı parametrelerle çağrılabilen metotların aynı sınıf içinde bulunmasına olanak tanır. 
    static int Multiply(int number1, int number2) // 
    {
        return number1 * number2;
    }

    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    // --------* Params Keyword İle Çalışmak *--------
    static int Add4 (int number,params int[] numbers) //Paramsla metotumuza aynı tipte istediğimiz kadar parametre gönderebileceğimiz anlamına geliyor.    
    {
        return numbers.Sum();
    }
}