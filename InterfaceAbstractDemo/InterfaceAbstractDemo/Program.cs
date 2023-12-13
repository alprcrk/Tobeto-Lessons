using InterfaceAbstract.Entities;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

public class Program
{
    private static void Main(string[] args)
    {                                             //StarbucksCustomerManager
        BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
        customerManager.Save(new Customer
        {
            DateOfBirth = new DateTime(1990, 1, 1),
            FirstName = "Alper",
            LastName = "Çırak",
            NationalityId = "9999999999"
        });
    }
}