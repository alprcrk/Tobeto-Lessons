using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri - Alper Çırak
            Indıvidual customer1 = new Indıvidual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Alper";
            customer1.Surname = "Çırak";
            customer1.TcNo = "12345678910";


            //Tüzel Müşteri - Kodlama.io
            Coorporate coorporate2 = new Coorporate();
            coorporate2.Id = 2;
            coorporate2.CustomerNumber = "54321";
            coorporate2.CompanyName = "Kodlama.io";
            coorporate2.TaxNumber = "1234567890";
            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID

            Customer customer3 = new Indıvidual();//Gerçek Müşteri
            Customer customer4 = new Coorporate();//Tüzel Müşteri

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
