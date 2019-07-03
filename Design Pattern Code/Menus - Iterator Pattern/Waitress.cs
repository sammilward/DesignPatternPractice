using System;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class Waitress
    {
        MenuComponent allMenus;


        public Waitress(MenuComponent menus)
        {
            allMenus = menus;
        }

        public void PrintMenu()
        {
             allMenus.Print();
        }

        public void PrintVegatarianMenu()
        {
            IIterator iterator = allMenus.CreateIterator();
            System.Console.WriteLine("Vegatarian Menu\n-----------\n");
            while(iterator.HasNext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.Next();
                try
                {
                    if (menuComponent.IsVegatarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (InvalidOperationException e)
                {

                }
            }
        }
    }
}
