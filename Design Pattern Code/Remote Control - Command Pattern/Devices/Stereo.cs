using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Remote_Control___Command_Pattern.Devices
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo On");
        }

        public void Off()
        {
            Console.WriteLine("Stereo Off");
        }

        public void SetCd(string cdName)
        {
            Console.WriteLine("Playing CD: " + cdName);
        }

        public void SetRadio(string radioStationName)
        {
            Console.WriteLine("Playing Radio Station: " + radioStationName);
        }

        public void SetVolume(int volumeLevel)
        {
            Console.WriteLine("Volume set to: " + volumeLevel);
        }
    }
}
