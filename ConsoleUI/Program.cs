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
            var result = orderManager.GetAll();
            foreach (var order in result.Data)
            {
                Console.WriteLine(order.OrderDate);
            }
        }

        private static void ProductGetAll()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

    }
}
