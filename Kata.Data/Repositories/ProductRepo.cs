using Kata.Data.Interfaces;
using Kata.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Data.Repositories
{
    public class ProductRepo : IProductRepo
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>()
            {
                new Product{SKU="A", Price=10M},
                new Product{SKU="B", Price=15M},
                new Product{SKU="C", Price=40M},
                new Product{SKU="D", Price=50M},

            };
            return products;
        }
    }
}
