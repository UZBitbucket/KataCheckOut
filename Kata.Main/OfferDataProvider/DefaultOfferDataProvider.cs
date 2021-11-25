using Kata.Domain.Models;
using Kata.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main.OfferDataProvider
{
    public class DefaultOfferDataProvider : IOfferDataProvider
    {
        public List<SpecialOffer> GetOffers()
        {
            return new List<SpecialOffer>()
            {
                new SpecialOffer() {Item = "B", Quantity=3, Reduction=0.05M},
                new SpecialOffer() {Item = "D", Quantity=2, Reduction=0.275M}
            };
        }
    }
}
