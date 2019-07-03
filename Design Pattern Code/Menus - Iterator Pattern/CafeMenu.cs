using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class CafeMenu : IMenu
    {
        Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries", "Veggite burger on a whole wheat bun", true, 3.99);
            AddItem("Soup of the day", "A cup of soup of the dat with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito with whole pinto beans and salsa", true, 3.99);
        }

        public void AddItem(string name, string description, bool vegatarian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegatarian, price);
            menuItems.Add(item.Name, item);
        }

        public IIterator CreateIterator()
        {
            return new CafeIterator(menuItems);
        }

    }
}
