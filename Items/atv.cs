using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class atv : Item
    {
        public override string GetName()
        {
            return "Apple TV";
        }
        public override decimal GetPrice()
        {
            return 109.50M;
        }
    }
}
