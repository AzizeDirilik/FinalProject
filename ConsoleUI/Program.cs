using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ProductManager productManager = new ProductManager(new EfProductDal());

            var products = productManager.GetAll();
            if (products != null && products.Any())
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine("No products found.");
            }

        }
    }
}
