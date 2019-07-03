using System;
using System.Collections;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class CafeIterator : IIterator
    {
        IDictionaryEnumerator enumerable;

        public CafeIterator(Hashtable items)
        {

            enumerable = items.GetEnumerator();
        }

        public bool HasNext()
        {
            if (enumerable.MoveNext() == true) return true;
            return false;
        }

        public object Next()
        {
            return enumerable.Value;
        }
    }
}
