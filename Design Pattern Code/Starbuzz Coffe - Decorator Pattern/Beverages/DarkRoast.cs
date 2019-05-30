using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
