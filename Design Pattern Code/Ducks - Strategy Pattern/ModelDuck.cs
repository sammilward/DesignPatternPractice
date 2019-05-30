using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Model Duck");
        }
    }
}
