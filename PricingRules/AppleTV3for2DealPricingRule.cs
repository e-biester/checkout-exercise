using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class AppleTV3for2DealPricingRule : PricingRule
    {
        private const string DiscountName = "Apple TV 3 for 2 Deal";

        private int _appleTVCount;
        public override Item ProcessItem(Item ScannedItem)
        {
            if (ScannedItem is atv)
            {
                ++_appleTVCount;
                if (_appleTVCount == 3)
                {
                    _appleTVCount = 0;
                    return new DiscountItem(DiscountName, -ScannedItem.GetPrice());
                }
            }
            return null;
        }

    }
}
