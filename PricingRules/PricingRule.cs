﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public abstract class PricingRule
    {
        public abstract Item ProcessItem(Item ScannedItem);
    }
}
