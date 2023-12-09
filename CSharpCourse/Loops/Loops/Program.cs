internal class Program
{
    private static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForEachLoop();

        if (IsPrimeNumber(6)) 
        {
            Console.WriteLine("This is a prime number ");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }

        Console.ReadLine();
    }
    
    private static bool IsPrimeNumber(int number)
    {
        // --------* Örnek Uygulama: Asal Sayı *--------
        // Asal sayı kendisi ve 1 hariç tam böleni olmayan sayıdır.
        // Bloğu kesmek için break; ya da i = number;
        bool result = true;
        for (int i = 2; i < number-1 ; i++)  
        {
            if (number%i==0) // number sayının 'i' yi bölümünden kalan yani modu 0 ise o zaman result = false yap   
            {
                result = false;
                i = number;
            }
        }
        return result;
    }

    private static void ForEachLoop()
    {
        // --------* ForEach Döngüsü *--------
        // Dizi temelli dataların dolaşılması yani Iterate edilebilmesi için kullanılır.
        // Not: örneğin döngünün içersinde o anki gezdiğimiz student "Ahmet" hata veriyor nedeni şu foreachle döndüğümüz elemanlarının kendisini foreachın içersinde değiştiremiyoruz
        // Foreach daha çok biz örneğin bir veri tabanından bir tabloyu çektiğimizde datayı gezmek için sıklıkla kullanırız.
        // Üzerinde array odaklı olan Iterate edilebilir yani dolaşılabilir nesnelere karşılık gelir   
        string[] students = new string[3] { "Engin", "Derin", "Salih" };

        foreach (var student in students) 
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        //--------* Do While Döngüsü *--------
        
        

        // Önce bir do bloğu sonrasında ise şart normal while döngüsünden tek farkı do çalışır sonra şarta bakar şart sağlanmasa bile do döngüsü mutlaka bir kere çalışacaktır      
        // Şart sağlanmasa  bile örneğin data yoksa bağlantıyı kapatma gibi düşünebiliriz
        //
        int number = 10; 
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number>=0);

    }
    private static void WhileLoop()
    {
        //--------* While Döngüsü *--------
        // İnfinite Loop dediğimiz sonsuz döngüye girer yani sayı 100 den büyük mü büyük
        // number--; sayıyı bir bir azalt
        int number = 100;
        while(number >=0) 
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);

    }
    private static void ForLoop()
    {
        //--------* For Döngüsü *--------
        // Döngüler için int i = 1 bu şu anlama geliyor bu 'i'sadece bu blokta kullanılabilir.
        // i = 1 bu bizim sayacımız yani başlangıç değerimiz int i = ise başlangıcımız kaçtan başlayacağım veya neyle başlayacağım gibi
        // i <= 100 Kısım ise bizim şartımız dönecem ama hangi şarta kadar dönecem i 100'den küçük eşit olduğu sürece
        // i++ Bir dönüş bittiğinde bir sonra ki dönüşte ne yapayım? i'yi 1 arttır
        // 1 İLE 100 arasında ki tek sayıları yazdırmak isteseydim i+=2 ya da i=i+2
        // 1 den itibaren çift sayıları yazdırmak isteseydim başlangıç kısmı i = 2 
        // 100 den itibaren geriye saydırmak istersek i = 100; i >= 0; i=i-2
        for (int i = 100; i >= 0; i -= 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Finished!");
    }

}