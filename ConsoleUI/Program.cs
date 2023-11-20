using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.getAll())
        {
            Console.WriteLine(product.ProductName);
        }
        Console.Read();
    }
}