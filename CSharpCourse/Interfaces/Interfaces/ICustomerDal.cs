using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ICustomerDal // Data Access Layer veri işlerini yapmak için kullanacağımız sınıf 
    {
        void Add();//ekleme
        void Update();//güncelleme
        void Delete();//silme
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add ()
        {
            Console.WriteLine("Sql added");
        }
        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }
        public void Update()
        {
            Console.WriteLine("Sql update")
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }
        public void Update()
        {
            Console.WriteLine("Oracle update");
        }

    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
