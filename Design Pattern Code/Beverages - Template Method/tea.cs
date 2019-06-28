using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Beverages___Template_Method
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add lemon");
        }
    }
}
