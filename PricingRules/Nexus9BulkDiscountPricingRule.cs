using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class Nexus9BulkDiscountPricingRule : PricingRule
    {
        private const int NoToGetBulkDiscount = 5;
        private const decimal Nexus9DiscountPrice = 499.99M;
        private const string DiscountName = "Nexus 9 Bulk Discount";

        private int _noOfNexus9s;

        public override Item ProcessItem(Item ScannedItem)
        {
            if (ScannedItem is nx9)
            {
                ++_noOfNexus9s;
                if (_noOfNexus9s == NoToGetBulkDiscount)
                {
                    return new DiscountItem(DiscountName, -NoToGetBulkDiscount * (ScannedItem.GetPrice() - Nexus9DiscountPrice));
                }
                else if (_noOfNexus9s > NoToGetBulkDiscount)
                {
                    return new DiscountItem(DiscountName, ScannedItem.GetPrice() - Nexus9DiscountPrice);
                }
            }
            return null;
        }
    }
}
