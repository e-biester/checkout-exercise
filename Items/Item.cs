using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public abstract class Item
    {
        abstract public string GetName();
        abstract public decimal GetPrice();
    }
}
