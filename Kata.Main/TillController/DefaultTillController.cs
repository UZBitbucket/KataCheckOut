using Kata.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main.TillController
{
    public class DefaultTillController : ITillController
    {
        private IStandardPrice _standardPricer;
        private ISpecialOfferHandler _offerHandler;
        public DefaultTillController(IStandardPrice standardPricer, ISpecialOfferHandler offerHandler)
        {
            _standardPricer = standardPricer;
            _offerHandler = offerHandler;
        }

        private string _items = "";

        public void Scan(string item)
        {
            _items = $"{_items}{item}";
        }

        public decimal Total()
        {
            decimal standardPrice = _standardPricer.GetPrice(_items);

            return _offerHandler.ApplyOffers(standardPrice, _items);
        }
    }
}
