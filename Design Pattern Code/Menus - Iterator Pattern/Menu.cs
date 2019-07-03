using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            Console.WriteLine("\n" + name);
            Console.WriteLine(description);
            Console.WriteLine("---------------------------");

            List<MenuComponent>.Enumerator iterator = menuComponents.GetEnumerator();
            while(iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent.Print();
            }
        }

        public override IIterator CreateIterator()
        {
            return new CompositeIterator(menuComponents.GetEnumerator());
        }
    }
}
