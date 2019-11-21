using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsAsessment
{
    class Golfer : Shirt
    {
        public override double getDefaultPrice()
        {
            return base.getDefaultPrice() * 2;
        }
    }
}
