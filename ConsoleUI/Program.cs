using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductGetAll();
            //OrderTest();


        }



        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var order in orderManager.GetAll())
            {
                Console.WriteLine(order.OrderDate);
            }
        }

        private static void ProductGetAll()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            
                foreach (var product in productManager.GetProductDetails())
                {
                    Console.WriteLine(product.ProductName + "/" +product.CategoryName);
                }
            
        }
    }
}
