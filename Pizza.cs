using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessLunchOrders
{
    class Pizza : Food
    {
        public Pizza()
        {
            this.totalPrice = (Decimal)5.95;
            this.addOn1 = "Pepperoni";
            this.addOn2 = "Sausage";
            this.addOn3 = "Olives";
            this.addOnPrice = (Decimal).50;
        }
    }
}
