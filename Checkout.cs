using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Checkout
    {
        IEnumerable<PricingRule> _pricingRules;
        List<Item> _items = new List<Item>();

        public Checkout(IEnumerable<PricingRule> PricingRules)
        {
            _pricingRules = PricingRules;
        }

        public void Scan(Item ScannedItem)
        {
            _items.Add(ScannedItem);
            
            foreach (PricingRule rule in _pricingRules)
            {
                var orderUpdate = rule.ProcessItem(ScannedItem);
                if (orderUpdate != null)
                    _items.Add(orderUpdate);
            }
        }

        public void Scan(string SKU)
        {
            if (SKU == "nx9")
                Scan(new nx9());
            else if (SKU == "mbp")
                Scan(new mbp());
            else if (SKU == "atv")
                Scan(new atv());
            else if (SKU == "hdm")
                Scan(new hdm());
            else
                throw new Exception("Unknown SKU");
        }

        public Decimal Total()
        {
            return _items.Sum(i => i.GetPrice());
        }

    }
}
