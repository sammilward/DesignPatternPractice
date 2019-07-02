using System.Collections.Generic;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class PancakeHouseMenu
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        public PancakeHouseMenu()
        {
            AddItem("KBs Pancake Breakfast", "Pancake with scrambled egg and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancake with fried and sausage", false, 2.99);
            AddItem("Bluebery Pancakes", "Pancakes with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegatarian, double price)
        {
            menuItems.Add(new MenuItem(name, description, vegatarian, price));
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }
    }
}
