using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I use my wings to fly");
        }
    }
}
