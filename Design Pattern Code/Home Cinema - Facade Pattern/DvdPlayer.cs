using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Home_Cinema___Facade_Pattern
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player turning on");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player turning off");
        }

        public void Play()
        {
            Console.WriteLine("Playing DVD");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping DVD");
        }
    }
}
