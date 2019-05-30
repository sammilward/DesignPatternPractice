using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
