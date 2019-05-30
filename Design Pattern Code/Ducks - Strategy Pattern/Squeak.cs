using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class Squeak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("SQUEAK");
        }
    }
}
