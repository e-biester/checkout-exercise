using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Checkout
{
    [TestFixture]
    public class CheckoutTests
    {
        private PricingRule[] _pricingRules;

        [SetUp]
        public void Init()
        {
            _pricingRules = new PricingRule[] { new AppleTV3for2DealPricingRule(), new FreeHDMIAdapterWithMacbookPricingRule(), new Nexus9BulkDiscountPricingRule() };
        }

        [Test]
        public void ExampleScenarios1Test()
        {
            var co = new Checkout(_pricingRules);
            co.Scan("atv");
            co.Scan("atv");
            co.Scan("atv");
            co.Scan("hdm");
            Assert.AreEqual(249M, co.Total());
        }

        [Test]
        public void ExampleScenarios2Test()
        {
            var co = new Checkout(_pricingRules);
            co.Scan(new atv());
            co.Scan(new nx9());
            co.Scan(new nx9());
            co.Scan(new atv());
            co.Scan(new nx9());
            co.Scan(new nx9());
            co.Scan(new nx9());
            Assert.AreEqual(2718.95M, co.Total());
        }

        [Test]
        public void ExampleScenarios3Test()
        {
            var co = new Checkout(_pricingRules);
            co.Scan("mbp");
            co.Scan("hdm");
            co.Scan("nx9");

            Assert.AreEqual(1949.98M, co.Total());
        }

        [Test]
        public void TwoAppleTvNoDiscountTest()
        {
            var co = new Checkout(_pricingRules);
            co.Scan(new atv());
            co.Scan(new atv());

            Assert.AreEqual(2 * (new atv()).GetPrice(), co.Total());
        }

        [Test]
        public void ThreeForTwoAppleTvDiscountTest()
        {
            var co = new Checkout(_pricingRules);
            co.Scan(new atv());
            co.Scan(new atv());
            co.Scan(new atv());

            Assert.AreEqual(2 * (new atv()).GetPrice(), co.Total());
        }

        [Test]
        public void InvalidSKUTest()
        {
            var co = new Checkout(_pricingRules);
            Assert.Throws<Exception>(() => co.Scan("Invalid_SKU"));
        }
    }
}
