using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
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
            if (position >= items.Length || items[position] == null) return false;
            return true;
        }
    }
}
