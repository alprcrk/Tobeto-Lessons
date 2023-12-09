internal class Program
{
    private static void Main(string[] args)
    {
        // --------* Classlara Giriş *--------
        // Kullanım Alanı: Nesne Yönelimli Programlama (OOP), Veri Modelleme, Veri Gizleme (Encapsulation), Veritabanı Bağlantısı 
        // Bizim yapmak istediğimiz işlemleri gruplara ayırmak bu grup üzerinden işlemlerimizi yapmak ve rahatlıkla bu gruba ulaşmak için kullanabiliriz
        // Bu çerceve de kullanabilmek için bir class ı onun bir örneğini oluşturmamız gerekir.
        // Yani bu şu anlama geliyor class CustomerManager bu classın bir örneğini oluşturdum. Bir referansınıda oluşturdum diyebilirim.

        // bu çerceve de bir class oluşturulurken 'CustomerManager' gibi pascal case yani kelimelerin ilk harfleri büyük oluşturulur.
        CustomerManager customerManager = new CustomerManager();
        // ama onun örneği oluşturulduğunda camel case döner yani kelimenin sadece ilk harfi küçük ama sonra ki kelimelerin ilk harfi büyük yazılır
        customerManager.Add();
        customerManager.Update();
        
        Porduct Manager productManager = new ProductManager();
        ProductManager.Add();
        ProductManager.Update();
        // yani ben hangi nesneyle çalışacaksam o nesneye ait classı örneğini oluşturuyorum sonra içinde ki metotları istediğim gibi çağırabiliyorum
        // Classes --> Add --> Class --> ProductManager / Ayrı bir dosya yoluylada çalışılabilir.

        // --------* Classlar İçinde Property Tanımlamak *--------
        // Classların bir diğer özelliği ise property dediğimiz nesneleri/özellikleri tutmaktır
        // burada bir customer nesnesi tanımlayacağım zaman class ı kullanabilmek için onu newlememiz gerekiyordu yani bir örneğini oluşturmamız gerekiyordu
        // 
        Customer customer=new  Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Alper";// Eşittir dediğimiz zaman yani bir classın propertysine eşittir dediğimiz zaman bizim için bu propertyde ki set bloğu çalışır yani biz set ediyoruz 
        customer.LastName = "Çırak";
        // Bu şekilde kullanabiliriz.
        // Diğer Kullanımı 
        customer customer2 = new Customer
        {
            Id = 2, City = "İstanbul", FirstName = "Alper" , LastName = "Çırak" // Bir tane kayıt oluşturmuş olduk
        }; 


        Console.ReadLine();
    }
    class CustomerManager // Class
    {
        public void Add() //içinde *2 tane metot oluşturuldu 
        {
            Console.WriteLine("Customer Added!")
        }
        //Örneğin bir müştereyi güncellemek istiyoruz
        public void Update() 
        {
            Console.WriteLine("Customer Updated!");
        }
    }
    class  ProductManager // Class
    {
        public void Add() //içinde *2 tane metot oluşturuldu 
        {
            Console.WriteLine("Product Added!")
        }
        //Örneğin bir müştereyi güncellemek istiyoruz
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }

}