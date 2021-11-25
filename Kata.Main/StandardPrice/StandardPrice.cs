using Kata.Data.Interfaces;
using Kata.Domain;
using Kata.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main
{
    public class StandardPrice : IStandardPrice
    {

        List<Product> products = new List<Product>()
            {
                new Product{SKU="A", Price=10M},
                new Product{SKU="B", Price=15M},
                new Product{SKU="C", Price=40M},
                new Product{SKU="D", Price=50M},

            };

        public decimal GetPrice(string sku)
        {
            decimal total = 0;
            char[] skuChar;
            

            if (String.IsNullOrEmpty(sku))
            {
                return 0;
            }

            skuChar = sku.ToCharArray();
            foreach (var item in products)
            {
                foreach (char c in skuChar)
                {
                    if (c.ToString() == item.SKU)
                    {
                        total = total + item.Price;
                    }
                }
            }

            return total;
        }

       
    }
}
