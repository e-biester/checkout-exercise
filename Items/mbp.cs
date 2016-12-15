using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class mbp : Item
    {
        public override string GetName()
        {
            return "MacBook Pro";
        }
        public override decimal GetPrice()
        {
            return 1399.99M;
        }
    }
}
