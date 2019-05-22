using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessLunchOrders
{
    class Salad : Food
    {
        public Salad()
        {
            this.totalPrice = (Decimal)4.95;
            this.addOn1 = "Croutons";
            this.addOn2 = "Bacon bits";
            this.addOn3 = "Breadsticks";
            this.addOnPrice = (Decimal).25;
        }
    }
}
