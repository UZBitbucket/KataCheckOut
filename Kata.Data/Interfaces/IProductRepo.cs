using Kata.Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace Kata.Data.Interfaces
{
   public interface IProductRepo
    {
        List<Product> GetProducts();
    }
}
