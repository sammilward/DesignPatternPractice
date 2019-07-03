using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Menus___Iterator_Pattern
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; }

        public MenuItem(string name, string description, bool vegatarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegatarian;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine("\n"+Name);
            if (Vegetarian) Console.WriteLine("(V)");
            Console.WriteLine(Price);
            Console.WriteLine(Description);
        }

        public override IIterator CreateIterator()
        {
            return new NullIterator();
        }
    }
}
