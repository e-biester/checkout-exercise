using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class nx9 : Item
    {
        public override string GetName()
        {
            return "Nexus 9";
        }
        public override decimal GetPrice()
        {
            return 549.99M;
        }
    }
}
