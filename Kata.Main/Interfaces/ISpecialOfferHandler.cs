using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main.Interfaces
{
   public interface ISpecialOfferHandler
    {
        decimal ApplyOffers(decimal price, string items);
    }
}
