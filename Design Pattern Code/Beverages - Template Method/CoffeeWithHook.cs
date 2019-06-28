using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Beverages___Template_Method
{
    public class CoffeeWithHook : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override bool CustomerWantsCondiments()
        {
            if (GetUserInput().StartsWith('y')) return true;
            return false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("Do you want milk and tea [Y]es, [N]o");

            return Console.ReadLine();
        }
    }
}
