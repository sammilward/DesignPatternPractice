using Design_Pattern_Code.Remote_Control___Command_Pattern.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Remote_Control___Command_Pattern.Commands
{
    public class StereoOnCommand : ICommand
    {
        Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd("The Hunna - Dare");
            _stereo.SetVolume(10);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
