using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BasketManager
    {
        //naming convention
        public void Add(Product product) // Bir yerde bunun gibi normal parantez görürsek anlayalım ki orada bir metot çalışıyordur (csharp) için geçerli java da olabilir 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Name);
        }
        // bir classın içinde birden fazla metot olabilir.
        //önemli
        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
