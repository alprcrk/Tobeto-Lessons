

using Entity.Concretes;
namespace ConsoleUI
{
internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();

        product1.Id = 1;
        product1.Name = "SİLGİ";
        product1.UnitPrice = 25;

        Console.WriteLine(product1.Id+product1.Name+product1.UnitPrice);
    }
}

}