using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsAsessment
{
    class FormalPants : Pants
    {
        public override double getDefaultPrice()
        {
            return base.getDefaultPrice() + 30;
        }
    }
}
