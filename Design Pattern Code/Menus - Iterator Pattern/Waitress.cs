using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class Waitress
    {
        PancakeHouseMenu PancakeMenu;
        DinerMenu DinerMenu;

        public Waitress(PancakeHouseMenu pancakeMenu, DinerMenu dinerMenu)
        {
            PancakeMenu = pancakeMenu;
            DinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = PancakeMenu.CreateIterator();
            IIterator dinerIterator = DinerMenu.CreateIterator();
            Console.WriteLine("Menu\n-----\nBreakfast\n");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLunch\n");
            PrintMenu(dinerIterator);
        }

        public void PrintMenu(IIterator iterator)
        {
            while(iterator.HasNext())
            {
                MenuItem item = (MenuItem)iterator.Next();
                Console.WriteLine(item.Name + ", ");
                Console.WriteLine(item.Price+ " -- ");
                Console.WriteLine(item.Description);
            }
        }
    }
}
