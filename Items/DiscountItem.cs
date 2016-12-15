using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class DiscountItem : Item
    {
        readonly string _name;
        readonly decimal _price;

        public DiscountItem(string Name, decimal Price)
        {
            _name = Name;
            _price = Price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override decimal GetPrice()
        {
            return _price;
        }
    }
}
