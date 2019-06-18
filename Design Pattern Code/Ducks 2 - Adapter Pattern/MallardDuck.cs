using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Ducks_2___Adapter_Pattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am flying far!");
        }

        public void Quack()
        {
            Console.WriteLine("QUACK!");
        }
    }
}
