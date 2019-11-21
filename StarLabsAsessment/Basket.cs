using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsAsessment
{
    class Basket
    {
        public List<Shirt> Shirts = new List<Shirt>();
        public List<Pants> Pants = new List<Pants>();

        public double GetTotalPrice()
        {
            double totalPrice = 0;

            foreach (var shirt in Shirts)
            {
                totalPrice += shirt.getDefaultPrice();
            }

            foreach (var pants in Pants)
            {
                totalPrice += pants.getDefaultPrice();
            }
            
            return totalPrice;
        }
    }
}
