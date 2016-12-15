using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class hdm : Item
    {
        public override string GetName()
        {
            return "HDMI adapter";
        }
        public override decimal GetPrice()
        {
            return 30.00M;
        }
    }
}
