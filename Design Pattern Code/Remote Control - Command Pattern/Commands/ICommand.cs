using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Remote_Control___Command_Pattern.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
