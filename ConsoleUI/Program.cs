using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    static void Main(string[] args)
    {
        ProductTest();
       // CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
        Console.Read();
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetProductDetails())
        {
            Console.WriteLine(product.ProductName+ "/" +product.CategoryName);
        }
        Console.Read();
    }
}