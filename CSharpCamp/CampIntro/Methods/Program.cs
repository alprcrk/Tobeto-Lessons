using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Karpuzu";
            // Array bir veri tipinde istediğin kadar ne kadar data eklersek o datayı tutan yapıdır.
            // Data bir veri kaynağından gelir 
            // Diziler ( urun1, urun2, ) genellikle bir veri kaynağından gelir.
            // Bu bir veritabanı olabilir bu bir api olabilir bu bir excel dosyasıda olabilir bu bir metin dosyası olabilir vb.
            Product[] products = new Product[] { product1, product2, };
            // Niye veri tipini yazıyoruz csharp java gibi programlama dilleri tip güvenlidir. --type-safe
            foreach (Product urun in products)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Explanation);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("----------------Methods-------------------");
            //instance - örnek
            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);


            basketManager.Add2("Armut", "Yeşil armut", 12, 10);
            basketManager.Add2("Elma", "Yeşil elma", 12, 1);
            basketManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 1);

            Console.ReadKey();


        }
    }
}
