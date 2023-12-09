using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance // Kalıtım / Miras şeklinde düşünebileceğimiz yapılardır
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------* Kalıtıma Giriş *--------
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Alper" 
                },new Student
                {
                    FirstName = "Ahmet" 
                },new Person
                {
                    FirstName = "Salih"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
            //Customer customer = new Customer();
            // Interfacelerde birer Inheritance örneği gibi çalışırlar fakat Inheritance değildir o Implamentasyondur fakat Inheritance kullanılırlar yeni nesil dillerde 

        }
    }
    //classlar tek başına olsa bile bir anlam ifade ediyor veya Inheritance verdiği noktada da
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    // Classların tek başına bir anlamı vardır.
    // Interfacelerin tek başına bir anlamı yoktur.
    class Customer:Person // Customer ın ebeveyni Person'dır yani Customer aslında Persondan dünyaya gelmiş bir nesne gibi düşünebiliriz. Customer ın babası Persondır.
    {
        public string City { get; set; }
    }
    class Student : Person // Customer ın ebeveyni Person'dır yani Customer aslında Persondan dünyaya gelmiş bir nesne gibi düşünebiliriz. Customer ın babası Persondır.
    {
        public string Department { get; set; }
    }
}
