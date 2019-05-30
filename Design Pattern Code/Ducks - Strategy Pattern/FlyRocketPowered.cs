using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class FlyRocketPowered : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I fly with a rocket");
        }
    }
}
