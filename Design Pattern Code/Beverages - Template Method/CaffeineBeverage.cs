using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Beverages___Template_Method
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments()) AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
