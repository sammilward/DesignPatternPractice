using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Beverages___Template_Method
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coddee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
