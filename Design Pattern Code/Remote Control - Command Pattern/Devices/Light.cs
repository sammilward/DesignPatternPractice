using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Remote_Control___Command_Pattern.Devices
{
    public class Light
    {
        private string _location;

        public Light(string location)
        {
            _location = location;
        }
        public void On()
        {
            Console.WriteLine(_location + " light on");
        }

        public void Off()
        {
            Console.WriteLine(_location + " light off");
        }
    }
}
