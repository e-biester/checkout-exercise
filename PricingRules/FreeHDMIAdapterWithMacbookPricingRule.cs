using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class FreeHDMIAdapterWithMacbookPricingRule : PricingRule
    {
        private const string DiscountName = "Free HDMI Adapter With Macbook";

        private int _unmatchedMacbookPros;
        private int _unmatchedHDMIadapters;
        public override Item ProcessItem(Item ScannedItem)
        {
            if (ScannedItem is mbp)
                ++_unmatchedMacbookPros;
            if (ScannedItem is hdm)
                ++_unmatchedHDMIadapters;

            if (_unmatchedMacbookPros > 0 && _unmatchedHDMIadapters > 0)
            {
                --_unmatchedMacbookPros;
                --_unmatchedHDMIadapters;
                return new DiscountItem(DiscountName, -(new hdm()).GetPrice());
            }

            return null;
        }
    }
}
