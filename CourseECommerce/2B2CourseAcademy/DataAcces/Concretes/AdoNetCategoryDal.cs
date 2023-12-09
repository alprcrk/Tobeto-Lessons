using Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concretes
{
    public class AdoNetCategoryDal
    {
        public void Add(Category category) 
        {
            //SQL Çalışır
            Console.WriteLine("Ado.NET Kullanarak veritabanına eklendi");
        }
    }
}
