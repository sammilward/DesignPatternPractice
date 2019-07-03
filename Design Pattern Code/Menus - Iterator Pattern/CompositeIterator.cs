using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class CompositeIterator : IIterator
    {
        Stack stack = new Stack();

        public CompositeIterator(List<MenuComponent>.Enumerator iterator)
        {
            stack.Push(iterator);
        }

        public object Next()
        {
            if(HasNext())
            {
                IIterator iterator = (IIterator) stack.Peek();
                MenuComponent component = (MenuComponent)iterator.Next();
                if (component is Menu)
                {
                    stack.Push(component.CreateIterator());
                }
                return component;
            }
            else
            {
                return null;
            }
        }

        public bool HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                IIterator iterator = (IIterator)stack.Peek();
                if (!iterator.HasNext())
                {
                    stack.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }


    }
}
