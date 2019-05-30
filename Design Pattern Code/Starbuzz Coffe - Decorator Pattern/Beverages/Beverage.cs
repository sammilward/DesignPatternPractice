using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern
{
    public abstract class Beverage
    {
        protected string description = "Unkown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();        
    }
}
