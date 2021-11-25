using Kata.Main;
using Kata.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KataPrice.Test
{
   public class StandardPriceTest
    {

        


        [Fact]
        public static void WhenIGivenAnNullItemReturn0()
        {
            IStandardPrice pricer = new StandardPrice();
            var expected = 0;
            var actual = pricer.GetPrice(null);
            Assert.Equal(expected, actual);
        }



        [Fact]
        public static void WhenIGivenAnEmptyStringItemReturn0()
        {
            IStandardPrice pricer = new StandardPrice();
            var expected = 0;
            var actual = pricer.GetPrice("");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void WhenIGiveAValidItemReturnTheValueOfTheItem()
        {
            IStandardPrice pricer = new StandardPrice();
            Assert.Equal(10M, pricer.GetPrice("A"));
            Assert.Equal(15M, pricer.GetPrice("B"));
            Assert.Equal(40M, pricer.GetPrice("C"));
            Assert.Equal(50M, pricer.GetPrice("D"));
        }

        [Fact]
        public static void WhenIGiveSeveralItemsExpectTheTotal()
        {
            var input = "ABB";
            IStandardPrice pricer = new StandardPrice();
            var expected = 40M;
            var actual = pricer.GetPrice(input);

            Assert.Equal(expected, actual);
        }
    }
}
