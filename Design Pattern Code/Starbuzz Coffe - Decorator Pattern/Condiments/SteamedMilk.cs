﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamed Milk";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
