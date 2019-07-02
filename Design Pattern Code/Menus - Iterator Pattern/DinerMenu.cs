using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class DinerMenu
    {
        const int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegatarian BLT", "Fake bacon with lettuce and tomato", true, 2.99);
            AddItem("BLT", "Bacon with lettuce and tomato", false, 2.99);
            AddItem("Soup of the day", "Soup of the day with potato side salad.", false, 3.29);
            AddItem("Hotdog", "Hotdog with relish, onions and topped with cheese", false, 3.05);

        }

        public void AddItem(string name, string description, bool vegatarian, double price)
        {
            if(numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("ERROR: Menu is full!");
            }
            else
            {
                menuItems[numberOfItems++] = new MenuItem(name, description, vegatarian, price);
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
