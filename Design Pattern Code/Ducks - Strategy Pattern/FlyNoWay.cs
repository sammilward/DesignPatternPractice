using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I cant fly!");
        }
    }
}
