using Kata.Data.Interfaces;
using Kata.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main
{
    public class StandardPrice : IStandardPrice
    {
        private readonly IProductRepo _productRepo;
        public StandardPrice(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

       

        public decimal GetPrice(string sku)
        {
            decimal total = 0;
            char[] skuChar;
            var products = _productRepo.GetProducts();

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
