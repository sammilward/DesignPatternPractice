using Design_Pattern_Code.Remote_Control___Command_Pattern.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Remote_Control___Command_Pattern
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand previousCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            for(int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
            }

            for (int i = 0; i < offCommands.Length; i++)
            {
                offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonPushed(int slot)
        {
            onCommands[slot].Execute();
            previousCommand = onCommands[slot];
        }

        public void offButtonPushed(int slot)
        {
            offCommands[slot].Execute();
            previousCommand = offCommands[slot];
        }

        public void Undo()
        {
            previousCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-----------Remove control------------");
            for(int i = 0; i < onCommands.Length; i++)
            {
                sb.Append("\n" + i + " On: " + onCommands[i].ToString() + "| Off: " + offCommands[i].ToString());
            }
            return sb.ToString();
        }
    }
}
