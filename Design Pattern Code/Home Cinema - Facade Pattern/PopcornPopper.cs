using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Home_Cinema___Facade_Pattern
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Turning popcorn machine on");
        }

        public void Off()
        {
            Console.WriteLine("Turning popcorn machine off");
        }

        public void Pop()
        {
            Console.WriteLine("Popping corn");
        }
    }
}
