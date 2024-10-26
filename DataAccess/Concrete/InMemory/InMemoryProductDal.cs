using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() { 
            new Product{ CategoryId = 1 , ProductId= 1, ProductName = "Bardak", UnitsInStock = 12, UnitPrice= 20},
            new Product{ CategoryId = 2 , ProductId= 2, ProductName = "Masa", UnitsInStock = 12, UnitPrice= 20},
            new Product{ CategoryId = 3 , ProductId= 3, ProductName = "Tabak", UnitsInStock = 12, UnitPrice= 20},
            new Product{ CategoryId = 4 , ProductId= 4, ProductName = "Klavye", UnitsInStock = 12, UnitPrice= 20},
            new Product{ CategoryId = 5 , ProductId= 5, ProductName = "Fare", UnitsInStock = 12, UnitPrice= 20},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete  = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int CategoriesId)
        {
          return  _products.Where(p => p.CategoryId == CategoriesId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;  
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
