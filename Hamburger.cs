using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessLunchOrders
{
    class Hamburger : Food
    {
        public Hamburger()
        {
            this.totalPrice = (Decimal) 6.95;
            this.addOn1 = "Lettuce, tomato, and onions";
            this.addOn2 = "Ketchup, mustard, and mayo";
            this.addOn3 = "French fries";
            this.addOnPrice = (Decimal) .75;
        }
    }
}
