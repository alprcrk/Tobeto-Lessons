internal class Program
{
    private static void Main(string[] args)
    {
        //IntarfacesIntro();
        //Demo();
        //Intarfacelerle ilgili durum şu dur bir intarface hiç bir zaman newlenemez çünkü tek başına bir anlamı yoktur yani benim IPerson kişimi person dediğim zaman = new 
        //IPerson person = new Customer();  //Intarface kendi başına newlememiz mümkün değildir. /

        //Bizim bir verimiz var ve bu veriyi hem şirketin oracle veri tabanına hemde sql veri tabanına yazmak istiyoruz

        //Ben arrayın içerisine 2 tane değişken attım bunlardan birisi sql için biri oracle için amacım neydi şirketteki bütün veri tabanlarına aynı datayı bütün veritabanlarına atmak istiyoruz.
        // cutomerDalları gezdim her biri için .Add çalıştırdım
        ICustomerDal[] customerDals = new ICustomerDal[2]
        {   // bir classı kulanabilmek için
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
        };  
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }


        Console.ReadLine();
    }


    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());

    }


    private static void IntarfacesIntro()
    {
        // --------* Interfacelere Temel Giriş *-------- 
        // interfacelerin en büyük kullanım amacı bir temel operasyon temel nesne oluşturup bütün nesneleri ondan ıplemente etmektir
        // interfaceler yazılırken tamamen metotun imzası işte voitse voit dönüş değeri varsa dönüş değeri ismi ve özelliği yazılır 

        PersonManager manager = new PersonManager();
        //Diğer Kullanım
        //manager.Add(new Customer {Id = 1, FirstName = "Alper", LastName = "Çırak", Address = "Uşak"});
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Alper",
            LastName = "Çırak",
            Address = "Uşak"
        };
        Student student = new Student
        {
            Id = 1,
            FirstName = "Alper",
            LastName = "Çırak",
            Departmant = "Computer Sciences"
        };
        manager.Add(customer);
        manager.Add(student);
    }
    interface IPerson
    {
        // Burda interfaceler şu anlama geliyor sen bu özellikleri tanımladıysan bunların karşılığını class Customer:IPerson bu interfaceyi Implemente eden classın içerisinde yazmak zorundasın
        // Bu interfacelerin tanımlanan operasyonları özellik ya da metot farketmez bunların da doldurması gerektiği implemente ettiğimizde her birinin ayrı ayrı implemente etmesi gerekliliğiyle ilgili temel kuraldır fakat interfaceler şu an yaptığımızdan yaptığımızın üstüne çok daha büyük ve çok daha önemli amaçlar için kullanılırlar  
           int Id { get; set; }
           string FirstName {  get; set; }
           string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; } // Müşteride şu 3'ünü ımplemente etti 
        public string FirstName { get; set; } // Müşteride şu 3'ünü ımplemente etti 
        public string LastName { get; set; } // Müşteride şu 3'ünü ımplemente etti 
        // Müşteri için bir durumu söz konusu müşteriye özel özellikleride aynı devam etirebiliriz 
        // Örneğin sadece bir müşteride olan bir özelliği barındırmak istiyorsak müşterinin içerisinde örneğin;
        // Müşteriye ait ayrıca bir özellik öğrenciye ait ayrıca bir özelliği tanımlayabildik
        public string Address { get; set; }
    }
    class Student: IPerson
    {
        public int Id { get; set; } // Müşteride şu 3'ünü ımplemente etti 
        public string FirstName { get; set; }// Müşteride şu 3'ünü ımplemente etti 
        public string LastName { get; set; }// Müşteride şu 3'ünü ımplemente etti 
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; } // Müşteride şu 3'ünü ımplemente etti 
        public string FirstName { get; set; }// Müşteride şu 3'ünü ımplemente etti 
        public string LastName { get; set; }// Müşteride şu 3'ünü ımplemente etti 
        public string Departmant { get; set; }
    }
    // --------* Interfaceleri Neden Kullanıyoruz *-------- 
    //Proje Ekibi Çalışmalarını Kolaylaştırma, Bileşen Tabanlı Geliştirme, Kodun Daha İyi Organizasyonu,
    //Unit Test Kolaylığı, Kodun Geçirilebilirliği ve Esneklik, Çoklu Mirasın Yerine Geçme, Sözleşme ve Zorunluluk İşlevi
    class PersonManager
    {
        //IPerson verdiğimizde burda ister customer gönderirim ister student
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}