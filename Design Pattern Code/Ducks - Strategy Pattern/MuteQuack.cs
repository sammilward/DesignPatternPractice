using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine(".....");
        }
    }
}
