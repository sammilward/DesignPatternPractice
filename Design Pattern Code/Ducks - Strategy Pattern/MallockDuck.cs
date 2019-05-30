using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class MallockDuck : Duck
    {
        public MallockDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a MallockDuck");
        }
    }
}
