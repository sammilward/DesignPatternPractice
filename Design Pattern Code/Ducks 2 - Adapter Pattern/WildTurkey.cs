using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I am flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
