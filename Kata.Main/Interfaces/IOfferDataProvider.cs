using Kata.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main.Interfaces
{
   public interface IOfferDataProvider
    {
        List<SpecialOffer> GetOffers();
    }
}
