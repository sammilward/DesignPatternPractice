 using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
