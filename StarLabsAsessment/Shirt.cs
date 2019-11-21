using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsAsessment
{
    class Shirt : Product
    {
        public override double getDefaultPrice()
        {
            double price = 0;

            if (Size == "s")
                price = 10;
            else if (Size == "m")
                price = 20;
            else if (Size == "l")
                price = 30;

            return price;
        }
    }

  

  

}
