using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Services
{
    public class ProductService : IProduct
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product(){Id = 0, Name = "Coffee", Price = 10},
            new Product(){Id = 1, Name = "Tea", Price = 15}
        };
        public Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            _products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        public Product UpdateProduct(int id, Product product)
        {
            _products[id] = product;
            return product;
        }
    }
}
