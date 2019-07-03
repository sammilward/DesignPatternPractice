using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public interface IMenu
    {
        IIterator CreateIterator();
    }
}
