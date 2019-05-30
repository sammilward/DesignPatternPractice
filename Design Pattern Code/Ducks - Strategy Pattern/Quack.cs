using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class Quack : IQuackable
    {
        void IQuackable.Quack()
        {
            Console.WriteLine("QUACK!");
        }
    }
}
