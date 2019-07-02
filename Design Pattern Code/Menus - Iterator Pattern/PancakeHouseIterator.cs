using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class PancakeHouseIterator : IIterator
    {
        List<MenuItem> items;
        int position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public object Next()
        {
            MenuItem item = items[position++];
            return item;
        }

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null) return false;
            return true;
        }
    }
}
